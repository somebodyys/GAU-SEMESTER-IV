<?php require_once "db_connect.php"; ?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <ol>
        <li>
            <ul>
                <?php
                $queryOne = "
                        SELECT *
                        FROM data
                        WHERE Id <= 7 AND Type = 2
                    ";
                $callBack = mysqli_query($conn, $queryOne);

                while ($res = mysqli_fetch_assoc($callBack)) {
                    echo "<li>";
                    foreach ($res as $value) {
                        echo $value . "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                    }
                    echo "</li>";
                }
                ?>
            </ul>

        </li>

        <li>
            <ul>
                <?php
                $queryOne = "
                        SELECT *
                        FROM data
                        ORDER BY Id DESC
                        LIMIT 5
                    ";
                $callBack = mysqli_query($conn, $queryOne);

                while ($res = mysqli_fetch_assoc($callBack)) {
                    echo "<li>";
                    foreach ($res as $value) {
                        echo $value . "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                    }
                    echo "</li>";
                }
                ?>
            </ul>

        </li>

        <li>
            <ul>
                <?php
                $queryOne = "
                        SELECT *
                        FROM data
                        ORDER BY Id DESC
                        LIMIT 10
                    ";
                $callBack = mysqli_query($conn, $queryOne);

                while ($res = mysqli_fetch_assoc($callBack)) {
                    echo "<li>";
                    foreach ($res as $value) {
                        echo $value . "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                    }
                    echo "</li>";
                }
                ?>
            </ul>

        </li>

        <li>
            <ul>
                <?php
                $queryOne = "
                        SELECT *
                        FROM data
                        WHERE MOD(Id, 2) = 0
                    ";
                $callBack = mysqli_query($conn, $queryOne);

                while ($res = mysqli_fetch_assoc($callBack)) {
                    echo "<li>";
                    foreach ($res as $value) {
                        echo $value . "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp";
                    }
                    echo "</li>";
                }
                ?>
            </ul>
        </li>
    </ol>
</body>

</html>