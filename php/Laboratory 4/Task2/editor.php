<?php
    if(isset($_POST['fileName'])){
        if(!empty($_POST['fileName'])){
            $file = fopen($path."/".$_POST['fileName'].".txt", "w");
            fwrite($file, $_POST['fileContent']);
            fclose($file);
            header("Refresh:0");
        }else{
            echo "<script>alert('File Name can not be empty!')</script>";
        }
    }

    $data = "";
    $name = "";
    if(isset($_POST['update'])){
        $file = fopen($_POST['update'], 'r+');
        $data =  fread($file, filesize($_POST['update']));
        $indo = explode("/",$_POST['update']);
        $name = $indo[count($indo)-1];
        $name = explode(".", $name)[0];
    }   

?>


<form method="post">
    <input type="text" name="fileName" placeholder="File Name" value="<?=$name?>">
    <textarea name="fileContent" id="" cols="50" rows="10"><?=$data?></textarea>
    <button type="submit">Update</button>
</form>

