<?php

    function drawTable($rows = 10, $cols = 10, $min = 10, $max = 99){

        if($min > $max){
            $temp = $min;
            $min = $max;
            $max = $temp;
        }
        
        if($rows <= 0 || $cols <= 0){
            throw new Exception("Table Dimensions Can not be Negative Or Zero!");
        }
        echo "<table>";
        for($i = 0; $i < $rows; $i++){
            echo "<tr>";
            for($j = 0; $j < $cols; $j++){
                echo "<td>";
                echo rand($min, $max);
                echo "</td>";
            }
            echo "</tr>";
        }
        echo "</table>";
    }
?>