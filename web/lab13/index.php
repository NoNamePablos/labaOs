<?php
include 'logging.php';
include  "upload.php";
?>
<!DOCTYPE html>

<html>
<head>
    <script src="https://code.jquery.com/jquery-2.2.0.min.js"></script>
    <script src="//oss.maxcdn.com/jquery.form/3.50/jquery.form.min.js"></script>
    <link rel='stylesheet' href='./style.css' />
</head>
<body>

<div class='formarea'>
    <h2>Нюдс не грузить =_=</h2>
    <form method='post' action='upload.php' enctype='multipart/form-data'>
        <input type='file' name='file' />
        <button>Загрузить</button>
    </form>
    <!--
    какой еблан в 21 году юзает просто div для прогрессбара,есть же готовый тег...Ладно,просто это чуть чуть спизжено =)
    -->
    <div id="bararea">
        <div id="bar"></div>
    </div>
    <div id='percent'></div>
    <div id='status'></div>
</div>
<script src="./main.js"></script>
</body>
</html>
