<?php require_once "db_connect.php"; ?>
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
        $error = "";
        $action = "?action=addUser";
        $button_text = "Add User";

        $first_name = "";
        $last_name = "";
        $user_age = "";
        $birth = "";
        $user_pass = "";
        $sex = "";

        $user_id = "";

        $isMale = "selected";
        $isFem = "";
        

        if(isset($_GET['action']) && $_GET['action'] == "addUser" && isset($_POST['Name'])){
            
            $reg_date = date("Y-m-d");
            $fname = $_POST['Name'];
            $lname = $_POST['Lastname'];
            $age = $_POST['Age'];
            $date = $_POST['Date'];
            $password = $_POST['Password'];
            $gender = $_POST['Gender'];
            $user_query = "
                INSERT INTO users(Name, Lastname, Age, Date, Red_Date, Password, Gender)
                VALUES ('$fname', '$lname', '$age', '$date', '$reg_date', '$password', '$gender')
            ";
            if(mysqli_query($conn, $user_query)) header("Location: user_control.php");
            $error = mysqli_error($conn);
        }
        
        if(isset($_GET['action']) && $_GET['action'] == "updateUser"){
            $fname = $_POST['Name'];
            $lname = $_POST['Lastname'];
            $age = $_POST['Age'];
            $date = $_POST['Date'];
            $password = $_POST['Password'];
            $gender = $_POST['Gender'];
            $identification = $_POST['user_id'];

            $update_query = "
                UPDATE users
                SET Name='$fname', Lastname='$lname', Age='$age', Date='$date', Password='$password', Gender='$gender'
                WHERE Id='$identification';
            ";

            if(mysqli_query($conn, $update_query)){
                header("location: data_editing.php");
            }else{
                echo "Error While Updating";
            }

        }

        if(isset($_POST['editing'])){
            $action = "?action=updateUser";
            $button_text = "Update User";
            $edit_id = $_POST['editing'];
            $get_query = "
                SELECT Id, Name, Lastname, Age, Date, Password, Gender
                FROM users
                WHERE Id = '$edit_id';
            ";

            $current_user = mysqli_fetch_assoc(mysqli_query($conn, $get_query));

            $user_id = $current_user['Id'];
            $first_name = $current_user['Name'];
            $last_name = $current_user['Lastname'];
            $user_age = $current_user['Age'];
            $birth = $current_user['Date'];
            $user_pass = $current_user['Password'];
            $sex = $current_user['Gender'];
            $isMale = $sex == "Male" ? "selected" : "";
            $isFem = $sex == "Female" ? "selected" : ""; 
        }
    
    ?>

    <h1>User Control!</h1>
    <form action="<?=$action?>" method="post" id="userEditor">
        <input type="text" name="Name" value="<?=$first_name?>" placeholder="First Name" required>
        <input type="text" name="Lastname" value="<?=$last_name?>" placeholder="Last Name" required>
        <input type="number" name="Age" value="<?=$user_age?>" placeholder="Age" required>
        <input type="date" name="Date" value="<?=$birth?>" required>
        <input type="hidden" name="user_id" value="<?=$user_id?>">
        <input type="password" name="Password" value="<?=$user_pass?>" placeholder="PassWord" required>


        <div id="sub">
            <select name="Gender" required>
                <option value="Male" <?=$isMale?>>Male</option>
                <option value="Female" <?=$isFem?>>Female</option>
            </select>
            <button><?=$button_text?></button>
        </div>
        
    </form>

    <div id="result">
        <div class="error"><?=$error?></div>
    </div>
</body>

</html>