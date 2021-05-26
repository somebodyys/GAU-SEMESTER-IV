<?php 
        require_once "db_connect.php";
        if(isset($_POST['reason']) && $_POST['reason'] == "update"){

            $book_id = $_POST['book_id'];
            $select_query ="
                SELECT *
                FROM books
                WHERE book_id = '$book_id'
            ";

            $result = mysqli_fetch_assoc(mysqli_query($conn, $select_query));

            $book_name = $result['book_name'];
            $book_page = $result['book_page'];
            $book_price = $result['book_price'];
            $book_code = $result['book_code'];
            $book_author = $result['book_author'];
            
            $ret = "<div id='wrapper'>
            <input type='hidden' id='book_id' value='$book_id'>
            <input type='text' id='book_name' placeholder='Book Name' value='$book_name' required>
            <input type='text' id='book_page' value='$book_page'>
            <input type='text' id ='book_price' value='$book_price'>
            <input type='text' id='book_code' value='$book_code'>
            <input type='text' id='book_author' value='$book_author' required>
            <button onclick='updateBase()'>Update</button>
            </div>";

            echo $ret;

        }
    ?>