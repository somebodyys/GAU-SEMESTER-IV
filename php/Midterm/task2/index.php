<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        #error {
            color: red;
            font-style: italic;
            margin: auto;text-align: center;
        }

        form {
            margin: auto;
            display: flex;
            align-items: center;
            justify-content: space-around;
            padding: 30px;
            width: 500px;
        }
    </style>
</head>

<body>
    <?php

    function validateInput($eng, $geo)
    {
        if (empty($eng) || empty($geo)) return "Empy values not accepted!";
        if (strlen($eng) < 2 || strlen($eng) > 50) return "English word size 2 - 50 interval";
        return "";
    }
    if (!is_dir("storage")) mkdir("storage");
    if (!in_array("lexicon.txt", scandir("storage"))) fopen("storage/lexicon.txt", "w");

    $engVal = "";
    $geoVal = "";
    $error = "";

    if (isset($_POST['eng'])) {
        $engVal = $_POST['eng'];
        $geoVal = $_POST['geo'];
        $error = validateInput($_POST['eng'], $_POST['geo']);
        if (empty($error)) {
            $file = fopen("storage/lexicon.txt", "a");
            fwrite($file, "" . $engVal . " - " . $geoVal . "\n");
            fclose($file);
        }
    }
    ?>


    <form method="post">
        <input type="text" name="eng" placeholder="In English" value="<?= $engVal ?>">
        <input type="text" name="geo" placeholder="In Georgian" value="<?= $geoVal ?>">
        <button>Save</button>

    </form>
    <div id="error">
        <?= $error ?>
    </div>




</body>

</html>