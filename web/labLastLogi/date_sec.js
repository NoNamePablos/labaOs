$('#btn_sec').click(function(){
    var table = $("#mainTable");
    var formData = {
        sec:$("#sec").val()
    };
    $.ajax({
        url: "date_sec.php",
        dataType: "json",
        data:formData,
        type: "POST",
        success: function(data){
            console.log(data);
            //очистим весю стр
            table.find("tr:gt(0)").remove();
            //добавим все строки
            for(let i=0; i<data.length;i++){
                $("#mainTable tr:last").after(`
              <tr>
            <th scope="row">${data[i].id_ip}</th>
            <td>${data[i].date}</td>
            <td>${data[i].path}</td>
            <td>${data[i].status}</td>
                </tr>
            `);
            }
        }
    })
})