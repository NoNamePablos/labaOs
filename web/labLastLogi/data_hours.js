$('#btn_hours').click(function(){
    var table = $("#mainTable");
    var formData = {
        hours:$("#hours").val()
    };
    $.ajax({
        url: "data_hours.php",
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