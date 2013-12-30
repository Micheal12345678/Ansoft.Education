var x = document.getElementById("coordinate");
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, showError);
        /*
        watchPosition是持续更新您的地理位置
        navigator.geolocation.watchPosition(showPosition, showError);
        */
    }
    else { x.innerHTML = "Geolocation is not supported by this browser."; }
}
function showPosition(position) {
    x.innerHTML = position.coords.latitude + " &nbsp " + position.coords.longitude;
}


function showError(error) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            x.innerHTML = "User denied the request for Geolocation."
            break;
        case error.POSITION_UNAVAILABLE:
            x.innerHTML = "Location information is unavailable."
            break;
        case error.TIMEOUT:
            x.innerHTML = "The request to get user location timed out."
            break;
        case error.UNKNOWN_ERROR:
            x.innerHTML = "An unknown error occurred."
            break;
    }
}