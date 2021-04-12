<?php
    $notify = "";
    $files = scandir("storage");
    if(count($files) == 2) $notify = "There Are no Uploades To show!";
    

    for($i = 2; $i < count($files); $i++){
        $fileName = $files[$i];
        echo 
        "<div class='item'>
            <span>$fileName</span>
            <div class='actions'>
                <a href='storage/$fileName' download>download</a>
                <form method='post'>
                    <input type='hidden' name='del' value='$fileName'>
                    <button>remove</button>
                </form>
            </div>
        </div>";
    }
?>

<div class="message"><?=$notify?></div>




