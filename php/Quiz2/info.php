<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js" integrity="sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=" crossorigin="anonymous"></script>
</head>
<body>

    <div id="wrapper">
        <input type="text" id="book_name" placeholder="Book Name" required>
        <input type="text" id="book_page">
        <input type="text" id ="book_price">
        <input type="text" id="book_code">
        <input type="text" id="book_author" required>
        <button onclick="sendToBase()">Upload</button>
        <span id="response"></span>
    </div>
    
    <script src="app.js"></script>
</body>
</html>