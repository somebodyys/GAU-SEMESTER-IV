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
        if(!is_dir("results")) mkdir("results");
        $result = fopen("results/".date("Y_M_D_H_I_s"), "w");
        $score = 0;
        for($i = 0; $i < count($_POST)/2; $i++){
            if($_POST['choice'.$i] == $_POST['correct'.$i]) $score++;
            fwrite($result, "Question $i { Choice : ".$_POST['choice'.$i]."  Correct : ".trim($_POST['correct'.$i])."} \n");
        }
        fclose($result);
        
        
        // echo "<pre>";
        // print_r($_POST);
        // echo "</pre>";
    ?>

    <div id="result">
        <h1>Thank you!</h1>
        <h3>Final Score : <?=$score?>/<?=count($_POST)/2?></h3>
    </div>


</body>

</html>