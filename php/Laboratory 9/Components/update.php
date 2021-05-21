<?php
    require_once "../db_connect.php";
    if(isset($_POST['reason']) && $_POST['reason'] == "update"){
        $product_id = $_POST['product_id'];
        $myQue = "
            SELECT *
            FROM products
            WHERE product_id = '$product_id'
        ";

        $respose = mysqli_fetch_assoc(mysqli_query($conn, $myQue));
        $product_name = $respose['product_name'];
        $product_price = $respose['product_price'];
        $product_count = $respose['product_count'];
        $product_descriprion = $respose['product_description'];
        $product_maker = $respose['product_maker'];

        $result = "
        <div id='addWrap'>
            <input type='hidden' id='id' value='$product_id' required>
            <input type='text' id='prname' value='$product_name' required>
            <input type='number' id='prprice' value='$product_price' required>
            <input type='number' id='prcount' value='$product_count' required>
            <textarea id='prdes' cols='30' rows='10' required>$product_descriprion</textarea>
            <input type='text' id='prmaker' value='$product_maker' required>
            <button onclick='updateProduct()'>Update Product</button>
            <span id='addResponse'></span>
        </div>
        ";
        echo $result;
    }

?>