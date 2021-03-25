<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body{
            padding-top: 50px;
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        
        table{
            margin-top: 50px;
            border-collapse: collapse;
        }

        td{
            border: solid 1px black;
            padding: 25px;
        }

        form{
            padding: 25px;
        }
    </style>
</head>

<body>
    <?php
        include "../Task1/task1.php";
    ?>

    <form method="post">
        <input type="number" name="row" placeholder="Rows">
        <input type="number" name="col" placeholder="Columns">
        <input type="number" name="min" placeholder="Min">
        <input type="number" name="max" placeholder="Max">
        <button type="submit" name="sub">Generate</button>
    </form>


    <?php
        if(isset($_POST['sub'])){
            try{
                drawTable($_POST['row'], $_POST['col'], $_POST['min'], $_POST['max']);
            }catch(Exception $ex){
                echo "<h2 style='color:red;'>".($ex -> getMessage())."</h2>";
            }   
        }
    ?>

</body>

</html>