<?php
require './helpers/db.php';
$json_data =[];
$json_data=selectAllJoinTables('id_table','data_table');
    array_multisort($json_data, SORT_DESC);
    echo json_encode($json_data);
?>