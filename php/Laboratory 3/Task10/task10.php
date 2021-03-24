<?php

function check_url(){
    $full_url = "$_SERVER[HTTP_HOST]$_SERVER[REQUEST_URI]";
    return preg_match('~[0-9]~', $full_url);
}

echo check_url();