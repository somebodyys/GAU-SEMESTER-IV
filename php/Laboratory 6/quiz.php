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
        $currentFile = fopen('tests/'.$_GET['quiz'], 'r');
        $questions = explode("<->",fread($currentFile, filesize('tests/'.$_GET['quiz'])));

        // echo "<pre>";
        // print_r($questions);
        // echo "</pre>";
    ?>

    <form id="preview" action="final.php" method="POST">


        <?php
            $counter = 0;
            foreach ($questions as $question) {
                $splitedQuestion = explode("<>", $question)
        ?>

        <div class="question">
            <h3><?=$splitedQuestion[0]?></h3>
            <input type="hidden" name="choice<?=$counter?>" value="0" checked>
            <input type="radio" name="choice<?=$counter?>" value="1"> <?=$splitedQuestion[1]?> <br>
            <input type="radio" name="choice<?=$counter?>" value="2"> <?=$splitedQuestion[2]?> <br>
            <input type="radio" name="choice<?=$counter?>" value="3"> <?=$splitedQuestion[3]?>
            <input type="hidden" name="correct<?=$counter?>" value="<?=$splitedQuestion[4]?>">
        </div> 
            
        <?php $counter++; } ?>

        <button>Submit</button>
    </form>

</body>

</html>