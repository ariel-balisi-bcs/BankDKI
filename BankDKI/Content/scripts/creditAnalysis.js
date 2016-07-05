+function ($) {
    var btnViewCreditHistory = $('#viewCreditReport');
    $(document).ready(function () {       
        btnViewCreditHistory.on('click', function () {
            $('#creditAnalysisReport').removeClass('hide');
        });
        btnViewCreditHistory.tooltip();
    });    
}(jQuery)
