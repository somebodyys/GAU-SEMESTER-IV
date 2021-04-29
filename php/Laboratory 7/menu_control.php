<?php require_once "db_connect.php"; ?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>

    <?php
        $error = "";

        if(isset($_GET['action']) && $_GET['action'] == "upload" && isset($_POST['add'])){
            $title = $_POST['Title'];
            $meta_k = $_POST['Meta_k'];
            $meta_d = $_POST['Meta_d'];
            $text = $_POST["Text"];
            
            if(strlen($title) > 50) $error.= "Max Title Length 50sym, ";
            if(strlen($meta_k) > 200 && strlen($meta_d) > 200) $error.= "Max Meta key/Desc length 200sym, ";

            if(empty($error)){
                $insert_query = "
                    INSERT INTO menu(Title, Meta_k, Meta_d, Text)
                    VALUES ('$title', '$meta_k', '$meta_d', '$text')
                ";
                if(mysqli_query($conn, $insert_query)) header("Location: menu_control.php");
                $error = mysqli_error($conn);
                
            }
            

        }

    
    
    ?>
    <h1>Welcone To Menu Editor!</h1>

    <form action="?action=upload" method="post" id="menuEditor">
        <div id="inputs">
            <input type="text" placeholder="Title" name="Title" required>
            <input type="text" placeholder="Meta Key" name="Meta_k" required>
            <input type="text" placeholder="Meta Describtion" name="Meta_d" required>
        </div>
        
        <textarea name="Text" id="" cols="30" rows="10"></textarea>
        <button name="add">Add</button>
    </form>

    <div id="result">
        <div class="error"><?=$error?></div>
    </div>
</body>

</html>