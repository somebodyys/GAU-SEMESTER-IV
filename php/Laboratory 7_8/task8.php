<?php require_once "db_connect.php"; ?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>

    <ol>
        <li>United In Task 2</li>
        <li>
            <ul>
                <?php
                    $queryOne = "
                        SELECT Text, Title
                        FROM menu
                    ";

                    $callBack = mysqli_query($conn, $queryOne);

                    
                    while($res = mysqli_fetch_assoc($callBack)){
                        echo  "<li>";
                        foreach ( $res as $value) {
                            echo $value."&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                        }
                        echo "</li>";
                    } 
                ?> 
            
            </ul>
             
        </li>

        <li>
            <ul>
                <?php
                    $queryOne = "
                        SELECT *
                        FROM menu
                        WHERE Id = 2
                    ";
                    
                    $callBack = mysqli_query($conn, $queryOne);
                    foreach (mysqli_fetch_assoc($callBack) as $value) {
                        echo "<li>$value</li>";    
                    }
                ?>
            </ul>
        </li>

        <li>
            <ul>
                <?php 
                    $queryOne = "
                        SELECT *
                        FROM menu
                        WHERE Id >= 2
                    ";
                    $callBack = mysqli_query($conn, $queryOne);

                    while($res = mysqli_fetch_assoc($callBack)){
                        echo "<li>";
                        foreach ($res as $value) {
                            echo $value."&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                        }
                        echo "</li>";
                    }
                ?>
            </ul>     
        
        </li>

        <li>
            <ul>
                <?php 
                    $queryOne = "
                        SELECT *
                        FROM menu
                        WHERE Id <= 4
                    ";
                    $callBack = mysqli_query($conn, $queryOne);

                    while($res = mysqli_fetch_assoc($callBack)){
                        echo "<li>";
                        foreach ($res as $value) {
                            echo $value."&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                        }
                        echo "</li>";
                    }
                ?>
            </ul>     
        
        </li>
        <li>
            <ul>
                <?php 
                    $queryOne = "
                        SELECT *
                        FROM menu
                        WHERE Title = N'ფილმები' OR Title = N'თამაშები'
                    ";
                    $callBack = mysqli_query($conn, $queryOne);

                    while($res = mysqli_fetch_assoc($callBack)){
                        echo "<li>";
                        foreach ($res as $value) {
                            echo $value."&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                        }
                        echo "</li>";
                    }
                    
                ?>
            </ul>     
        
        </li>
        <li>
            <ul>
                <?php 
                    $queryOne = "
                        SELECT *
                        FROM menu
                        WHERE Title = N'მუსიკები' AND Id > 3
                    ";
                    $callBack = mysqli_query($conn, $queryOne);

                    while($res = mysqli_fetch_assoc($callBack)){
                        echo "<li>";
                        foreach ($res as $value) {
                            echo $value."&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                        }
                        echo "</li>";
                    }
                ?>
            </ul>     
        
        </li>
    </ol>
</body>

</html>