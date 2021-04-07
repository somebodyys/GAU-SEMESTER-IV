<!DOCTYPE html>
<html lang="en">
<head>
    <title>Document</title>
    <style>
        form, .files{
            border:solid black 1px;
            margin: 10px auto;
            padding: 10px;
            width: 500px;
        }
    </style>
</head>
<body>
    <?php
        if(!is_dir("files")){
            mkdir("files");
        }
        if (isset($_POST['sub'])) {
            $fileName = $_POST['fineName'];
            $text = $_POST['text'];
            if(empty($fileName)){
                $fileName = "file.txt";
            }else{
                $fileName = $fileName.".txt";
            }
            $file = fopen("files/".$fileName, 'w');
            fwrite($file, $text);
        }
    
    ?>
    <div class="files">
        <h2>Files</h2>
        <ul>
            <?php
                $files = scandir("files");
            ?>
            <li>
                <a href="files/file.txt" download>File 1</a>
            </li>        
            <li>
                <a href="">File 2</a>
            </li>
        </ul>
    </div>
    <form method="post">

        <input type="tel" name="fineName" > - File Name
        <br><br>
        <textarea name="text" id="" cols="40" rows="10"></textarea>
        <br><br>
        <button type="submit" name="sub">Write In File</button>
    </form>
</body>
</html>