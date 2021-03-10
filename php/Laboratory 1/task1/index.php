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
        <form action="callBack.php">
            <input type="text" name="fname" placeholder="სახელი">
            <input type="text" name="lname" placeholder="გვარი">
            <input type="text" name="position" placeholder="დაკავებული თანამდებობა">
            <input type="number" id="sal" name="salary" placeholder="ხელფასის რაოდენობა">
            <input type="number" name="tax" value="20"  id="tax" placeholder="დაკავებული საშემოსავლო">
            <button type="submit">გაგზავნა</button>
        </form>
    </div>

    <!-- <script>
        document.getElementById("tax").addEventListener('keyup', function(){
            if(this.value > 0 && this.value <= 100){
                var sal = document.getElementById("sal").value;
                document.getElementById("res").value = sal - (sal * this.value)/100;
            }
        })
    </script> -->

</body>

</html>