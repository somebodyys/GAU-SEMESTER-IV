<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        .code{
            padding-top: 25px;
            padding-bottom:  25px;
            margin: auto;
            font-size: 30px;
        }
        .error{
            background-color: red;
        }

        .right{
            background-color: greenyellow;
        }

        .normal{
            background-color: white;
        }
    </style>
</head>

<body>


    <?php
    
        function generate_code($digits=5){
            $result = "";
            for($i = 0; $i < $digits; $i++){
                $result .= rand(0,9);
            }
            return $result;
        }

        print_r($_POST);
        
        $code = generate_code();
        $input_view = "normal";
        $value = "";
        $old = "";
        if(isset($_POST['input'])){
            $num = $_POST['input'];
            $value = $num;
            $old = $_POST['code'];
            if($_POST['code'] == $num){
                $input_view = "right";
            }else{
                $input_view = "error";
            }
        }

    ?>

    <div class="code">
        Old Code :
        <?=$old?>
    </div>
    <div class="code">
        New Code :
        <?=$code?>
    </div>

    <form method="post">
        <input class="<?=$input_view?>" type="number" name="input" value="<?=$value?>">
        <input type="hidden" name="code" value="<?=$code?>">
        <button type="submit">Check</button>
    </form>
</body>

</html>