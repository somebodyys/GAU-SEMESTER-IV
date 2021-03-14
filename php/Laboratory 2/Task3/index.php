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
            width: 85px;
            height: 85px;
            text-align: center;
        }
        h1{
            text-align: center;
        }
    </style>
</head>
<body>
    <h1>Task 3</h1>
    <table>
        <?php
            for($row = 0; $row < 6; $row++){
        ?>
            <tr>
                <?php
                    for($col = 0; $col < 5; $col++){    
                ?>  
                    <td><?=$row + $col?></td>

                <?php
                }?>
            </tr>
        <?php
        }?>
    </table>  
</body>
</html>