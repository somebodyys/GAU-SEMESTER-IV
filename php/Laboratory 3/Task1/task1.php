<?php

    function drawTable($rows = 10, $cols = 10, $min = 10, $max = 99){
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
    drawTable();
?>