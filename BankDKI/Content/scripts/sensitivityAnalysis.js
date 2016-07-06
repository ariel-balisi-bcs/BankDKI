+function ($) {

    /*DATA ARRAY ARE FOR DEMO PURPOSES*/

    /*Price*/
    var tableheader1 = new Array('800', '850', '900', '950', '1,000', '1,050', '1,100', '1,150', '1,200');
    /*Volume*/
    var tableheader2 = new Array('420', '440', '460', '480', '500', '520', '540', '560', '580');

    /*Price - 2018*/
    var roe1 = new Array('21.46%', '17.29%', '18.37%', '19.43%', '20.46%', '21.46%', '22.44%', '23.40%', '24.33%', '25.24%');
    var netprofit1 = new Array('104,509', '79,909', '86,059', '92,209', '98,359', '104,509', '110,659', '116,809', '122,959', '129,109');
    var netprofitmar1 = new Array('20.90%', '19.98%', '20.25%', '20.49%', '20.71%', '20.90%', '21.08%', '21.24%', '21.38%', '21.52%');
    var ebitda1 = new Array('104,900', '74,900', '82,400', '89,900', '97,400', '104,900', '112,400', '119,900', '127,400', '134,900');
    var ebitdafin1 = new Array('3.81', '2.72', '2.99', '3.26', '3.54', '3.81', '4.08', '4.35', '4.62', '4.9');

    /*Volume - 2018*/
    var roe2 = new Array('21.46%', '7.98%', '8.52%', '9.06%', '9.59%', '10.11%', '10.63%', '11.14%', '11.64%', '12.14%');
    var netprofit2 = new Array('104,509', '33,169', '35,629', '38,089', '40,549', '43,009', '45,469', '47,929', '50,389', '52,849');
    var netprofitmar2 = new Array('20.90%', '15.79%', '16.20%', '16.56%', '16.90%', '17.20%', '17.49%', '17.75%', '18.00%', '18.22%');
    var ebitda2 = new Array('104,900', '17,900', '20,900', '23,900', '26,900', '29,900', '32,900', '35,900', '38,900', '41,900');
    var ebitdafin2 = new Array('3.56', '3.56', '3.56', '3.56', '3.56', '3.56', '3.56', '3.56', '3.56', '3.56');

    /*Volume - 2019*/
    var roe3 = new Array('17.81%', '20.25%', '20.16%', '20.06%', '19.97%', '19.88%', '19.79%', '19.70%', '19.61%', '19.52%');
    var netprofit3 = new Array('105,534', '105,534', '105,534', '105,534', '105,534', '105,534', '105,534', '105,534', '105,534', '105,534');
    var netprofitmar3 = new Array('21.11%', '21.11%', '21.11%', '21.11%', '21.11%', '21.11%', '21.11%', '21.11%', '21.11%', '21.11%');
    var ebitda3 = new Array('107,400', '107,400', '107,400', '107,400', '107,400', '107,400', '107,400', '107,400', '107,400', '107,400');
    var ebitdafin3 = new Array('4.08', '4.08', '4.08', '4.08', '4.08', '4.08', '4.08', '4.08', '4.08', '4.08');



    var btnZoomToFit = $('#zoomtofit');
    var btnClearTable = $('#cleartable');
    var ddVariable = $('#select-variable');
    var ddDate = $('#select-date');

    $(document).ready(function () {
        btnZoomToFit.on('click', function () {
            $('#analysis-table').css('width', '79%');
            $('#search-sidebar').toggle("slide", function () {
                if ($(this).is(':visible')) {
                    $('#analysis-table').css('width', '79%');
                } else {
                    $('#analysis-table').css('width', '100%');
                }
            });
        });

        btnClearTable.on('click', function () {
            $('#variable-row').html('');
            $('.table > div').html('');
            $('#date-row').html('');
        });

        ddVariable.on('change', function () {
            $('#variable-row').html(ddVariable.val());
            $('.table > div').html('');
            $('#date-row').html(ddDate.val());

            if ($(this).val() == 'Price') {
                $('.table > div:first-child').html('<div></div><div></div>');
                for (var c = 0; c < tableheader1.length; c++) $('.table > div:first-child').append('<div>' + tableheader1[c] + '</div>');

                $('.table > div:nth-child(2)').html('<div>ROE</div>');
                for (var c = 0; c < roe1.length; c++) $('.table > div:nth-child(2)').append('<div>' + roe1[c] + '</div>');
                $('.table > div:nth-child(3)').html('<div>Net Profit</div>');
                for (var c = 0; c < netprofit1.length; c++) $('.table > div:nth-child(3)').append('<div>' + netprofit1[c] + '</div>');
                $('.table > div:nth-child(4)').html('<div>Net Profit Margin</div>');
                for (var c = 0; c < netprofitmar1.length; c++) $('.table > div:nth-child(4)').append('<div>' + netprofitmar1[c] + '</div>');
                $('.table > div:nth-child(5)').html('<div>EBITDA</div>');
                for (var c = 0; c < ebitda1.length; c++) $('.table > div:nth-child(5)').append('<div>' + ebitda1[c] + '</div>');
                $('.table > div:nth-child(6)').html('<div>EBITDA/Fin Pmt</div>');
                for (var c = 0; c < ebitdafin1.length; c++) $('.table > div:nth-child(6)').append('<div>' + ebitdafin1[c] + '</div>');

            } else if ($(this).val() == 'Volume') {
                $('.table > div:first-child').html('<div></div><div></div>');
                for (var c = 0; c < tableheader2.length; c++) $('.table > div:first-child').append('<div>' + tableheader2[c] + '</div>');

                $('.table > div:nth-child(2)').html('<div>ROE</div>');
                for (var c = 0; c < roe2.length; c++) $('.table > div:nth-child(2)').append('<div>' + roe2[c] + '</div>');
                $('.table > div:nth-child(3)').html('<div>Net Profit</div>');
                for (var c = 0; c < netprofit2.length; c++) $('.table > div:nth-child(3)').append('<div>' + netprofit2[c] + '</div>');
                $('.table > div:nth-child(4)').html('<div>Net Profit Margin</div>');
                for (var c = 0; c < netprofitmar2.length; c++) $('.table > div:nth-child(4)').append('<div>' + netprofitmar2[c] + '</div>');
                $('.table > div:nth-child(5)').html('<div>EBITDA</div>');
                for (var c = 0; c < ebitda2.length; c++) $('.table > div:nth-child(5)').append('<div>' + ebitda2[c] + '</div>');
                $('.table > div:nth-child(6)').html('<div>EBITDA/Fin Pmt</div>');
                for (var c = 0; c < ebitdafin2.length; c++) $('.table > div:nth-child(6)').append('<div>' + ebitdafin2[c] + '</div>');
            }
        });
    });
}(jQuery)