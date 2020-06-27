$(document).ready(function () {
    $.get("api/operations").done(data => {
        data.map(item => {
            $('#firstoperation').append(new Option(item.value, item.key));
        })
    });


    $('#btnCalcResult').click(function () {
        $('#error').text('');
        let FirstOperand = $('#firstargument').val();
        let FirstOperation = +$('#firstoperation').val();
        let SecondOperand = $('#secondargument').val();


        $.ajax({
            url: `api/calculator/twoargumentresult?operand1=${FirstOperand}&operation=${FirstOperation}&operand2=${SecondOperand}`,
            method: 'get',
            dataType: 'json',
            contentType: 'application/json',
            success: function (result) {
                if (result.hasError) {
                    $('#error').text(result.errorMessage);
                } else {
                    $('#result').val(result.data);
                }
            }
        });
    });
});
