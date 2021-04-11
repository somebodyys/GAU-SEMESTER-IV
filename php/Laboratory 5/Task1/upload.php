<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        form{
            margin: auto;
            border-radius: 30px;
            width: 350px;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: space-around;
            box-shadow: 0px 0px 15px gray;
            padding: 25px;
        }

        .error{
            font-size: 12px;
            color: red;
        }
        #wrap{
            margin-bottom: 10px;
            display: flex;
        }
        
        .sucess{
            color: greenyellow;
        }
    
    </style>
</head>
<body>

    <?php
        if(!is_dir("storage")) mkdir("storage");
        $errors = [];
        $got = "";
        if(isset($_POST['sub'])){
            $file = $_FILES['myFile'];
            $extension = pathinfo($file['name'], PATHINFO_EXTENSION);
            if ($file['size'] > 100*1024*1024) array_push($errors, "Max file size 100mb!");
            if($extension != "jpg" && $extension != "png" && $extension != "gif") array_push($errors, "Only jpg | png | gif formats!");
            if(count($errors) == 0){
                $got = "Uploaded Sucessfully!";
                date_default_timezone_set("Asia/Tbilisi");
                $file_path = "storage/".date("Y-M-D-h-i-s").".".$extension;
                move_uploaded_file($file['tmp_name'], $file_path);
            }
        }
    ?>


    <form method="post" enctype="multipart/form-data">
        <div id="wrap">
            <input type="file" name="myFile" accept=".jpg, .png, .gif">
            <button type="submit" name="sub">Upload</button>
        </div>
        
        <div>
            <?php
                foreach ($errors as $value) {
                    echo "<div class='error'>$value</div>";
                }
            ?>
            <div class="sucess"><?=$got?></div>
        </div>
        
    </form>
    
</body>
</html>