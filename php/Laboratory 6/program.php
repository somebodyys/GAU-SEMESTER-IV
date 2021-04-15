<?php
    if(!is_dir("tests")) mkdir("tests");
    $error = "";
    if (isset($_POST['sub'])) {
        $newFile = $_FILES['myQuiz'];
        $extension = pathinfo($newFile['name'], PATHINFO_EXTENSION);
        if($extension == "txt"){
            move_uploaded_file($newFile['tmp_name'], "tests/".$newFile['name']);
        } else{
            $error = "Wrong Format! Only txt files!";
        }
    }

    if(isset($_POST['del'])) unlink("tests/".$_POST['del']);
    
?>