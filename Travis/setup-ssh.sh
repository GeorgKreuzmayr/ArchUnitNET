#!/bin/bash
# setup-ssh.sh: load the SSH key

set -ev
declare -r SSH_FILE="$(mktemp -u $HOME/.ssh/travis_temp_ssh_key_XXXX)"

echo "$SSH_PRIVATE" > "$SSH_FILE"

# Enable SSH authentication
chmod 600 "$SSH_FILE" \
  && printf "%s\n" \
       "Host github.com" \
       "  IdentityFile $SSH_FILE" \
       "  LogLevel ERROR" >> ~/.ssh/config

ssh-keyscan github.com >> "$HOME/.ssh/known_hosts"

eval $(ssh-agent -s)

chmod +x "$TRAVIS_BUILD_DIR/Travis/ssh-add-helper.sh"
echo "$SSH_PASSPHRASE"| SSH_ASKPASS="$TRAVIS_BUILD_DIR/Travis/ssh-add-helper.sh" ssh-add "$SSH_FILE" 2> /dev/null

