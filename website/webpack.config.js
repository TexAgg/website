var webpack = require('webpack');
// http://www.frontendjunkie.com/2016/04/using-webpack-to-copy-static-images-to.html
var CopyWebpackPlugin = require('copy-webpack-plugin')

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