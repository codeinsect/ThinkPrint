﻿$(function () {
    $('#nav-accordion').metisMenu();
    $(window).bind("load resize", function () {
        if ($(this).width() < 768) {
            $('div.sidebar-collapse').addClass('collapse');
        } else {
            $('div.sidebar-collapse').removeClass('collapse')
        }
    });
});






