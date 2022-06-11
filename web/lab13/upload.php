<?php

//Checking the request
if($_SERVER['REQUEST_METHOD']=='POST'){

    //Getting the file
    $file = $_FILES['file']['tmp_name'];

    //Getting the name of the file
    $name = $_FILES['file']['name'];
    $extension = pathinfo($name, PATHINFO_EXTENSION);

    $new_name = uniqid() . '.' . $extension;
    //Path to upload
    $path = './images/';

    //Storing the file to location
    move_uploaded_file($file,$path.$new_name);

    //displaying success message
    echo 'success';
}