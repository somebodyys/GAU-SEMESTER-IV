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
    
    <?php include "program.php"; ?>

    <div id="upload">
        <form method="post" enctype="multipart/form-data">
            <input type="file" name="myFile">
            <button name="sub">Upload</button>
        </form>
        <br>
        <div class="error"><?=$error?></div>
        <div class="sucess"><?=$message?></div>
    </div>

    <div id="preview">
        <?php include "preview.php"; ?>
    </div>
</body>

</html>