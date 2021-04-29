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
        $reg_date = date("Y-m-d");
        if(isset($_GET['action']) && $_GET['action'] == "addUser" && isset($_POST['Name'])){
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
    
    ?>

    <h1>User Control!</h1>
    <form action="?action=addUser" method="post" id="userEditor">
        <input type="text" name="Name" placeholder="First Name" required>
        <input type="text" name="Lastname" placeholder="Last Name" required>
        <input type="number" name="Age" placeholder="Age" required>
        <input type="date" name="Date" required>
        <input type="password" name="Password" placeholder="PassWord" required>


        <div id="sub">
            <select name="Gender" required>
                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>
            <button>Add User</button>
        </div>
        
    </form>

    <div id="result">
        <div class="error"><?=$error?></div>
    </div>
</body>

</html>