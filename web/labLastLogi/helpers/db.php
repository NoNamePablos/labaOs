<?php
require('connection.php');


function showArr($value){
    echo '<pre>';
    print_r($value);
    echo '</pre>';
}


//БД чекер на ошибку

function dbCheckError($query){
    $errInfo=$query->errorInfo();
    if($errInfo[0]!=PDO::ERR_NONE){
        echo $errInfo[2];
        exit();
    }
    return true;
}
//Получить все данные из таблицы
function selectAll($table,$params=[]){
    global $pdo;
    $sql="SELECT * From $table";
    if(!empty($params)){
        $i=0;
        foreach ($params as $key=>$value){
            if(!is_numeric($value)){
                $value="'".$value."'";
            }
            if($i===0){
                $sql=$sql . " WHERE $key=$value";
            }else{
                $sql=$sql . " AND $key=$value";
            }
            $i++;
        }
    }

    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}

//Выборка 1 записи

function selectOne($table,$params=[]){
    global $pdo;
    $sql="SELECT * From `$table`";
    if(!empty($params)){
        $i=0;
        foreach ($params as $key=>$value){
            if(!is_numeric($value)){
                $value="'".$value."'";
            }
            if($i===0){
                $sql=$sql . " WHERE $key=$value";
            }else{
                $sql=$sql . " AND $key=$value";
            }
            $i++;
        }
    }
    $sql=$sql." LIMIT 1";
    $query=$pdo->prepare($sql);
    $query->execute();

    dbCheckError($query);
    return $query->fetch();
}

function insert($table,$params=[]){
    /*
 * INSERT INTO `users` (`id`, `admin`, `username`, `password`, `email`, `created`, `age`) VALUES (NULL, '0', 'test', 'test', 'test@mail.ru', CURRENT_TIMESTAMP, '17');
 * */
    global  $pdo;
    $i=0;
    $coll='';
    $mask='';

    foreach ($params as $key =>$value){
        if($i===0){
            $coll=$coll ."$key";
            $mask=$mask."'"."$value"."'";
        }else{
            $coll=$coll .", $key";
            $mask=$mask.", '"."$value"."'";
        }

        $i++;
    }

    $sql="INSERT INTO $table ($coll) VALUES($mask)";
    $query=$pdo->prepare($sql);
    $query->execute($params);
    dbCheckError($query);
    return  $pdo->lastInsertId();
}

function selectAllJoinTables($table1,$table2){
    global $pdo;
    $sql="SELECT
       t1.id_ip,
       t2.date,
       t2.path,
       t2.status
       FROM $table1 AS t1 JOIN $table2 AS t2 ON t1.id=t2.id_ip";
    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}

function selectAllJoinTablesHours($table1,$table2,$hours){
    global $pdo;
    $sql="SELECT
       t1.id_ip,
       t2.date,
       t2.path,
       t2.status
       FROM $table1 AS t1 JOIN $table2 AS t2 ON t1.id=t2.id_ip WHERE HOUR(date) = $hours";
    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}
function selectAllJoinTablesMinutes($table1,$table2,$minutes){
    global $pdo;
    $sql="SELECT
       t1.id_ip,
       t2.date,
       t2.path,
       t2.status
       FROM $table1 AS t1 JOIN $table2 AS t2 ON t1.id=t2.id_ip WHERE MINUTE (date) = $minutes";
    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}
function selectAllJoinTablesSec($table1,$table2,$sec){
    global $pdo;
    $sql="SELECT
       t1.id_ip,
       t2.date,
       t2.path,
       t2.status
       FROM $table1 AS t1 JOIN $table2 AS t2 ON t1.id=t2.id_ip WHERE SECOND (date) = $sec";
    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}
function selectAllJoinTablesAllTime($table1,$table2,$hours,$minutes,$sec){
    global $pdo;
    $sql="SELECT
       t1.id_ip,
       t2.date,
       t2.path,
       t2.status
       FROM $table1 AS t1 JOIN $table2 AS t2 ON t1.id=t2.id_ip WHERE SECOND (date) = $sec AND MINUTE (date)=$minutes AND HOUR (date)=$hours";
    $query=$pdo->prepare($sql);
    $query->execute();
    dbCheckError($query);
    return $query->fetchAll();
}
function get_last_id(){
    global  $pdo;
    return  $pdo->lastInsertId();
}