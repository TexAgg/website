/**
 * Makes a simple http Get request.
 * http://stackoverflow.com/a/4033310/5415895
 * 
 * @param {any} theUrl
 * @param {any} callback
 */
function httpGetAsync(theUrl, callback) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.onreadystatechange = function() { 
        if (xmlHttp.readyState == 4 && xmlHttp.status == 200)
            callback(xmlHttp.responseText);
    }
	// // true for asynchronous 
    xmlHttp.open("GET", theUrl, true);
    xmlHttp.send(null);
}

module.exports = {httpGetAsync: httpGetAsync};