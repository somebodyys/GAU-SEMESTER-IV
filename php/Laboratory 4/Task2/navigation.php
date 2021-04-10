<?php
    if(isset($_POST['folderName'])){
        if(!is_dir("storage/".$_POST['folderName'])){
            mkdir("storage/".$_POST['folderName']);
        }else{
            echo "<script>alert('Folder with same name already exists!')</script>";
        }
    }
?>

<form method="post">
    <input type="text" name="folderName" placeholder="Folder Name...">
    <button>Create</button>
</form>