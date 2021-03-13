<?php

    function set($collection, $key_array, $value_array){
        for($i = 0; $i < sizeof($key_array); $i++){
            $collection[$key_array[$i]] = $value_array[$i];
        }
        return $collection;
    }

    function validate_name($input){
        if($input == ""){return "Name field can't be empty!";}
        if(preg_match('~[0-9]~', $input)){return "Numbers aren't allowed in name!";}
    }

    function validate_email($input){
        if($input == ""){return "Email field can't be empty!";}
        if(!preg_match('~@gmail.com~', $input)){return "Email doesn't match pattern!";}
    }

    function validate_gender($input){
        if(!$input){return "Gender field is requred!";}
    }

    function error_check($error_list){
        foreach($error_list as $error){
            if($error != ""){return true;}
        }
        return false;
    }


?>