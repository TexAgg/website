#! /bin/bash

# Compile all the frontend components. 
# Somehow this can be done with Gulp or npm but this is much easier.

# Just to make sure everything is installed.
yarn install
# Webpack all the scripts.
webpack
# Minify css.
cleancss "Content/styles/style.css" -o "dist/main.css"