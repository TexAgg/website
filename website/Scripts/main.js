/*
	Bundle clippy.css and clippy.min.js with this.
	If webpack complains about an unexpected token in the css,
	delete 'node_modules' and reinstall using npm (NOT yarn): https://github.com/webpack/css-loader/issues/37

	Also, if webpack complains that it can't find clippy.min.js, 
	then re-download it from here: https://raw.githubusercontent.com/TexAgg/clippy.js/master/build/clippy.min.js
*/

require("../node_modules/clippy.js/build/clippy.css");
// Load this globally.
// https://medium.com/@dtothefp/why-can-t-anyone-write-a-simple-webpack-tutorial-d0b075db35ed#.uk6oyw973
require("script!../node_modules/clippy.js/build/clippy.min.js");
var utils = require('./modules/utils');

//utils.httpGetAsync("http://stackoverflow.com/questions/247483/http-get-request-in-javascript", console.log);

clippy.load('Clippy', function(agent) {
	agent.show();
	if (window.location.pathname == "/Resume") {
		agent.speak("Scroll down to download a PDF copy.");
	}
	else
		agent.speak("Hello! Welcome to the website of Matt Gaikema!");
});