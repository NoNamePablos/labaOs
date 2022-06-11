<?php
require './helpers/db.php';
$json_data =[];
$sec=$_POST['sec'];
$hours=$_POST['hours'];
$minutes=$_POST['minutes'];
$json_data=selectAllJoinTablesAllTime('id_table','data_table',$hours,$minutes,$sec);
echo json_encode($json_data);
?>