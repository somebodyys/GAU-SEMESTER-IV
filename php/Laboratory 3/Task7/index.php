<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            padding-top: 50px;
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        table {
            margin-top: 50px;
            border-collapse: collapse;
        }

        td {
            border: solid 1px black;
            padding: 25px;
        }

        form {
            padding: 25px;
        }
    </style>
</head>

<body>

    <?php
        function rand_vector($size, $min, $max)
        {
            if ($min > $max) {
                $temp = $min;
                $min = $max;
                $max = $temp;
            }
            if($size <=0 || $size == "" || $min == "" || $max == ""){
                throw new Exception("Size can not be empty zero or negative!");
            }
            $result = [];
            for ($i = 0; $i < $size; $i++) {
                array_push($result, rand($min, $max));
            }
            return $result;
        }
    ?>


    <form method="post">
        <input type="number" name="size" placeholder="Length">
        <input type="number" name="min" placeholder="Min">
        <input type="number" name="max" placeholder="Max">
        <button type="submit" name="sub">Generate</button>
    </form>


    <?php
        if (isset($_POST['sub'])) {
            try {
                $vector = rand_vector($_POST['size'], $_POST['min'], $_POST['max']); 
                echo "<table><tr>";
                foreach ($vector as $value) {
                    echo "<td>";
                    echo $value;
                    echo "</td>";
                }
                echo "</tr></table>";
            } catch (Exception $th) {
                echo "<h2 style='color:red;'>".$th -> getMessage()."</h2>";
            }
                
        }
    ?>

</body>

</html>