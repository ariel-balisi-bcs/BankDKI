+function ($) {
    var clientListName = $(".clientList ul li");
    var clientNameDetails = $(".clientDetails h4")
    var clientSelected = $(".clientSelected ul");
    var btnClientSelect = $(".btnClientSelect");
    var clientSelection = "";


    clientListName.on("click", function () {
        clientSelection = $(this).text();
        clientNameDetails.text(clientSelection);
        $(this).toggleClass("selected");
        btnClientSelect.focus();
    });

    btnClientSelect.on("click", function () {
        var selectedClientName = $(".clientList ul li.selected");

        selectedClientName.each(function () {
            clientSelected.append("<li tabindex='0'>" + $(this).text() + "</li>");
            $(this).slideUp().removeClass("selected");
        })
    });

    $(".nav a").on("click", function myfunction() {
        clientListName.removeAttr("class");
        clientSelected.find("li").remove();
    });


}(jQuery);