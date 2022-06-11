<?php
require './helpers/db.php';
$json_data =[];
$minutes=$_POST['minutes'];
$json_data=selectAllJoinTablesMinutes('id_table','data_table',$minutes);
echo json_encode($json_data);
?>