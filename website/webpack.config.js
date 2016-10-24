var webpack = require('webpack');
//var clippyjs = require('./node_modules/clippy.js/build/clippy.min.js');
// http://disq.us/p/15x4f51
//require('css!./node_modules/clippy.js/build/clippy.css');
require('./node_modules/clippy.js/build/clippy.min.js');

module.exports = {
  context: __dirname + "/Scripts",
  entry: "./main.js",
  output: {
    path: __dirname + "/Scripts",
    filename: "bundle.min.js"
  },
  plugins: [
    new webpack.optimize.DedupePlugin(),
    new webpack.optimize.OccurenceOrderPlugin(),
    new webpack.optimize.UglifyJsPlugin({ mangle: false, sourcemap: false }),
  ]
};