<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table{
            
            margin: auto;
            border-collapse: collapse;
        }

        td, th{
            border: solid 1px black;
            width: 85px;
            height: 85px;
            text-align: center;
        }
        #in{
            text-align: center;
            margin: 25px;
        }

        #mult{
            text-align: center;
            margin-top: 25px;
        }
        h1{
            text-align: center;
        }
    </style>
</head>

<body>
    
    <h1>Task 2</h1>

    <table>
        <?php
            $matrix = [];
            $matrix_data = [
                'sum' => 0,
                'mult' => 1
            ];

            for($row = 0; $row < 4; $row++){

        ?>
            <tr>
            <?php
            for($col = 0; $col < 4; $col++){
                $matrix[$row][$col] = rand(10, 100);
                $matrix_data['sum'] += $matrix[$row][$col];
                $matrix_data['mult'] *= $matrix[$row][$col];
            ?> 
            <td><?=$matrix[$row][$col]?></td>

            <?php
                }
            ?>
            </tr>
        <?php
            }
        ?>
    </table>
    <br><br><br>
    <table>
        <?php
            for($row = 0; $row < 4; $row++){
        ?> 
            <tr>
                <?php
                    for($col = 0; $col < 4; $col++){
                ?>
                    <?php
                        if($col >= $row){
                    ?>
                        <td><?=$matrix[$row][$col]?></td>
                    <?php
                    }else{
                    ?>
                        <td></td>

                    <?php
                    }
                    ?>
                
                <?php
                }
                ?>
                
            </tr>
        <?php
        }
        ?>
    </table>
    <div id="in">
        <form method="post">
            <input type="number" name="check_num" placeholder="Check Number">
            <button type="submit">Get</button>
        </form>
    </div>
    <?php
        if(isset($_POST['check_num']) && $_POST['check_num'] != ""){
    ?>
        <div id="mult">
            Mult {<?=$_POST['check_num']?>}:
            <?php
                foreach($matrix as $row){
                    foreach($row as $item){
                        if($item % $_POST['check_num'] == 0){
                            echo $item." ";
                        }
                    }
                }  
            ?>
        </div>
        
    <?php
    }?>
    <br><br><br>
    <table>
        <?php
            foreach($matrix_data as $key => $val){
        ?>
            <tr>
                <th><?=$key?></th>
                <td><?=$val?></td>
            </tr>
        <?php
        }?>
        <tr>
            <th>mean</th>
            <td><?=$matrix_data['sum']/16?></td>
        </tr>
    </table>

    <br><br><br>

    <table>
        <tr>
            <th>Number</th>
            <th>Sum</th>
        </tr>
        <?php
            foreach($matrix as $row){
                foreach($row as $item){
                ?>
                <tr>
                    <td><?=$item?></td>
                    <?php
                        $sum = 0;
                        while($item){
                            $sum += $item%10;
                            $item /= 10;
                        }
                    ?>
                    <td><?=$sum?></td>
                </tr>

                <?php
                }
            }
        ?>
    
    
    </table>
    

</body>

</html>