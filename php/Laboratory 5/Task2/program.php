<?php

    if(!is_dir("storage")) mkdir("storage");
    $error = "";
    $message = "";
    if(isset($_POST['del'])) unlink('storage/'.$_POST['del']);
    if(isset($_POST['sub'])){
        try{
            $file = $_FILES['myFile'];
            if($file['size'] > 50*1024*1024) $error = "Max file size : 50M!";
            if(empty($error)){
                move_uploaded_file($file['tmp_name'], "storage/".$file['name']);
                $message = "Uploaded Successfuly!";
            } 
        }catch(Exception $ex){
            $error = $ex -> getMessage();
        }
    }
?>