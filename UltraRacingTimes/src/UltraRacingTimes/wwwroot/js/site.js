// site.js
(function () {
    //var $ele = $("#username");
    //$ele.text("Een Schatje");

    //var $main = $("#main");
    //$main.on("mouseenter", function () {
    //    main.style = "background-color: #888;";
    //});
    //$main.on("mouseleave", function () {
    //    main.style = "";
    //});

    //$menuItems = $("ul.menu li a");
    //$menuItems.on("click", function () {
    //    alert("hello");
    //});

    var $sidebarAndWrapper = $("#wrapper, #sidebar");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
        
    });
})();