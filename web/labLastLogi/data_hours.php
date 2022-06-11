<?php
require './helpers/db.php';
$json_data =[];
$hours=$_POST['hours'];
$json_data=selectAllJoinTablesHours('id_table','data_table',$hours);
echo json_encode($json_data);
?>