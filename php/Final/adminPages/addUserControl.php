<div id="addFormWrap">

    <?php 
        $action = "";
        $name = "";
        $password = "";
        $private_id = "";

        if (isset($_POST['name'])) {
            $name = $_POST['name'];
            $password = $_POST['password'];
            $private_id = $_POST['private_id'];
            if($name == "" || $password == "" || strlen($private_id)!=11){
                echo "Wrong Input";
            }else{
                $reg_date = date('Y-m-d');
                $insert_query = "
                    INSERT INTO aplicants (name, private_id, password, registered)
                    VALUES ('$name', '$private_id', '$password', '$reg_date')
                ";
    
                if(mysqli_query($conn, $insert_query)){
                    echo "Success";
                }else{
                    echo "failed";
                };
            }
        }
        

        if (isset($_GET['action']) && $_GET['action'] == "edit") {
            $id = $_GET['user'];
            $select_query = "
                SELECT * 
                FROM aplicants
                WHERE id='$id'
            ";

            $response = mysqli_query($conn, $select_query);
            $res = mysqli_fetch_assoc($response);

            $name = $res['name'];
            $password = $res['password'];
            $private_id = $res['private_id'];

            $action = "?role=admin&action=showList";

            
        }
    ?>

    <form action="<?=$action?>" method="post">
        <input type="hidden" name="id" value="<?=$id?>">
        <input type="text" name="name" placeholder="Name" value="<?=$name?>">
        <input type="password" name="password" placeholder="Password" value="<?=$password?>">
        <input type="text" name="private_id" placeholder="ID" value="<?=$private_id?>">
        <button>Register</button>
    </form>

</div>