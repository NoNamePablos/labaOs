<?php
require './helpers/db.php';
set_time_limit(0);
$file = fopen("log500k.log", "r");
$values = array();
session_start();
function get_str($string, & $values, $pr)
{
    $result = array();
    $pattern = "/(\S+) (\S+) (\S+) \[([^:]+):(\d+:\d+:\d+) ([^\]]+)\] \"(\S+) (.*?) (\S+)\" (\S+) (\S+) (\".*?\") (\".*?\")/";
    preg_match($pattern, $string, $result);
    $items = array();
    $items["ip"] = $result[1];
    $new_time = $result[4] . ":" . $result[5] . " " . $result[6];
    $items["time"] = new DateTime($new_time);
    $result[8] = str_replace(',','?', $result[8]);
    $f = str_replace('?',' ', $result[8]);
    $k = strpos($f, ' ');
    $r = mb_substr($f, 0 , $k);
    if(empty($r) === TRUE )
    {
        $items["path"] = addslashes($result[8]);
    }
    else
    {
        $items["path"] = addslashes($r);
    }

    $items["status"] = $result[10];
    $values[] = $items;
}

if ($file)
{
    if (!isset($_SESSION["file_str"]))
    {
        $_SESSION["file_str"] = 0;
        $_SESSION["pr"] = 0;
    }
    $file_str = $_SESSION["file_str"];
    $pr = $_SESSION["pr"];
fseek($file, $file_str);
for ($i = 0; $i < 100; $i++)
{
   if(!feof($file))
    {
            $pr = $pr + 1;
            $string = fgets($file);
            get_str($string, $values, $pr);

    }
}
    $_SESSION["pr"] = $pr;
    $count = count($values);
    $_SESSION["file_str"] = ftell($file);
    if ($count)
    {
        $line = $values[0];
        $time = $line["time"]->format('Y-m-d H:i:s');
        $arrData1=[
            'id_ip'=>trim($line["ip"])
        ];
        $last_index=selectOne('id_table',$arrData1);
        if(!$last_index){
            $last_index=insert('id_table',$arrData1);
        }else{
            $last_index=$last_index['id'];
        }
        $arrData=[
            'id_ip'=>$last_index,
            'date'=>$time,
            'path'=>$line["path"],
            'status'=>$line["status"]
        ];
        insert('data_table',$arrData);
        for ($i = 1; $i < $count; $i++)
        {
            $line = $values[$i];
            $time = $line["time"]->format('Y-m-d H:i:s');
            $arrData1=[
                'id_ip'=>trim($line["ip"])
            ];
            $last_index=selectOne('id_table',$arrData1);
            if(!$last_index){
                $last_index=insert('id_table',$arrData1);
            }else{
                $last_index=$last_index['id'];
            }
            $arrData=[
                'id_ip'=>$last_index,
                'date'=>$time,
                'path'=>$line["path"],
                'status'=>$line["status"]
            ];
            insert('data_table',$arrData);
        }
    }
    $new_pr=$pr/10;
    echo(json_encode($new_pr));
    fclose($file);
}
?>

