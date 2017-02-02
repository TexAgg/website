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

/**
 * http://stackoverflow.com/a/9252908/5415895
 */
function removeStyles(el) {
    el.removeAttribute('style');
    //el.removeAttribute('class');

    if(el.childNodes.length > 0) {
        for(var child in el.childNodes) {
            /* filter element nodes only */
            if(el.childNodes[child].nodeType == 1)
                removeStyles(el.childNodes[child]);
        }
    }
}

module.exports = {
    httpGetAsync: httpGetAsync,
    removeStyles: removeStyles
};