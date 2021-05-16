<?php

    if(isset($_POST['del'])){
        $del_id = $_POST['del'];
        $del_query = "
            DELETE FROM users
            WHERE Id='$del_id'
        ";

        mysqli_query($conn, $del_query);
    }

?>