+function($) {
    var nav = $("nav");
    var viewBag = nav.attr("class");
    var activeMenu = nav.find("li." + viewBag);

    activeMenu.addClass("active");
    activeMenu.find("a").removeAttr("href");

}(jQuery);