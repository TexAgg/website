/*
	Handles the project modals.
*/

var projects = document.getElementsByClassName('project-wrapper');

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

	// idk this makes it look better.
	$(p2).removeAttr('id');
	$(p2).removeAttr('class');
	p2.setAttribute('style', 'padding: 10px;')
	// Reset class.
	var imgs = p2.getElementsByTagName('img');
	for (var i = 0; i < imgs.length; i++) {
		imgs[i].className = "proj-modal";
	}

	innerModal.innerHTML = p2.outerHTML;
	window.location.hash = outerModal.id;
}

// Add modal toggle to each project.
for (var i = 0; i < projects.length; i++) {
	var p = projects[i];
	p.onclick = function(){
		showModal(this);
		$(outerModal).modal("toggle");
	}
}

// Remove hash on modal close. 
$(outerModal).on('hidden.bs.modal', function (e) {
	// http://stackoverflow.com/a/9643338/5415895
	history.pushState("", document.title, window.location.pathname);
})

// Hide modal on smaller screens.
// http://stackoverflow.com/a/29584202/5415895
$(outerModal).on('shown.bs.modal', function() {
    var width = $(window).width();  
    if(width < 480){
		$(this).hide(); 
    }
});

// Show modal if its id is in the url.
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