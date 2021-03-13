<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        div{
            width: 1000px;
            padding: 10px;
            border: solid;
            margin: auto;
            margin-bottom: 10px;
        }
    </style>
</head>

<body>
    <div>
        <h2>Array 1</h2>
        <?php
            $massive1 = array(3 , 5.9 , "hello", "78");
            $massive2 = [4, 9.8, "PHP", 8, true];
            echo $massive2[2];
            echo "<hr>";
            echo $massive1[3];
            echo "<hr>";
            echo "<pre>";
                var_dump($massive1);
            echo "</pre>";

            echo "<pre>";
                print_r($massive1);
            echo "</pre>";
            array_push($massive1, 34,35);
            echo "<pre>";
                print_r($massive1);
            echo "</pre>";
        ?>
    
    </div>

    <div>
        <h2>Associative Array</h2>
        <?php
            $massive3 = ['name' => "Tornike", 'Mobile' => "522658479", "Age" => 37];
            echo "<pre>";
                print_r($massive3);
            echo "</pre>";

            $massive4 = ['Age' => 89];
            $massive34 = array_merge($massive3, $massive4);
            echo "<pre>";
                print_r($massive34);
            echo "</pre>";
            echo "<hr>";
            foreach($massive34 as $key => $value){
                echo "<br>";
                echo $key." => ".$value;
            }
        ?>
        
    </div>

    <div>
        <h2>Multidimensional Array</h2>
        <?php
            $massive5 = [
                34,
                [4, "Php", 5.9],
                7,
                ['name' => ["Cotne", "Dato", "Petre"], 'age' => 21]
            ];
            echo "<pre>";
                print_r($massive5);
            echo "</pre>"


        ?>
    </div>

</body>

</html>