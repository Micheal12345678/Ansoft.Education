
//巡逻点新增页面
function InfoWindowsForAddPoint(id, name, address, lng, lat) {
    var content = "<div id='PointWindow' class='PointWindow'>\
                    <div id='PointWindow_Form'>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>名称：</span>\
                        <input id='txtPointName' class='Form-Text' type='text'  value='" + name + "' />\
                    </div>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>经度：</span>\
                        <span class='Form-Label'>" + lng + "</span>\
                        <span class='Form-Label'>纬度：</span>\
                        <span class='Form-Label'>" + lat + "</span>\
                    </div>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>地址：</span>\
                        <input id='txtPointAddress' class='Form-Text' type='text' value='" + address + "'  />\
                    </div>\
                    <div id='DivTip' class='Form-Row Form-Row-Tip' style='display:none'>\
                        <span class='Form-Label'>提示：</span>\
                        <span id='Tip' class='Form-Label'>巡逻点名称或部门名称不能为空</span> \
                    </div>"; ;
    content += "<input id='hfLongitude' type='hidden' value='" + lng + "' />";
    content += "<input id='hfLatitude' type='hidden' value='" + lat + "' />";
    content += "<input id='hfPointId' type='hidden' value='" + id + "' />";
    content += "</div>\
                    <div id='PointWindow_Operation' class='Form-Operation'>";
    //可以在这禁用Delete，通过IsDeleteButton
    content += "<input id='btnDelete' type='button' class='Form-Button-Width Form-Button-Space-10' value='删除' onclick=' removePoint(this)'/>"; // return confirm('是否将此留言信息删除?'); 
    content += "<input id='btnAdd' type='button' class='Form-Button-Width Form-Button-Space-10' value='添加/修改' onclick='addPoint(this)' />\
                    </div>\
                </div>";
    return content;
}


//巡逻路线编辑页面
function InfoWindowsForShow(routePointId,Pointid, name, address, lng, lat, stayTime, sortIndex,IsEdit) {
    var content = "<div id='PointWindow' class='PointWindow-Show'>\
                    <div id='PointWindow_Form'>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>名称：</span>\
                        <span class='Form-Label'>" + name + "</span>\
                    </div>";
    content += "<div class='Form-Row'>\
                        <span class='Form-Label'>经纬度：</span>\
                        <span class='Form-Label'>" + lng + " " + lat + "</span>\
                    </div>";
    content += "<div  class='Form-Row'>\
                        <span class='Form-Label'>地址：</span>\
                        <span class='Form-Label'>" + address + "</span>\
                    </div>";
    content += "<div  class='Form-Row'>\
                        <span class='Form-Label'>驻留：</span>\
                        <input id='txtPointAddress' class='Form-Text' type='text' value='" + stayTime + "'  />\
                        <span class='Form-Label'>分钟</span>\
                    </div>";
    content += "<div  class='Form-Row'>\
                        <span class='Form-Label'>顺序：</span>\
                        <input id='txtPointAddress' class='Form-Text' type='text' value='" + sortIndex + "'  />\
                    </div>";
    content += "<input id='hfPointId' type='hidden' value='" + Pointid + "' />";
    content += "<input id='hfRoutePointId' type='hidden' value='" + routePointId + "' />";
    content += " <div id='DivTip' class='Form-Row Form-Row-Tip' style='display:none'>\
                        <span class='Form-Label'>提示：</span>\
                        <span id='Tip' class='Form-Label'>请将信息填写完整</span> \
                    </div>";
    content += "</div>\
                    <div id='PointWindow_Operation' class='Form-Operation'>";
    //可以在这禁用Edit，通过IsEdit
    if (IsEdit == true) {
        content += "<input id='btnDelete' type='button' class='Form-Button-Width Form-Button-Space-10' value='移除' onclick='removeRoutePoint(this)'/>"; // return confirm('是否将此留言信息删除?');
        content += "<input id='btnEdit' type='button' class='Form-Button-Width Form-Button-Space-10' value='修改' onclick='addRoutePoint(this)'/>";
    }
    else {
        content += "<input id='btnAdd' type='button' class='Form-Button-Width Form-Button-Space-10' value='指派' onclick='addRoutePoint(this)' />";
    }
     content += "  </div></div>";
    return content;
}


//附近的人
function InfoWindowsForPeopleNearby(name,useId,datetime,address) {
    var content = "<div id='PointWindow' class='PointWindow'>\
                 <div id='PointWindow_Form'>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>姓名：</span>\
                        <span class='Form-Label'>" + name + "</span>\
                    </div>";
    content += "<div class='Form-Row'>\
                        <span class='Form-Label'>更新时间：</span>\
                        <span class='Form-Label'>" + datetime + "</span>\
                    </div>";
    content += "<div  class='Form-Row'>\
                        <span class='Form-Label'>地址：</span>\
                        <span class='Form-Label'>" + address + "</span>\
                    </div>";
    content += "<input id='hfUserId' type='hidden' value='" + useId + "' />";
    content += "<input id='hfUserName' type='hidden' value='" + name + "' />";
    content += "</div>\
                    <div id='PointWindow_Operation' class='Form-Operation'>";
    content += "<input id='btnAdd' type='button' class='Form-Button-Width Form-Button-Space-10' value='指派' onclick='AsignPoint(this)' />";
    content += "  </div></div>";
    return content;
}


//附近的人
function InfoWindowsForPeopleAssign(name, datetime, address) {
    var content = "<div id='PointWindow' class='PointWindow'>\
                 <div id='PointWindow_Form'>\
                    <div  class='Form-Row'>\
                        <span class='Form-Label'>姓名：</span>\
                        <span class='Form-Label'>" + name + "</span>\
                    </div>";
    content += "<div class='Form-Row'>\
                        <span class='Form-Label'>更新时间：</span>\
                        <span class='Form-Label'>" + datetime + "</span>\
                    </div>";
    content += "<div  class='Form-Row'>\
                        <span class='Form-Label'>地址：</span>\
                        <span class='Form-Label'>" + address + "</span>\
                    </div>";
    content += "</div>";
    return content;
}



//Nothing but a test
function ReflectionTest() {
    $.ajax({
        type: "POST",
        url: "../Service/Service.ashx",
        data: { 'method': "Hello" },
        dataType: "json",

        success: function (data) {
            alert(data);
        }
        ,
        error: function (MLHttpRequest, textStatus, errorThrown) {
            alert("fail" + errorThrown);
        }
    });
}

