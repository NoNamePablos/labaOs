<?php
include 'logging.php';
include 'db.php';
if (isset($_GET["col"])) $col=$_GET["col"]; else $col=50;
$lines_cashe=file_get_contents("base_user", LOCK_EX);
$file=explode("\n",$lines_cashe);
$size_f=count($file)-1;


?>

    <html>
    <head>
        <style type='text/css'>
            td.zz { padding-left: 3px; font-size: 9pt; padding-top: 2px; font-family: Arial; }
        </style>
    </head>

<body>
<div style="text-align: center;">
<?php
if ($col>$size_f) $col=$size_f;
echo 'Последние <b>'.$col.'</b> посещений сайта ботами:';
?>

    <table style="width: 750px; table-layout: fixed; border: 0;">
        <tr bgcolor="#eeeeee">
            <td class="zz" style="width: 100px;"><b>Время, дата</b></td>
            <td class="zz" style="width: 250px;"><b>Кто посещал</b></td>
            <td class="zz" style="width: 100px;"><b>IP, прокси</b></td>
            <td class="zz" style="width: 300px;"><b>Посещенный URL</b></td>
        </tr>

<?php
for ($si=$size_f-1; $si>=$size_f-$col; $si--) {
    $str=explode("|",$file[$si]);
    insert('logs',['date'=>$str[0],'user_agent'=>$str[1],'ip_addres'=>$str[2],'url'=>$str[3]]);
    echo '<tr bgcolor="#eeeeee"><td class="zz">'.$str[0].'</td>';
    echo '<td class="zz">'.$str[1].'</td>';
    echo '<td class="zz">'.$str[2].'</td>';
    echo '<td class="zz"><a href="http://usefulscript.ru'.$str[3].'">'.$str[3];
    echo '</a></td></tr>';

}
echo '</table>';
echo '<br>Просмотреть последние <a href=?col=100>100</a> <a href=?col=500>500</a> ';
echo '<a href=?col=1000>1000</a> посещений.';
echo '<br>Просмотреть <a href=?col='.sizeof($file).'>все посещения</a>.';
echo '</div></body></html>';
?>