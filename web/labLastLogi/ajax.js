$('#btn_load').click(function(){
    var pr=0;
    progress(pr);
});

function progress(val){
    var progressBar = $('#progressbar');
    var progValuee=$(".progress-value");
    if(val<100){
        $.ajax({
            url: "save.php",
            dataType: "json",
            data: null,
            type: "POST",
            success:function(data){  //функция обратного вызова, выполняется в случае успехной отработки скрипта
                let  obj= JSON.parse(data);
                console.dir(obj);
                progressBar.val(parseInt(obj));
                progValuee.text(`${parseInt(obj)} %`);
                if(obj>99){
                    console.log('fdsdff');
                    progress(100);
                }else{
                    progress(parseInt(obj));
                }
            },
        })
    }
}