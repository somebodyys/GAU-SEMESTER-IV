<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $date = date("Y-m-d", mktime(0,0,0,01,01,1800));
    ?>
    <input type="date" name="d" id="" value="<?=$date?>">
    
</body>
</html>