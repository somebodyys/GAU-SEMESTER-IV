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

    <?php include "program.php" ?>

    <div id="wrapper">
        <form id="uploadForm" action="" method="post" enctype="multipart/form-data">
            <input type="file" name="myQuiz" required>
            <button type="submit" name="sub">Upload</button>
        </form>

        <div class="error"><?=$error?></div>
        <table>
            <tr>
                <th>Quiz Name</th>
                <th>Quiz Link</th>
                <th>Remove Quiz</th>
            </tr>

            <?php
                $myTests = scandir("tests");
                for ($i=2; $i < count($myTests); $i++) { 
                    $file = $myTests[$i];
                    echo 
                    "<tr>
                        <td>$file</td>
                        <td><a href='quiz.php?quiz=$file'>start</a></td>
                        <td>
                            <form method='post'>
                                <input type='hidden' name='del' value='$file'>
                                <button>remove</button>
                            </form>
                        
                        </td>
                    </tr>";
                }
            ?>
    
        </table>

    </div>
    



</body>

</html>