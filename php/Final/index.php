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
    <?php require_once "db_connect.php"; ?>

    <header>
        <nav>
            <form method="get">
                <input type="hidden" name="role" value="admin">
                <button type="submit">Admin</button>
            </form>
            <form action="" method="get">
                <input type="hidden" name="role" value="user">
                <button type="submit">User</button>
            </form>
        </nav>
    </header>

    <div class="contWrap">
        <?php 
            if(isset($_GET['role'])){
                switch ($_GET['role']) {
                    case 'admin':
                        include "adminPages/adminPanel.php";
                        break;
                    
                    case "user":
                        include "userPages/userPanel.php";
                        break;
                    default:
                        echo "<h1>No Page found!</h1>";
                        break;
                }
                
            }
        ?>
    </div>
    
    <footer>
    </footer>

</body>

</html>