<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GET</title>
    <style>
        .wrapper{
            margin: auto;
            box-shadow: 0px 0px 15px gray;
            width: 200px;
            padding: 15px;
            border-radius: 25px;
            margin-top: 25px;
            display: flex;
            align-items: center;
            justify-content: center;
            flex-direction: column;
            
        }
        .wrapper form{
            display: flex;
            align-items: center;
            justify-content: space-around;
            flex-direction: column;
            width: 250px;
            height: 100px;   
        }

        .wrapper input{
            width: 80%;
            height: 25px;
            border-radius: 15px;
            border: dashed 1px greenyellow;
            text-align: center;
        }

        .wrapper button{
            width: 50%;
            height: 15px;
            border-radius: 15px;
            border: 1px solid orangered;
            height: 25px;
        }

        .wrapper button:hover{
            background-color: greenyellow;
            cursor: pointer;
        }
    </style>
</head>

<body>
    <div class="wrapper">
        <h3>GET</h3>
        <form action="worker.php">
            <input type="text" name="user" placeholder="User">
            <input type="password" name="password" placeholder="Password">
            <button type="submit">Send</button>
        </form>
    </div>
    <hr>
    <div class="wrapper">
        <h3>POST</h3>
        <form action="worker.php">
            <input type="text" name="user" placeholder="User">
            <input type="password" name="password" placeholder="Password">
            <button type="submit">Send</button>
        </form>
    </div>

</body>

</html>