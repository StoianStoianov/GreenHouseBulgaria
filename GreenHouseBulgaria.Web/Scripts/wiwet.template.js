/*

WIWET.com - ASP.NET Templates

TestWiwitIntegration Template

*/
$(document).ready(function () {
    var screenWidth = $(window).width();
    var screenHeight = $(window).height();
    var topBar = $(".top-bar").height();
    var navBar = $(".navbar").height();
    var footer = $("footer").height();
    $("[data-toggle=popover]").popover();
    $(".page-wrap").css("min-height", screenHeight - topBar - navBar - footer + "px");

    $(".portfolio-item,.team-desc").click(function () {
        $(".portfolio-item-hover,.team-desc-hover").css("opacity", "0");
        $(this).find(".portfolio-item-hover,.team-desc-hover").css("opacity", "1");
    });
    if (screenWidth < 768) {
        $(".wiwet-navigation").css("min-height", $(document).height() + "px");
    }

    //animations start
    $(".titleAnimation").addClass("animated shake");
    var waypoints = $('body').waypoint({
        handler: function (direction) {
            $(".fadeUpEffect,.fadeUpEffect1,.fadeUpEffect2,.fadeUpEffect3,.fadeRightEffect,.fadeLeftEffect,.fadeRightEffect1,.fadeLeftEffect1").addClass("hiddenFromView");
        }
    });

    var waypoints = $('.fadeUpEffect').waypoint({
        handler: function (direction) {
            $(".fadeUpEffect").addClass("animated fadeInUp");
        }, offset: '80%'
    });
    var waypoints = $('.fadeUpEffect1').waypoint({
        handler: function (direction) {
            $(".fadeUpEffect1").addClass("animated fadeInUp");
        }, offset: '80%'
    });
    var waypoints = $('.fadeUpEffect2').waypoint({
        handler: function (direction) {
            $(".fadeUpEffect2").addClass("animated fadeInUp");
        }, offset: '80%'
    });
    var waypoints = $('.fadeUpEffect3').waypoint({
        handler: function (direction) {
            $(".fadeUpEffect3").addClass("animated fadeInUp");
        }, offset: '80%'
    });

    var waypoints = $('.fadeLeftRight').waypoint({
        handler: function (direction) {
            $(".fadeLeftEffect").addClass("animated fadeInLeftBig");
            $(".fadeRightEffect").addClass("animated fadeInRightBig");
        }, offset: '60%'
    });

    var waypoints = $('.fadeLeftRight1').waypoint({
        handler: function (direction) {
            $(".fadeLeftEffect1").addClass("animated fadeInLeftBig");
            $(".fadeRightEffect1").addClass("animated fadeInRightBig");
        }, offset: '60%'
    });

    var waypoints = $('.countNumbers').waypoint({
        handler: function (direction) {
            $('.count-shares').countTo({ from: 0, to: 3456, speed: 3000, refreshInterval: 100 });
            $('.count-sales').countTo({ from: 0, to: 1569, speed: 3000, refreshInterval: 100 });
            $('.count-likes').countTo({ from: 0, to: 4536, speed: 3000, refreshInterval: 100 });
            $('.count-member').countTo({ from: 0, to: 2698, speed: 3000, refreshInterval: 100 });

            $('.count-standard').countTo({ from: 0, to: 98, speed: 3000, refreshInterval: 100 });
            $('.count-integration').countTo({ from: 0, to: 32, speed: 3000, refreshInterval: 100 });
            $('.count-requirements').countTo({ from: 0, to: 13, speed: 3000, refreshInterval: 100 });
        }, offset: '60%'
    });

    var waypoints = $('.animateBars').waypoint({
        handler: function (direction) {
            var bar = $('.progress-bar');
            $(function () {
                $(bar).each(function () {
                    bar_width = $(this).attr('aria-valuenow');
                    $(this).width(bar_width + '%');
                });
            });
        }, offset: '60%'
    });

    $('.textarea-scrollbar').scrollbar();

    if (screenWidth < 768) {
        $(".fadeUpEffect,.fadeUpEffect1,.fadeUpEffect2,.fadeUpEffect3,.fadeRightEffect,.fadeLeftEffect,.fadeRightEffect1,.fadeLeftEffect1").removeClass("hiddenFromView");
    }
    //animations end

    var oneSpace = "&nbsp;";
    var blankSpace = "Scrolling&nbsp;Textarea";
    for (var i = 1; i < 5000; i++) {
        blankSpace += oneSpace;
    };
    $("#scrolling-textarea").html(blankSpace);
});//end document ready

//Select the navigation menu base on URL.
$(function () {
    var path = window.location.pathname;
    path = path.replace(/\/$/, "");
    path = decodeURIComponent(path);
    if (path == '') {
        path = "/";
    }
    $(".wiwet-navigation a").each(function () {
        if ($(this).attr('href') == path) {
            $(this).parent().addClass("active");
        }
    });
});