<?php 

    $request_query = "
        SELECT *
        FROM users
    ";

    $res = mysqli_query($conn, $request_query);

    echo "<div class='userWrap'>";
    while($call = mysqli_fetch_assoc($res)){
        echo "<div class='user'>";
            $user_id = $call['Id'];
            foreach ($call as $key => $value) {
                echo "<div class='element'><div>$key</div> <div>$value</div></div>";
            }

            echo "<div class='ctr'>";
            echo "<form action='user_control.php' method='post'>";
            echo "<input type=hidden name='editing' value=$user_id></input>";
            echo "<button>Edit User</button>";
            echo "</form>";
            
            
            
            echo "<form method='post'>";
            echo "<input type=hidden name='del' value=$user_id></input>";
            echo "<button>Delete User</button>";
            echo "</form>";

            echo "</div>";
        echo "</div>";
    }
    echo "</div>"

?>