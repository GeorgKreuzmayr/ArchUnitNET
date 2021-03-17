#!/bin/bash
# setup-ssh.sh: load the SSH key

set -ev
declare -r SSH_FILE="$(mktemp -u $HOME/.ssh/travis_temp_ssh_key_XXXX)"
# Decrypt the file containing the private key (put the real name of the variables)

openssl aes-256-cbc -k "83b31c2adcc95d69722405111a0e1b59ec8f62d301feb94cc0a62247925799c3" \
 -d -md sha256 -a -in "Travis/travis_key.enc" -out "$SSH_FILE"

# Enable SSH authentication
chmod 600 "$SSH_FILE" \
  && printf "%s\n" \
       "Host github.com" \
       "  IdentityFile $SSH_FILE" \
       "  LogLevel ERROR" >> ~/.ssh/config