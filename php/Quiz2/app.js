function setPages(){
    $.ajax({
        type:'post',
        url:'actions.php',
        data: {
            reason: "getPages"
        },
        success: function(response){
            $('#book_page').val(response)
            $('#book_price').val(response*20);
        }
    });
}

function setContent(){
    $.ajax({
        type:'post',
        url:'actions.php',
        data: {
            reason: "getContent"
        },
        success: function(responce){
            var toDisplay = `<table><tr>`;
            Object.keys(JSON.parse(responce)[0]).forEach(
                key => toDisplay += `<th>${key}</th>`
            );
            toDisplay += `<th>Actions</th></tr>`;
            JSON.parse(responce).forEach(product => {
                toDisplay += `<tr>`;
                Object.values(product).forEach(
                    element => toDisplay += `<td>${element}</td>`
                );
                    
                toDisplay += `<td><button onclick="update(${product['book_id']})">edit</button> <button onclick="remove(${product['book_id']})">remove</button></td></tr>`;
            });
            toDisplay += `</table>`;
            $('#content').html(toDisplay);
        }
    });
}

function update(product_id){
    $.ajax({
        type:'post',
        url:'update.php',
        data: {
            reason: "update",
            book_id : product_id
        },
        success: function(response){
            $('#content').html(response);
        }
    });
}

function updateBase(){
    let book_id = $('#book_id').val();
    let book_name = $('#book_name').val();
    let book_page = $('#book_page').val();
    let book_price = $('#book_price').val();
    let book_code = $('#book_code').val();
    let book_author = $('#book_author').val();
    $.ajax({
        type:'post',
        url:'actions.php',
        data: {
            reason: "updateInfo",
            book_id: book_id,
            book_name : book_name,
            book_page : book_page,
            book_price : book_price,
            book_code : book_code,
            book_author : book_author
        },
        success: function(response){
            setContent();
        }
    });
}

function remove(product_id){
    $.ajax({
        type:'post',
        url:'actions.php',
        data: {
            reason: "del",
            book_id : product_id
        },
        success: function(response){
            setContent();
        }
    });
}

function setCode(){
    let result = "";
    for (let i = 0; i < 15; i++) {
        result += String.fromCharCode(Math.floor(Math.random() * (112 - 97 + 1)) + 97);
    }
    $("#book_code").val(result);
}

function sendToBase(){
    let book_name = $('#book_name').val();
    let book_page = $('#book_page').val();
    let book_price = $('#book_price').val();
    let book_code = $('#book_code').val();
    let book_author = $('#book_author').val();
    $.ajax({
        type:'post',
        url:'actions.php',
        data: {
            reason: "saveInfo",
            book_name : book_name,
            book_page : book_page,
            book_price : book_price,
            book_code : book_code,
            book_author : book_author
        },
        success: function(response){
            $('#response').html(response);
        }
    });
}

setCode();
setPages();
setContent();
