/**
 * A script for handling the bootstrap switch on the resume page.
 */

// Import css.
require("../node_modules/bootstrap-switch/dist/css/bootstrap3/bootstrap-switch.min.css");
require('bootstrap-switch');

$("[name='my-checkbox']").bootstrapSwitch();
// http://www.bootstrap-switch.org/events.html
$('input[name="my-checkbox"]').on('switchChange.bootstrapSwitch', function(event, state) {

	var img = document.getElementById("image");
	var pdf_link = document.getElementById('pdf_link');

	if (state) {
		img.src = "~/Content/Resume/resume.png";
		
		// Changes the download link.
		pdf_link.href = "~/Content/Resume/resume.pdf";
		pdf_link.download = 'MattGaikemaResume';
	}
	else {
		img.src = "~/Content/Resume/cv.png";

		pdf_link.href = "~/Content/Resume/cv.pdf";
		pdf_link.download = 'MattGaikemaCV';
	}
});