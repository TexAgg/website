var webpack = require('webpack');
var path = require('path');

module.exports = {
  context: __dirname + "/Scripts",
  entry: "./main.js",
  output: {
    path: __dirname + "/dist",
    filename: "bundle.min.js"
  },
  plugins: [
    new webpack.optimize.DedupePlugin(),
    new webpack.optimize.OccurenceOrderPlugin(),
    new webpack.optimize.UglifyJsPlugin({ mangle: false, sourcemap: false })
  ],
  module: {
    loaders: [{ 
        test: /\.css$/,                 
        //include: [path.resolve(__dirname, "not_exist_path")],
        loader: "style-loader!css-loader" 
      }
    ]
  }
};