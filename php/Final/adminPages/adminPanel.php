<div>
    <h1>Admin Panel</h1>

    <div class="wrap">
        <form action="" method="get">
            <input type="hidden" name="role" value="admin">
            <input type="hidden" name="action" value="add">
            <button type="submit">Add User</button>
        </form>
        <form action="" method="get">
            <input type="hidden" name="role" value="admin">
            <input type="hidden" name="action" value="showList">
            <button type="submit">User List</button>
        </form>
    </div>
    

    <?php
    if (isset($_GET['action'])) {
        switch ($_GET['action']) {
            case 'add':
                include "addUserControl.php";
                break;
            case 'showList':
                include "userList.php";
                break;
            case 'edit':
                include "addUserControl.php";
                break;
            default:
                echo "No Action Found";
                break;
        }
    }

    ?>
</div>