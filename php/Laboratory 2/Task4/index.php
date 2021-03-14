<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table{
            
            margin: auto;
            border-collapse: collapse;
        }

        td, th{
            border: solid 1px black;
            padding: 30px;
        }
        h1{
            text-align: center;
        }
    </style>
</head>

<body>

    <h1>Task 4</h1>

    <?php
        $cars = [
            [
                'Make' => "Toyota",
                'Model' => "Corolla",
                'Color' => "White",
                'Mileage' => 24000,
                'Status' => "Sold"
            ],
            [
                'Make' => "Toyota",
                'Model' => "Camry",
                'Color' => "Black",
                'Mileage' => 56000,
                'Status' => "Available"
            ],
            [
                'Make' => "Honda",
                'Model' => "Accord",
                'Color' => "White",
                'Mileage' => 15000,
                'Status' => "Sold"
            ]
        ];
    ?>


    <table>
        <tr>
            <?php
                foreach(array_keys($cars[0]) as $header){
            ?>
                <th><?=$header?></th>
            <?php
                }
            ?>
        </tr>
        
        <?php
            foreach($cars as $car){
        ?>
            <tr>
                <?php
                    foreach($car as $item){
                ?>
                    <td><?=$item?></td>
                <?php
                }
                ?>
            </tr>
        <?php
            }
        ?>

    
    </table>

</body>

</html>