#!/usr/bin/env bash
set -euo pipefail

# Keep CI failures actionable: GitHub's log will show the exact command and
# assertion that failed instead of only reporting an exit code.
if [[ "${CI:-}" == "true" ]]; then
  set -x
fi

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/../.." && pwd)"
CLI="$ROOT/WinAuth.Cli/bin/Release/winauth-cli.exe"
TMP="$(mktemp -d)"
trap 'rm -rf "$TMP"' EXIT

run() {
  mono "$CLI" --file "$TMP/vault.xml" "$@"
}

# RFC 4226's first HOTP vector also exercises add, list, code, persistence,
# rename, URI output, counter mutation, and removal.
run add --type hotp --name rfc --issuer test \
  --secret GEZDGNBVGY3TQOJQGEZDGNBVGY3TQOJQ --counter 0
run list | grep -F $'hotp\ttest\trfc'
test "$(run code rfc)" = "755224"
test "$(run code rfc)" = "287082"
run rename rfc renamed
run show renamed | grep -F 'otpauth://hotp/renamed?'
run sync renamed 0
test "$(run code renamed)" = "755224"
run remove renamed
test -z "$(run list)"

# URI import and encrypted-vault round trip.
run import --uri 'otpauth://totp/Example%3Aalice?secret=JBSWY3DPEHPK3PXP&issuer=Example&digits=8&period=30&algorithm=SHA256'
[[ "$(run code 'Example:alice')" =~ ^[0-9]{8}$ ]]

# Steam Guard is not numeric TOTP. It uses Valve's 5-character alphabet.
run import --uri 'otpauth://totp/Steam:Steam-test?secret=JBSWY3DPEHPK3PXP&issuer=Steam&digits=5'
run list | grep -F $'steam\tSteam\tSteam:Steam-test'
STEAM_CODE="$(run code 'Steam:Steam-test')"
EXPECTED_STEAM="$(python3 - <<'PY'
import base64, hashlib, hmac, struct, time
alphabet = "23456789BCDFGHJKMNPQRTVWXY"
secret = base64.b32decode("JBSWY3DPEHPK3PXP")
def code(counter):
    msg = struct.pack(">Q", counter)
    digest = hmac.new(secret, msg, hashlib.sha1).digest()
    offset = digest[-1] & 0x0f
    value = struct.unpack(">I", digest[offset:offset + 4])[0] & 0x7fffffff
    out = []
    for _ in range(5):
        out.append(alphabet[value % len(alphabet)])
        value //= len(alphabet)
    return "".join(out)
now = int(time.time()) // 30
print("\n".join(code(counter) for counter in (now - 1, now, now + 1)))
PY
)"
grep -Fx "$STEAM_CODE" <<<"$EXPECTED_STEAM"

mono "$CLI" --file "$TMP/encrypted.xml" --password correct add \
  --name encrypted --secret JBSWY3DPEHPK3PXP
mono "$CLI" --file "$TMP/encrypted.xml" --password correct list | grep -F encrypted
if mono "$CLI" --file "$TMP/encrypted.xml" --password wrong list >/dev/null 2>&1; then
  echo 'wrong password unexpectedly opened encrypted vault' >&2
  exit 1
fi

echo 'All WinAuth CLI tests passed.'
