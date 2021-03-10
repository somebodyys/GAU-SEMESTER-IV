<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        .wrapper{
            width: 500px;
            min-height: 50px;
            padding: 25px;
            box-shadow: 5px 5px 15px gray;
            margin: auto;
            border-radius: 25px;
            margin-top: 50px;
            display: flex;
            align-items: center;
            justify-content: space-around;
        }
        h3{
            margin: 15px;
        }

        input{
            margin-bottom: 15px;
        }
        form{
            text-align: center;
        }
    </style>
</head>

<body>
<div class="wrapper">
        <h3>უწყისი</h3>
        <form method="POST">
            <input type="text" name="fname" placeholder="სტუდენტის სახელი">
            <input type="text" name="lname" placeholder="გვარი">
            <input type="text" name="position" placeholder="კურსი">
            <input type="number" id="sal" name="salary" placeholder="სემესტრი">
            <input type="number" name="tax" value="20"  id="tax" placeholder="სასწავლო კურსი">
            <button type="submit">გაგზავნა</button>
        </form>
    </div>

</body>

</html>