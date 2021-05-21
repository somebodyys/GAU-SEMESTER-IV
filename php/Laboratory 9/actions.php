<?php
    require_once "db_connect.php";

    if(isset($_GET['page'])){
        echo file_get_contents("Components/".$_GET['page']);
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "upload"){

        $product_name = $_POST['product_name'];
        $product_price = $_POST['product_price'];
        $product_count = $_POST['product_count'];
        $product_description = $_POST['product_description'];
        $product_maker = $_POST['product_maker'];
        $myQuery = "
            INSERT INTO products(product_name, product_price, product_count, product_description, product_maker)
            VALUES ('$product_name', '$product_price', '$product_count', '$product_description', '$product_maker')
        ";

        if(mysqli_query($conn, $myQuery)){
            echo "Success!";
        }else{
            echo "Failed!";
        }
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "update"){

        $product_id = $_POST['product_id'];
        $product_name = $_POST['product_name'];
        $product_price = $_POST['product_price'];
        $product_count = $_POST['product_count'];
        $product_description = $_POST['product_description'];
        $product_maker = $_POST['product_maker'];
        $myQuery = "
            UPDATE products
            SET product_name = '$product_name', product_price='$product_price', product_count = '$product_count', product_description = '$product_description', product_maker = '$product_maker' 
            WHERE product_id = '$product_id'
        ";
        mysqli_query($conn, $myQuery);
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "products"){
        $productQuery = "
            SELECT * 
            FROM products
        ";
        $fromdb = mysqli_query($conn, $productQuery);

        $result = [];
        while($res = mysqli_fetch_assoc($fromdb)){
            array_push($result, $res);
        }
        echo json_encode($result);
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "delete"){
        $product_id = $_POST['product_id'];
        $delQuery = "
            DELETE FROM products
            WHERE product_id = '$product_id'
        ";
        mysqli_query($conn, $delQuery);
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "register"){
        $user_name = $_POST['user_name'];
        $user_email = $_POST['user_email'];
        $user_password = $_POST['user_password'];
        $reg_date = date("Y-m-d H:i:s");
        echo $user_name." ".$user_email." ".$user_password." ".$reg_date;
        $regQuery = "
            INSERT INTO users (user_name, user_email, user_password, reg_date)
            VALUES ('$user_name', '$user_email', '$user_email', '$reg_date')
        ";

        if(mysqli_query($conn, $regQuery)){
            echo "Success in Registration";
        }else{
            echo "Registration Failed";
        }

    }


?>