<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        form {
            margin: auto;
            padding: 30px;
            width: 500px;
        }

        input {
            margin-bottom: 25px;
        }
    </style>
</head>

<body>

    <?php

    $myFile = fopen("numbers.txt", "w");
    if (isset($_POST['N'])) {
        $N = $_POST['N'];
        $a = $_POST['a'];
        $b = $_POST['b'];
        $result = "";
        for ($i = 0; $i < $N; $i++) {
            $result .= $i == $N - 1 ? rand($a, $b) : rand($a, $b) . ",";
        }
        fwrite($myFile, $result);

        fclose($myFile);
    }
    ?>


    <form method="post">
        <input type="number" name="N"> - N <br>
        <input type="number" name="a" id=""> - a <br>
        <input type="number" name="b" id=""> - b <br>
        <button>Generate</button>
    </form>


    <ul>
        <?php
        if (filesize("numbers.txt") > 0) {
            $file = fopen("numbers.txt", "r");
            $inside = fread($file, filesize("numbers.txt"));
            $numbers = explode(",", $inside);

            foreach ($numbers as $value) {
                if (strlen($value) == 2) {
                    echo "<li>$value</li>";
                }
            }
        }

        ?>
    </ul>
</body>

</html>