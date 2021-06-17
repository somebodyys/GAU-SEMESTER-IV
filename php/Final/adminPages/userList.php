<table>
    <tr>
        <th>name</th>
        <th>Private Id</th>
        <th>Password</th>
        <th>Registration Date</th>
        <th>Actions</th>
        
    </tr>


    <?php

        if(isset($_POST['name'])){
            $id = $_POST['id'];
            $name = $_POST['name'];
            $pr_id = $_POST['private_id'];
            $password = $_POST['password'];
            $update_query = "
                UPDATE aplicants
                SET name='$name', private_id='$pr_id', password='$password'
                WHERE id='$id'
            ";

            mysqli_query($conn, $update_query);
        }

        if (isset($_POST['del'])) {
            $id = $_POST['del'];
            $del_query = "
                DELETE FROM aplicants
                WHERE id='$id'
            ";

            mysqli_query($conn, $del_query);
        }

    
        $users_query = "
            SELECT * 
            FROM aplicants
        ";

        $response = mysqli_query($conn, $users_query);

        while($res = mysqli_fetch_assoc($response)){
            $id = $res['id'];
            echo "<tr>";
                echo "<td>";
                echo $res['name'];
                echo "</td><td>";
                echo $res['private_id'];
                echo "</td><td>";
                echo $res['password'];
                echo "</td><td>";
                echo $res['registered'];
                echo "</td><td>";
                echo "<a href='?role=admin&action=edit&user=$id'>Edit</a>";
                echo 
                "<form  method='post'>
                    <input type='hidden' name='del' value='$id'>
                    <button type='submit'>Delete</button>
                </form>";
            echo "</td></tr>";
        }
    
    ?>
</table>