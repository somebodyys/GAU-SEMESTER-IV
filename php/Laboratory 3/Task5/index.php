<?php

    function digit_count($num){
        $result = 0;
        while($num){
            $num = floor($num / 10);
            $result++;
        }
        return $result;
    }
?>