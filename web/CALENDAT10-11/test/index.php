<?php
require_once 'class.calendar.php';
$phpCalendar = new PHPCalendar ();
?>
<html>
<head>
<link href="style.css" type="text/css" rel="stylesheet" />
<title>PHP Calendar</title>
</head>
<body>
<!--<div id="body-overlay"><div><img src="loading.gif" width="64px" height="64px"/></div></div>-->
<div id="calendar-html-output">
<?php
$calendarHTML = $phpCalendar->getCalendarHTML();
echo $calendarHTML;
?>

</div>

<script src="jquery-1.11.2.min.js" type="text/javascript"></script>
<script src="script.js"></script>
</body>
</html>