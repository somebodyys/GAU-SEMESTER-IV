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
                        SELECT Age, Date, Red_Date, Gender
                        FROM users
                        LIMIT 3
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
                        FROM users
                        LIMIT 2
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
                        FROM users
                        WHERE Id > 1 AND Id < 4
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
                        FROM users
                        WHERE Id < 2 OR Id >= 4
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
                        FROM users
                        WHERE Date = '2014-07-04'
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
                        FROM users
                        WHERE Date > '2014-07-04'
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
                        FROM users
                        WHERE Date > '2014-06-04' AND Date < '2030-07-04'
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
                        FROM users
                        WHERE Age >= 10 AND Age <= 22
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