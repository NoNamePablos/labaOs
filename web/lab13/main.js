$(function() {
    $(document).ready(function(){
        var bar = $('#bar')
        var percent = $('#percent');
        var status = $('#status');

        $('form').ajaxForm({
            beforeSend: function() {
                status.empty();
                var percentVal = '0%';
                bar.width(percentVal);
                percent.html(percentVal);
            },
            uploadProgress: function(event, position, total, percentComplete) {
                var percentVal = percentComplete + '%';
                percent.html(percentVal);
                bar.width(percentVal);
            },
            complete: function(xhr) {
                status.html(xhr.responseText);
            }
        });
    });
});