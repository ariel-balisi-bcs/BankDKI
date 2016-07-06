+function ($) {
    $(document).ready(function () {
        $(".btn-dki-login").on("click", function () {
            var $form = $("form");
            
            $.ajax({
                url: $($form).attr("action"),
                data: $($form).serialize(),
                type: "POST"
            }).success(function (result) {
                //success redirect
                window.location = result.RedirectUrl;
            }).error(function (msg) {
                //error encountered
            });
        });
    });
}(jQuery)