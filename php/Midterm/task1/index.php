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
            border: solid 1px black;
            display: flex;
            align-items: center;
            justify-content: space-around;
            padding: 30px;
            width: 500px;
        }

        #error{
            font-size: 10px;
            color: red;
        }

        #sucess{
            font-size: 20px;
            color: greenyellow;

        }
    </style>
</head>

<body>
    <?php 
        if(!is_dir("Files")) mkdir("Files");
        
        $file_counter = isset($_GET['count']) ? $_GET['count'] : 0;
        $error = "";
        $sucess = "";
        if(isset($_POST['sub'])){
            $file = $_FILES['myFile'];
            if(pathinfo($file['name'], PATHINFO_EXTENSION) == "txt"){
                $file_counter++;
                header("Location: index.php?count=".$file_counter);
                move_uploaded_file($file['tmp_name'], "Files/".$file_counter);
                $openFile = fopen("Files/".$file_counter, "w");
                $res = "";
                for ($i=0; $i < $file_counter; $i++) { 
                    $res .= rand(0, 1000);
                    $res .= "\n";
                }
                fwrite($openFile, $res);
                
                fclose($openFile);
            }else{
                $error = "Wrong Format! Only TXT!";
            }
        }

    ?>


    <form method="post" enctype="multipart/form-data">
        <input type="file" name="myFile">
        <button name="sub">Upload</button>
        <div id="error"><?=$error?></div>
    </form>
    <div id="sucess"><?=$sucess?></div>


</body>

</html>