#!/bin/bash

# For some reason, despite how new and hyped it is,
# Yarn will remove some files. This is how to fix that.

rm -rf node_modules && npm install