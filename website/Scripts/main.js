/*
	Bundle clippy.css and clippy.min.js with this.
	If webpack complains about an unexpected token in the css,
	delete 'node_modules' and reinstall using npm (NOT yarn): https://github.com/webpack/css-loader/issues/37

	Also, if webpack complains that it can't find clippy.min.js, 
	then re-download it from here: https://raw.githubusercontent.com/TexAgg/clippy.js/master/build/clippy.min.js
*/

require("../node_modules/clippy.js/build/clippy.css");
// https://medium.com/@dtothefp/why-can-t-anyone-write-a-simple-webpack-tutorial-d0b075db35ed#.uk6oyw973
require("script!../node_modules/clippy.js/build/clippy.min.js");

clippy.load('Clippy', function(agent) {
	agent.show();
	agent.speak("Hello! Welcome to the website of Matt Gaikema!");

	/*
		Uncomment to add mousenter events to navbar.
	*/
	/*
	document.getElementById('index-nav-li').onmouseenter = function() {
		agent.stop();
		agent.speak("Click here to read about me!");
	}

	document.getElementById('projects-nav-li').onmouseenter = function() {
		agent.stop();
		agent.speak("Click here to see some projects I have worked on!");
	}

	document.getElementById('skills-nav-li').onmouseenter = function() {
		agent.stop();
		agent.speak("Click here to see my skills!");
	}

	document.getElementById('resume-nav-li').onmouseenter = function() {
		agent.stop();
		agent.speak("Click here to see my resume!");
	}

	document.getElementById('contact-nav-li').onmouseenter = function() {
		agent.stop();
		agent.speak('Click here to see my contact information!');
	}
	*/

});