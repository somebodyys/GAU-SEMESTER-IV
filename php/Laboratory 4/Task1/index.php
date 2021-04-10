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
        if(isset($_POST['in'])){
            $file = fopen("storage/".date("Y-M-D-H-i-s").".txt", "w");
            fwrite($file, $_POST['in']);
            fclose($file);
        }
    
    ?>

    <form method="post">
        <textarea name="in" id="" cols="50" rows="10"></textarea>
        <button type="submit">Generate</button>
    </form>

    <div id="out">
        <h3>Available Files</h3>
        <?php
            $storage = scandir("storage");
            if (sizeof($storage) == 2) {
                echo "<p>No Files Available....</p>";
            }else{
                echo "<ol>";
                for ($i=2; $i < sizeof($storage); $i++) { 
                    echo "<li>"."<a href='storage/$storage[$i]' download>".$storage[$i]."</a>"."</li>";
                }
                echo "</ol>";
            }
            
        ?>
    </div>

</body>

</html>