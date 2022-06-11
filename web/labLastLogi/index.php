<?php
include 'helpers/connection.php';
include 'helpers/db.php';
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
	<title>Помянем...</title>
</head>
<body>
<div class="demo-wrapper html5-progress-bar">
    <div class="progress-bar-wrapper">
        <progress id="progressbar" value="0" max="100"></progress>
        <span class="progress-value">0%</span>
    </div>

    <div class="btn_line">
        <button id="btn_load" >Загрузить</button>
        <button id ="btn_data">Показать</button>
        <button id ="btn_min">По убыванию</button>
        <button id ="btn_max">По возрастанию</button>
        <div class="wrapper">
            <button id ="btn_hours">По часам</button>
            <input type="text" id="hours" name="hours" placeholder="Часы">
        </div>
        <div class="wrapper">
            <button id ="btn_minutes">По минутам</button>
            <input type="text" id="minutes" name="minutes" placeholder="Минуты">
        </div>
        <div class="wrapper">
            <button id ="btn_sec">По секундам</button>
            <input type="text" id="sec" name="sec" placeholder="Секунды">
        </div>
        <button id ="all_time">Всё время</button>

    </div>




	<!--
	<button type="submit" id = "delet">Удалить</button>
	<button type="submit" onclick="clickSave();">Загрузить</button>
	<button type="submit" onclick="clickSave();">Стоп</button>
	-->
</div>
<div class="table">
    <table id="mainTable" class="table table-bordered table-dark">
        <thead>
        <tr>
            <th scope="col">#</th>
            <th scope="col">date</th>
            <th scope="col">path</th>
            <th scope="col">status</th>
        </tr>
        </thead>
        <tbody>

        </tbody>
    </table>
</div>
<script src="ajjax.js"></script>
<script src="ajax.js"></script>
<script  src="data_min.js"></script>
<script  src="data_max.js"></script>
<script  src="all_data.js"></script>
<script src="data_hours.js"></script>
<script src="data_minutes.js"></script>
<script src="date_sec.js"></script>
<script src="data_timeAll.js"></script>
</body>
</html>