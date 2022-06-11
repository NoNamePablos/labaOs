$('#btn_min').click(function(){
    var table = $("#mainTable");
    $.ajax({
            url: "data_min.php",
			dataType: "json",
			data: null,
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