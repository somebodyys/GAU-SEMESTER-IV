<h1>User Panel</h1>
<div id="userWrap">
    <form action="" method="post">
        <input type="text" name="username" id="" placeholder="username">
        <input type="password" name="password" placeholder="password" id="">
        <button type="submit">Log in</button>
    </form>

    <div class="wrap">
        <form action="" method="get">
            <input type="hidden" name="role" value="user">
            <input type="hidden" name="action" value="addcv">
            <button type="submit">Add CV</button>
        </form>
        <form action="" method="get">
            <input type="hidden" name="role" value="user">
            <input type="hidden" name="action" value="editcv">
            <button type="submit">Edit CV</button>
        </form>
    </div>

</div>
<?php

        if(isset($_GET['role']) && isset($_GET['action'])){
            switch ($_GET['action']) {
                case 'addcv':
                    include "addcv.php";
                    break;
                case 'editcv':
                    include "addcv.php";
                    break;
                case 'changeCv':
                    include "addcv.php";
                    break;
                default:
                    # code...
                    break;
            }
        }
    
    ?>