/*
	Makes all of the divs the same height.
*/

var projects = document.getElementsByClassName('project-wrapper');

// Get the height of the tallest div.
var max_height = -1;
for (var i = 0; i < projects.length; i++) {
	// http://stackoverflow.com/a/15615701/5415895
	max_height = Math.max(max_height, projects[i].clientHeight);
}

// Make all the divs the same height.
for (var i = 0; i < projects.length; i++) {
	var height = "height: " + max_height + "px";
	projects[i].setAttribute("style", height);
}