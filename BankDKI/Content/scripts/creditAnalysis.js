+function ($) {
    var btnViewCreditHistory = $('#viewCreditReport');
    var status = "approve"

    $(document).ready(function () {       
        btnViewCreditHistory.on('click', function (e) {
            e.preventDefault();
            var creditAnalysisReport = $('#creditAnalysisReport');
            creditAnalysisReport.removeClass('hide');
            scrollTop(creditAnalysisReport);
        });

        var btnYes = $("#modalApprove,#modalDeny").find(".btnYes");

        $(btnYes).each(function () {
            $(this).on('click', function () {
                if ($(this).parents("#modalApprove").length > 0) {
                    status = "Approve";
                    $('#modalExport').find(".modal-header").css("background", "#2BAF73");
                    $('#modalExport').find(".modal-title").text("Loan Approved");
                }
                else if ($(this).parents("#modalDeny").length > 0) {
                    status = "Deny";
                    $('#btnExport').css("background", "#DA2126");
                    $('#modalExport').find(".modal-header").css("background", "#DA2126");
                    $('#modalExport').find(".modal-title").text("Loan Denied");
                }

                $('#btnApprove').addClass("hide");
                $('#btnDeny').addClass("hide");
                $('#btnExport').removeClass("hide");
            });
        });

        var btnEdit = $(".btnEdit");
        $(btnEdit).each(function () {
            $(this).on('click', function (e) {
                e.preventDefault();
                var textArea = $(this).parent().parent().find("textarea");
                textArea.css("border", "1px solid #b7b7b7");
                textArea.removeAttr("readonly");
                textArea.focus();
                $(this).parent().find(".btnSave").removeClass("hide");
                $(this).addClass("hide");
            });
        });

        var btnSave = $(".btnSave");
        $(btnSave).each(function () {
            $(this).on('click', function (e) {
                e.preventDefault();
                var textArea = $(this).parent().parent().find("textarea");
                if(!$(textArea).is("#Comments"))
                    textArea.css("border", "none");
                textArea.attr("readonly","readonly");
                $(this).parent().find(".btnEdit").removeClass("hide");
                $(this).addClass("hide");
                var $form = $("form");
                var url = $form.attr("action");
                $.ajax({
                    data: $($form).serialize(),
                    type: "POST",
                    url: url
                }).success(function (result) {
                    //done//success                    
                }).error(function (msg) {
                    //error encounteerd
                });
                return;
            });
        });

        btnViewCreditHistory.tooltip();
    });

    function scrollTop(element)
    {
        $('html, body').animate({
            scrollTop: ($(element).offset().top)
        }, 500);
    }
}(jQuery)
