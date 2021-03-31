<?php

    function set($collection, $key_array, $value_array){
        for($i = 0; $i < sizeof($key_array); $i++){
            $collection[$key_array[$i]] = $value_array[$i];
        }
        return $collection;
    }
    function validate_name($input){
        if($input == "") return "ცარიელი არ დაიშვება";
        if(strlen($input) < 2 || strlen($input) > 20) return "მინიმუმ 2 სიმბოლო, მაქსიმუმ 20";
        if(!preg_match('~[0-9]~', $input)) return "უნდა შეიცავდეს ერთ ციფრს მაინც";
    }

    function validate_master($input){
        if($input == "") return "ცარიელი არ დაიშვება";
        if(strlen($input) < 5 || strlen($input) > 50) return "მინიმუმ 5 სიმბოლო, მაქსიმუმ 50";
    }

    function validate_code($input){
        if(strlen($input) != 9) return "კოდი უნდა იყოს 9 სიმბოლოსგან შემდგარი";
    }

    function validate_adress($input){
        if(strlen($input) > 70) return "მისამართუ უნდა იყოს მაქ 70 სიმბოლო";
    }

    function validate_phone($input){
        if($input == "") return "ცარიელი არ დაიშვება";
    }


?>