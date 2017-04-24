#! /bin/bash

# Compile all the frontend components. 
# Somehow this can be done with Gulp or npm but this is much easier.

# Just to make sure everything is installed.
yarn install
# Webpack all the scripts.
webpack
# Process and minify css.
## http://lesscss.org/
node_modules/.bin/lessc --clean-css "Content/styles/styles.less" "dist/main.css"