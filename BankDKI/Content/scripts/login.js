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
                if(result.Status=="Success")
                    window.location = result.RedirectUrl;
                else
                    $('.error-message').removeClass("hide");
            }).error(function (msg) {
                //error encountered
                $('.error-message').removeClass("hide");
            });
        });
    });
}(jQuery)