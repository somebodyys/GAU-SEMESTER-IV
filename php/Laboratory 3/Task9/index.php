<?php


    function pass_strength($password){
        $meter = 0;
        if(strlen($password) > 8) $meter++;
        if(preg_match("~(?=\S*[A-Z])~", $password)) $meter++;
        if(preg_match("~(?=\S*[\d])~", $password)) $meter++;
        if(preg_match("~(?=\S*[\W])~", $password)) $meter++;
        
        switch($meter){
            case 0: 
                return "Very weak!"; break;
            case 1:
                return "Weak!"; break;
            case 2:
                return "Normal"; break;
            case 3:
                return "Strong"; break;
            case 4:
                return "Very Strong!"; break;
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            display: flex;
            flex-direction: column;
            padding-top: 60px;
            text-align: center;
        }


    </style>
</head>
<body>

    <?php
        $input = "";
        if (isset($_POST['pass'])) {
            echo "<h2>".pass_strength($_POST['pass'])."</h2>";
            $input = $_POST['pass'];
        }
    ?>
    
    <form method="POST">
        <input type="text" name="pass" value="<?=$input?>">
        <button type="submit">Check</button>
    </form>

    
</body>
</html>