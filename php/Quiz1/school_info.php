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
        include "verifications.php";

        $user_values = [
            'name_value' => "",
            'master_value' => "",
            'date_value' => date("Y-m-d", mktime(0,0,0,01,01,1800)),
            'code_value' => "",
            'adreess_value' => "",
            'registration_value' => date('m/d/Y'),
            'phone_value' => "",
            'more_value' => ""
        ];
        $error_list = [
            'name_error' => "",
            'master_error' => "",
            'code_error' => "",
            'date_error' => "",
            'phone_error' => "",
            'adress_error' => ""
        ];

        $myAction = "";

        if (isset($_POST['sub'])) {
            $user_values = set($user_values, array_keys($user_values), [
                $_POST['school_name'],
                $_POST['headmaster'],
                $_POST['build'],
                $_POST['code'],
                $_POST['adress'],
                $_POST['registration'],
                $_POST['phone'],
                $_POST['more']

            ]);
            $error_list['name_error'] = validate_name($user_values['name_value']);
            $error_list['master_error'] = validate_master($user_values['master_value']);
            $error_list['code_error'] = validate_code($user_values['code_value']);
            $error_list['adress_error'] = validate_adress($user_values['adreess_value']);
            $error_list['phone_error'] = validate_phone($user_values['phone_value']);
        }

        $error_count = 0;
        foreach ($error_list as $value) {
            if($value != "") $error_count++;
        }

        if($error_count == 1){
            $myAction = "action.php";
        }
    
    ?>


    <form action="<?=$myAction?>" method="post">

        <div class="inner">
            <input type="text" value="<?=$user_values['name_value']?>" name="school_name" placeholder="სკოლის სახელი">
            <div class="error"><?=$error_list['name_error']?></div>
        </div>
        <div class="inner">
            <input type="text" value="<?=$user_values['master_value']?>" name="headmaster" placeholder="დირექტორის სახელი, გვარი">
            <div class="error"><?=$error_list['master_error']?></div>
        </div>
        <div class="inner">
            <input type="date" value="<?=$user_values['date_value']?>" name="build" placeholder="სკოლის დაარსების თარიღი">
            <div class="error"><?=$error_list['date_error']?></div>
        </div>
        <div class="inner">
            <input type="number" value="<?=$user_values['code_value']?>" name="code" placeholder="საიდენთიფიკაციო კოდი">
            <div class="error"><?=$error_list['code_error']?></div>
        </div>
        <div class="inner">
            <input type="text" value="<?=$user_values['adreess_value']?>" name="adress" placeholder="მისამართი">
            <div class="error"><?=$error_list['adress_error']?></div>
        </div>
        <input type="hidden" value="<?=$user_values['registration_value']?>" name="registration">
        <div class="inner">
            <input type="text" value="<?=$user_values['phone_value']?>" name="phone" placeholder="საკონთაქტო ტელეფონი">
            <div class="error"><?=$error_list['phone_error']?></div>
        </div>
        <div class="inner">
            <textarea name="more" id="" cols="60" rows="10"><?=$user_values['more_value']?></textarea>
        </div>
        <button type="submit" name="sub">Submit</button>
    </form>





    
</body>
</html>