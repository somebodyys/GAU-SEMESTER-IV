<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        #wrap{
            margin: auto;
            width: 250px;

            box-shadow: 0px 0px 15px blueviolet;
            border-radius: 8px;
        }
        form{
            width: 100%;
            text-align: center;
            padding-top: 15px;
            padding-bottom: 15px;
        }
        #out{
            width: 100%;
            padding-top: 15px;
            text-align: center;
            padding-bottom: 15px;
        }
    </style>
</head>

<body>

    <?php
        $numbers = [];
        for($i = 0; $i < 12; $i++){
            array_push($numbers,rand(10, 100));
        }
        echo "Random Array : ";
        echo "<pre>";
            print_r($numbers);
        echo "</pre>";

        $count_less = 0;
        $count_more = 0;
        if(isset($_POST['check_num'])){
            foreach($numbers as $item){
                if($item > $_POST['check_num']){
                    $count_more++;
                }
                if($item < $_POST['check_num']){
                    $count_less++;
                }
            }
        }
    ?>

    <div id="wrap">
        <div id="in">
            <form method="post">
                <input type="number" name="check_num" placeholder="Check Numebr">
                <button type="submit">Get</button>
            </form>
        </div>
        <?php
            if(isset($_POST['check_num']) && $_POST['check_num'] != ""){
        ?>
            <div id="out">
                <div>
                    <label>Check:</label>
                    <?=$_POST['check_num']?>
                </div>
                <div id="more">
                    <label>More:</label>
                    <?=$count_more?>
                </div>
                <div id="less">
                    <label>Less:</label>
                    <?=$count_less?>
                </div>
            </div>
        <?php
            }
        ?>
    </div>
</body>

</html>