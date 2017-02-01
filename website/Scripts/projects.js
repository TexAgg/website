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

var outerModal = document.createElement('div');
outerModal.className += " modal fade";	
outerModal.setAttribute("role", "dialog");
outerModal.setAttribute('tabindex', '-1');

var midModal = document.createElement('div');
midModal.className += " modal-dialog";
midModal.setAttribute('role', 'document');

var innerModal = document.createElement('div');
innerModal.className += ' modal-content';
midModal.appendChild(innerModal);
outerModal.appendChild(midModal);
document.body.appendChild(outerModal);

function showModal(elem) {
	outerModal.id = elem.id + '-modal';
	var p2 = elem.cloneNode(true);
	p2.className = '';
	innerModal.innerHTML = p2.outerHTML;
}

for (var i = 0; i < projects.length; i++) {
	var p = projects[i];
	p.onclick = function(){
		showModal(this);
		$(outerModal).modal("toggle");
	}
}

// https://gist.github.com/MrDys/3512455
$(document).ready(function() {
	var id = window.location.hash;
	if (id) {
		var regi = /(\w+)-modal/;
		match = regi.exec(id);
		if (match.length > 1) {
			showModal(document.getElementById(match[1]));
			$(outerModal).modal('show');
	}
	}
});