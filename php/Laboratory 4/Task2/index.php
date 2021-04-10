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
    <?php
    if (!is_dir("storage")) mkdir("storage");
    ?>
    <div id="wrapper">
        <nav>
            <?php include "navigation.php" ?>
        </nav>

        <div id="out">
            
            <div id="structure">
                <?php
                    $folders = scandir("storage");
                    for ($i=2; $i < sizeof($folders); $i++) { 
                        echo "<div class='folder'>$folders[$i]</div>";
                    }
                ?>
            </div>
            <div id="edit"></div>
        
        </div>

    </div>
</body>

</html>