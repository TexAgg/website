// Load Clippy.
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