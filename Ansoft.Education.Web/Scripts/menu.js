$(document).ready(function () {
    $('#menulist').find('.meun-type').click(function () {
        $(this).next().slideToggle(50);
    }); //.next().hide();

    //改变菜单的颜色
    fetechMenuItems();
});

function fetechMenuItems()
{
    var currentAction = $("#action").val().toUpperCase();
    var menuList = $("#menulist").find('.menu-ul-a');

    for (var i = 0; i < menuList.length; i++) {
        if (menuList[i].text.toUpperCase() == currentAction) {
            menuList[i].style.color = "red";
        }
        else {
            menuList[i].style.color = "black";
        }
    }
}