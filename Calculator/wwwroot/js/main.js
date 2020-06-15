$(document).ready(function () {
    $.get("/calculator/operationtypes").done(data => {
        data.map(item => {
            $('#firstoperation').append(new Option(item.Value, item.Key));
        })
    });


    $('#btnCalcResult').click(function () {
        let operators = {
            FirstArgument: +$('#firstargument').val(),
            FirstOperation: +$('#firstoperation').val(),
            SecondArgument: +$('#secondargument').val()
        };

        $.ajax({
            url: '/calculator/calculateresult',
            method: 'POST',
            dataType: 'json',
            data: JSON.stringify(operators),
            contentType: 'application/json',
            success: function (result) {
                $('#result').val(result.result);
            }
        });
    });
});
