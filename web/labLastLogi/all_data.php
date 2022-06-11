<?php
     require './helpers/db.php';

    $json_data =[];

 /*   $result = mysqli_query($connect, "SELECT * FROM `logfiledata` LIMIT 100");
    $ip = mysqli_query($connect, "SELECT * FROM `log_ip`");*/

$json_data=selectAllJoinTables('id_table','data_table');
echo json_encode($json_data);
?>