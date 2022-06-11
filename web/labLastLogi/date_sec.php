<?php
require './helpers/db.php';
$json_data =[];
$sec=$_POST['sec'];
$json_data=selectAllJoinTablesSec('id_table','data_table',$sec);
echo json_encode($json_data);
?>