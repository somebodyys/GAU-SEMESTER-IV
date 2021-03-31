<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        td, th{
            border: solid 1px black;
            padding: 25px;
        }
    </style>
</head>
<body>
    <table>
    
    
    <?php
        foreach($_POST as $key => $value){
    ?>
        <tr>
            <th><?=$key?></th>
            <td><?=$value?></td>
        </tr>


    <?php
        }
    ?>

    </table>

    
</body>
</html>