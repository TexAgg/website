$("[name='my-checkbox']").bootstrapSwitch();
// http://www.bootstrap-switch.org/events.html
$('input[name="my-checkbox"]').on('switchChange.bootstrapSwitch', function(event, state) {
  console.log(state); // true | false
	var img = document.getElementById("image");
	if (state) {
		img.src = "~/Content/Resume/resume.png";
	}
	else {
		img.src = "~/Content/Resume/cv.png";
	}
});

// http://stackoverflow.com/a/8784019/5415895
function changeImage() {
	var img = document.getElementById("image");
}