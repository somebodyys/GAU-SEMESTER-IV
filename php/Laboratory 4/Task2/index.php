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
            <?php
            function delTree($dir)
            {
                if(!is_dir($dir)) return unlink($dir);
                $files = array_diff(scandir($dir), array('.', '..'));
                foreach ($files as $file) {
                    (is_dir("$dir/$file")) ? delTree("$dir/$file") : unlink("$dir/$file");
                }
                return rmdir($dir);
            };
            if (count($_GET) == 0) {
                $path = "storage";
            } else {
                $key = array_keys($_GET)[0];
                $path = $key . "/" . $_GET[$key];
            }

            $folder_content = scandir($path);
            if (isset($_GET[$path])) {

                $path .= "/" . $folder_content[$_GET[$path]];
            }

            if(isset($_POST['del'])){
                delTree($_POST['del']);
            }


            include "navigation.php" ?>
        </nav>

        <div id="out">

            <div id="structure">
                <?php
                echo $path;
                ?>

                <div id="output">
                    <?php
                    $folder_content = scandir($path);
                    for ($i = 2; $i < count($folder_content); $i++) {
                        if(is_dir($path."/".$folder_content[$i])){
                            echo 
                            "<div class='folder'>
                                <a href='index.php?$path=$folder_content[$i]'>$folder_content[$i]</a>
                                <form method='post'>
                                    <input type='hidden' name='del' value='$path/$folder_content[$i]'>
                                    <button type='submit'>remove</button>
                                </form>
                            </div>";
                        }else{
                            echo 
                            "<div class='file'>
                                <form method='post'>
                                    <input type='hidden' name='update' value='$path/$folder_content[$i]'>
                                    <button type='submit' style='border:none; background:white;cursor:pointer;'>$folder_content[$i]</button>
                                </form>
                                <form method='post'>
                                    <input type='hidden' name='del' value='$path/$folder_content[$i]'>
                                    <button type='submit'>remove</button>
                                </form>
                            </div>";
                        }
                
                        
                    }
                    ?>

                </div>


            </div>
            <div id="edit">
                <?php include "editor.php"; ?>

            </div>

        </div>

    </div>
</body>

</html>