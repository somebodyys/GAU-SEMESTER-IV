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
                    
                    $starter = fgets($inside);
                    
                    if(trim($starter) != "==="){
                        $check = false ;
                        break;
                    } 
                    $question = fgets($inside);
                    if($question == "") break;
                    $a = fgets($inside);
                
                    if(substr($a, 0, 2) != "A)"){
                        $check = false ;
                        break;
                    }
                    $b = fgets($inside);
                    
                    if(substr($b, 0, 2) != "B)"){
                        
                        $check = false ;
                        break;
                    }

                    $c = fgets($inside);
                    
                    if(substr($c, 0, 2) != "C)"){
                        
                        $check = false ;
                        break;
                    }

                    $d = fgets($inside);
                    
                    if(substr($d, 0, 2) != "D)"){
                        
                        $check = false ;
                        break;
                    }
                }

                if($check){
                    move_uploaded_file($myFile['tmp_name'], "storage/".$myFile['name']);
                    echo "great, Right Format, Uploaded";
                } else{
                    echo "Wrong Format";
                }
                
            }
        }

    ?>

    <form  method="post" enctype="multipart/form-data">
        <input type="file" name="myQuiz">
        <button name="sub">Upload</button>
    </form>

</body>

</html>