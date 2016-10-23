var webpack = require('webpack');
var clippyjs = require('./node_modules/clippy.js/build/clippy.min.js');
//var clippycss = require('/node_modules/clippy.js/build/clippy.css');

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
  ],
   module: {
		loaders: [
			{ test: /\.css$/, loader: 'style-loader!css-loader' },
			{ test: /\.(png|jpg)$/, loader: 'url-loader?limit=8192' } // inline base64 URLs for <=8k images, direct URLs for the rest
		]
	}
};