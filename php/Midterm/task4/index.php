<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>

    <?php
        if(!is_dir("storage")) mkdir("storage");
        if (isset($_POST['sub'])) {
            $myFile = $_FILES['myQuiz'];
            $inside = fopen($myFile['tmp_name'], "r");
            if(filesize($myFile['tmp_name']) > 0){
                $check = true;
                while(!feof($inside)){
                    for ($i=0; $i < 6; $i++) { 
                        $line = fgets($inside);
                        if(empty($line)) break;
                        echo "|".$line."|<br>";
                        switch($i){
                            case 0: 
                                if(trim($line) != "===") $check = false;
                                break;
                            case 1:
                                break;
                            case 2:
                                if(substr($line, 0, 2) != "A)") $check = false;
                                break;
                            case 3:
                                if(substr($line, 0, 2) != "B)") $check = false;
                                break;
                            case 4:
                                if(substr($line, 0, 2) != "C)") $check = false;
                                break;
                            case 5:
                                if(substr($line, 0, 2) != "D)") $check = false;
                                break;
                        }
                    }
                }
                if($check){
                    move_uploaded_file($myFile['tmp_name'], "storage/".$myFile['name']);
                    echo "great, Right Format, Uploaded";
                } else{
                    echo "Wrong Format";
                }
            }
            fclose($inside);
        }

    ?>

    <form  method="post" enctype="multipart/form-data">
        <input type="file" name="myQuiz">
        <button name="sub">Upload</button>
    </form>

</body>

</html>