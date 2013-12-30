


/*设置百度地图的Key值*/
//document.write("");

/*图标*/
var thinIcon = new BMap.Icon("../Source/BaiduMap/thinPoint.png", new BMap.Size(18, 20), { anchor: new BMap.Size(9, 20) });
var redIcon = new BMap.Icon("../Source/BaiduMap/redPoint.png", new BMap.Size(25, 30), { anchor: new BMap.Size(12.5, 30) });
var greenIcon = new BMap.Icon("../Source/BaiduMap/greenPoint.png", new BMap.Size(25, 30), { anchor: new BMap.Size(12.5, 30) });
var startIcon = new BMap.Icon("../Source/BaiduMap/startPoint.png", new BMap.Size(25, 30), { anchor: new BMap.Size(12.5, 30) });
var endIcon = new BMap.Icon("../Source/BaiduMap/endPoint.png", new BMap.Size(25, 30), { anchor: new BMap.Size(12.5, 30) });


/*地图实例*/
var map;

/*生成地址解析器*/
var gc = new BMap.Geocoder();

/*当前的标点*/
var currentMarker;

/*用于收缩的当前位置的...*/
var myLocalsearch;

/*扬州的地理位置*/
var _szLng = 119.439233;
var _szLat = 32.397139;

/*显示级别*/
var _showLevel = 15;

/*沧浪的范围*/
var _bounds;
var _clNELng = 120.653669;
var _clNELat = 31.288074;
var _clSWLng = 120.580938;
var _clSWLat = 31.301408;

function getBounds() {
    var ne = new BMap.Point(_clNELng, _clNELat);
    var sw = new BMap.Point(_clSWLng, _clSWLat);

    _bounds = new BMap.Bounds(sw, ne);
    return _bounds;
}


//初始化地图
//cantainer承载地图的DIV
function InitMap(container) {
    map = new BMap.Map(container);
    var centerPoint = new BMap.Point(_szLng, _szLat);
    map.centerAndZoom(centerPoint, _showLevel);
    map.addControl(new BMap.NavigationControl());  //添加默认缩放平移控件
    map.addControl(new BMap.ScaleControl({ anchor: BMAP_ANCHOR_BOTTOM_LEFT })); //向地图中添加比例尺控件
    map.enableScrollWheelZoom();    //启用滚轮放大缩小，默认禁用
    map.enableContinuousZoom();    //启用地图惯性拖拽，默认禁用
    //map.setMinZoom(15);
    //BMapLib.AreaRestriction.setBounds(map, getBounds()); //设定范围
}


//标注，弹出信息窗口
function AddSign(marker, infoWindow) {
    var infoWindow = new BMap.InfoWindow(infoWindow);
    map.addOverlay(marker);

    marker.addEventListener("click", function () {
        currentMarker = this;
        this.openInfoWindow(infoWindow);
    });
}
