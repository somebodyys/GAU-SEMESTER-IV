<?php
    $action = "";
    $contact = "";
    $education = "";
    $workExp = "";
    if (isset($_POST['contact']) && $_GET['action'] == "addcv") {
        $aplicant_id = 1;
        $contact = $_POST['contact'];
        $education = $_POST['education'];
        $workExp = $_POST['wordExp'];
        $upload_query = "
            INSERT INTO cvs (contact, education, workExp, aplicant_id)
            VALUES ('$contact', '$education', '$workExp', '$aplicant_id')
        ";

        if(mysqli_query($conn, $upload_query)){
            echo "Success";
        }else{
            echo "failed";
        };
    }

    if ($_GET['action'] == "editcv") {
        $aplicant_id = 1;
        $cv_select = "
            SELECT *
            FROM cvs
            WHERE aplicant_id='$aplicant_id'
        ";

        $response = mysqli_query($conn, $cv_select);
        $res = mysqli_fetch_assoc($response);
        
        $cv_id = $res['id'];
        $contact = $res['contact'];
        $education = $res['education'];
        $workExp = $res['workExp'];
        $action = "?role=user&action=changeCv";
    }

    if (isset($_POST['del'])) {
        $id = $_POST['del'];
        $del_query = "
            DELETE FROM cvs
            WHERE id='$id'
        ";

        mysqli_query($conn, $del_query);
    }
    if(isset($_GET['action']) && $_GET['action'] == "changeCv"){
        
        $id = $_POST['id'];
        $cv_id = $id;
        $contact = $_POST['contact'];
        $education = $_POST['education'];
        $workExp = $_POST['wordExp'];
        $aplicant_id = 1;
        $update_query = "
            UPDATE cvs
            SET contact='$contact', education='$education', workExp='$workExp', aplicant_id='$aplicant_id'
            WHERE id='$id'
        ";
        echo "<form  method='post'>
                <input type='hidden' name='del' value='$id'>
                <button type='submit'>Delete</button>
            </form>";
        mysqli_query($conn, $update_query);
    }

?>


<div id="cvWrap">
    <form action="<?=$action?>" method="post">
        <input type="hidden" name="id" value="<?=$cv_id?>">
        <input type="text" name="contact" placeholder="contact" value="<?=$contact?>"><br><br>
        <textarea name="education" placeholder="education" cols="30" rows="10"><?=$education?></textarea><br><br>
        <textarea name="wordExp" placeholder="Work Experiance" id="" cols="30" rows="10"><?=$workExp?></textarea>
        <br><b></b><button type="submit">Upload cv</button>
    </form>
</div>