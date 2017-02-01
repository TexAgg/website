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

for (var i = 0; i < projects.length; i++) {
	var p = projects[i];

	// Create modal container
	var outerModal = document.createElement('div');
	outerModal.id = p.id + "-modal";
	outerModal.className += " modal fade";	
	outerModal.setAttribute("role", "dialog");
	outerModal.setAttribute('tabindex', '-1');

	var innerModal = document.createElement('div');
	innerModal.className += " modal-dialog";

	// http://stackoverflow.com/q/41987506/5415895
	var p2 = p.cloneNode(true);
	//innerModal.appendChild(p2);
	//console.log(p2);
	outerModal.appendChild(innerModal);
	document.body.appendChild(outerModal);

	p.onclick = function(){$(outerModal).modal("show");};
}

// https://gist.github.com/MrDys/3512455
$(document).ready(function() {
	var modals = document.getElementsByClassName('modal');
	for (var i = 0; i < modals.length; i++) {
		if(window.location.href.indexOf('#' + modals[i].id) != -1) {
			$('#' + modals[i].id).modal('show');
		}
	}
});