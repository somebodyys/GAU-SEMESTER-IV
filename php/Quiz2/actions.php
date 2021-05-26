<?php
    require_once "db_connect.php";

    function validateName($name){
        return strlen($name) >= 2 && strlen($name) <= 100;
    }

    function validateAuthor($author){
        return strlen($author) >= 5 && strlen($author) <= 50;
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "getPages"){
        echo rand(50, 1000);
    }
    if(isset($_POST['reason']) && $_POST['reason'] == "updateInfo"){
        $book_id = $_POST['book_id'];
        $book_name = $_POST['book_name'];
        $book_page = $_POST['book_page'];
        $book_price = $_POST['book_price'];
        $book_code = $_POST['book_code'];
        $book_author = $_POST['book_author'];

        $update_query = "
            UPDATE books
            SET book_name='$book_name', book_page='$book_page', book_price='$book_price', book_code='$book_code', book_author='$book_author'
            WHERE book_id='$book_id'
        ";

        mysqli_query($conn, $update_query);
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "saveInfo"){
        $book_name = $_POST['book_name'];
        $book_page = $_POST['book_page'];
        $book_price = $_POST['book_price'];
        $book_code = $_POST['book_code'];
        $book_author = $_POST['book_author'];
        $insert_query = "
            INSERT INTO books (book_name, book_page, book_price, book_code, book_author)
            VALUES ('$book_name', '$book_page', '$book_price', '$book_code', '$book_author')
        ";

        if(validateName($book_name) && validateAuthor($book_author)){
            if(mysqli_query($conn, $insert_query)){
                echo "Sucess";
            }else{
                echo "Error While Saving In Database!";
            }
        }else{
            echo "Wrong Name Or Author";
        }
    }

    if(isset($_POST['reason']) && $_POST['reason'] == "getContent"){
    

        $request_query = "
            SELECT *
            FROM books
        ";

        $response = mysqli_query($conn, $request_query);

        $result = [];
        while($res = mysqli_fetch_assoc($response)){
            array_push($result, $res);
        }

        $temp = [];
        $indexes = [];
        while (true) { 
            $randIndex = rand(0, sizeof($result)-1);
            if(!in_array($randIndex, $indexes)){
                array_push($indexes, $randIndex);
            }
            if(count($indexes) == 5){
                break;
            }
        }
        foreach ($indexes as $value) {
            array_push($temp, $result[$value]);
        }  
        echo json_encode($temp);
    }
    
    if(isset($_POST['reason']) && $_POST['reason'] == "del"){
        $book_id = $_POST['book_id'];
        $delQuery = "
            DELETE FROM books
            WHERE book_id = '$book_id'
        ";

        mysqli_query($conn, $delQuery);
    }
?>