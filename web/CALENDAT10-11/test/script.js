$(document).ready(function(){
    $(document).on("click", '.prev', function(event) {
        var month =  $(this).data("prev-month");
        var year =  $(this).data("prev-year");
        getCalendar(month,year);
    });
    $(document).on("click", '.next', function(event) {
        var month =  $(this).data("next-month");
        var year =  $(this).data("next-year");
        getCalendar(month,year);
    });
    $(document).on("blur", '#currentYear', function(event) {
        var month =  $('#currentMonth').text();
        var year = $('#currentYear').text();
        getCalendar(month,year);
    });
    $(document).on("click", '.button', function(event) {
        var month =  $('#month').val();
        var year = $('#year').val();
        getCalendar(month,year);
    });
});
function getCalendar(month,year,holidays){
    $("#body-overlay").show();
    $.ajax({
        url: "calendar-ajax.php",
        type: "POST",
        data:'month='+month+'&year='+year,
        success: function(response){
            setInterval(function() {$("#body-overlay").hide(); },500);
            $("#calendar-html-output").html(response);
        },
        error: function(){}
    });

}