<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table td {
            width: 250px;
            height:80px;
            text-align: center;
        }

        table {
            margin: auto;
            box-shadow: 0px 0px 15px gray;
            padding: 15px;
            border-radius: 15px;
        }
    </style>
</head>

<body>

    <?php
        $fname = $_GET["fname"];
        $lname = $_GET["lname"];
        $position = $_GET["position"];
        $salary = $_GET["salary"];
        $tax = $_GET["tax"];
        $finalSalary = ($salary * (100-$tax))/100;
    ?>
    <table>
        <tr>
            <td>სახელი : <?=$fname?></td>
            <td>გვარი : <?=$lname?></td>
            <td>პოზიცია : <?=$position?></td>
        </tr>
        <tr>
            <td>ხელფასი : <?=$salary?></td>
            <td>გადასახადი : <?=$tax?></td>
            <td>ხელზე ასაღები :<?=$finalSalary?></td>
        </tr>
    </table>




</body>

</html>