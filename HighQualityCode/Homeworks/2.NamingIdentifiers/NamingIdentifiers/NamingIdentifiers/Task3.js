function CheckBrowser(eventName, InputArguments) {
	var myBrowsersWindow = window;
	var browserName = myBrowsersWindow.navigator.appCodeName;
	var isMozilla = browserName === "Mozilla";

	if (isMozilla) {
		alert("Yes");
	} else {
		alert("No");
	}
}