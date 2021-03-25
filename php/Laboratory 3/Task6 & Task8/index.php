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
    function get_rand_matrix($rows, $cols, $min, $max)
    {
        $result = [];
        for ($i = 0; $i < $rows; $i++) {
            $temp = [];
            for ($j = 0; $j < $cols; $j++) {
                array_push($temp, rand($min, $max));
            }
            array_push($result, $temp);
        }
        return $result;
    }
    function drawTable($rows = 10, $cols = 10, $min = 10, $max = 99)
    {

        if ($min > $max) {
            $temp = $min;
            $min = $max;
            $max = $temp;
        }
        if ($rows <= 0 || $cols <= 0 || $rows == "" || $cols == "" || $min == "" || $max == "") {
            throw new Exception("Table Dimensions Can not be Negative, Zero or Empty!");
        }
        $matrix = get_rand_matrix($rows, $cols, $min, $max);
        echo "<table>";
        for ($i = 0; $i < $rows; $i++) {
            echo "<tr>";
            for ($j = 0; $j < $cols; $j++) {
                echo "<td>";
                echo $matrix[$i][$j];
                echo "</td>";
            }
            echo "<td style='border:none; color:green;'>";
            echo array_sum($matrix[$i]);
            echo "</td>";
            echo "</tr>";
        }
        echo "<tr>";
            for ($i=0; $i < $cols; $i++) { 
                $colSUm = 0;
                for ($j=0; $j < $rows; $j++) { 
                    $colSUm += $matrix[$j][$i];
                }
                echo "<td style='border:none; color:green;'>";
                echo $colSUm;
                echo "</td>";
            }
        echo "</tr>";   
        echo "</table>";
    }

    ?>

    <form method="post">
        <input type="number" name="row" placeholder="Rows">
        <input type="number" name="col" placeholder="Columns">
        <input type="number" name="min" placeholder="Min">
        <input type="number" name="max" placeholder="Max">
        <button type="submit" name="sub">Generate</button>
    </form>


    <?php
        if (isset($_POST['sub'])) {
            try {
                drawTable($_POST['row'], $_POST['col'], $_POST['min'], $_POST['max']);
            } catch (Exception $th) {
                echo "<h2 style='color:red;'>".$th -> getMessage()."</h2>";
            }
        }
    ?>

</body>

</html>