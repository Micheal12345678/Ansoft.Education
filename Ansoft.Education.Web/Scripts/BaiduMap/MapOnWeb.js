$(document).ready(function () {
    //初始化地图
    InitMap("mapContainer");

    //加载一个覆盖点
    addMarker();
})

function addMarker() {
    var infoWindows = "<p>Hello</p>";

    var p = new BMap.Point(_szLng, _szLat);
    var marker = new BMap.Marker(p);

    AddSign(marker, infoWindows);
}