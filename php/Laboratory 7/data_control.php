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
        if(!is_dir("Storage")) mkdir("Storage");
        $error = "";
        if(isset($_GET['action']) && $_GET['action'] == "addData" && isset($_POST['Title'])){
            $title = $_POST['Title'];
            $date = $_POST['Date'];
            $type = $_POST['Type'];
            $text = $_POST['Text'];
            $author = $_POST['Author'];
            $description = $_POST['Description'];
            $meta_k = $_POST['Meta_k'];
            $meta_d = $_POST['Meta_d'];
            $photo = $_FILES['Photo'];
            
            
            $formats = ["jpg", "jpeg", "png", "gif"];
            
            if(filesize($photo['tmp_name']) < 100*1024*1024 && in_array(pathinfo($photo['name'], PATHINFO_EXTENSION), $formats)){
                move_uploaded_file($photo['tmp_name'], "Storage/".$photo['name']);
                $photo_path = "Storage/".$photo['name'];
                $data_query = "
                    INSERT INTO data(Title,Date,Type, Photo, Text, Author, Description, Meta_k, Meta_d)
                    VALUES ('$title', '$date', '$type', '$photo_path', '$text', '$author', '$description', '$meta_k', '$meta_d')
                ";
                if(mysqli_query($conn, $data_query)){
                    header("Location: data_control.php");
                }else{
                    echo "error";
                }
                $error = mysqli_error($conn);
            }
            $error = "Wrong Photo! Try Uploading Something else";
        } 
        
    ?>
    <h1>Data Control!</h1>
    <form action="?action=addData" method="post" id="dataEditor" enctype="multipart/form-data">
        <input type="text" name="Title" placeholder="Title" required>
        <input type="date" name="Date" required>
        <input type="text" name="Type" placeholder="Type" required>
        <input type="file" name="Photo" required>
        <textarea name="Text"cols="30" rows="10" placeholder="Text"></textarea><br>
        <input type="text" name="Author" placeholder="author">
        <textarea name="Description" cols="30" rows="10" placeholder="Description"></textarea> <br>
        <input type="text" name="Meta_k" placeholder="Meta_k" required>
        <input type="text" name="Meta_d" placeholder="Meta_d" required>
        <button>Upload</button>
    </form>
    <div class="error">
        <?=$error?>
    </div>
</body>

</html>