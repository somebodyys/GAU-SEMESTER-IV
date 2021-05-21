
function getContent(pageName){
    $.ajax({
        type:'get',
        url:'actions.php',
        data: {
            page: pageName
        },
        success: function(data){
            $('#content').html(data);
        }
    });
}

function getPosts(){

    $.ajax({
        type:"post",
        url:"actions.php",
        data:{
            reason : "products"
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
                    
                toDisplay += `<td><button onclick="update(${product['product_id']})">edit</button> <button onclick="remove(${product['product_id']})">remove</button></td></tr>`;
            });
            toDisplay += `</table>`;

            $('#postWrap').html(toDisplay);
        }
    })
}

function update(id){
    $.ajax({
        type:"post",
        url: "Components/update.php",
        data: {
            reason: "update",
            product_id : id
        },
        success: function(responce){
            $('#content').html(responce);
        }
        
    })
}


function remove(id){
    
    $.ajax({
        type: "post",
        url: "actions.php",
        data: {
            reason: "delete",
            product_id : id 
        },
        success: function(){
            getPosts();
        }
    })
}

function updateProduct(){
    var id = $('#id').val();
    var name = $('#prname').val();
    var price = $('#prprice').val();
    var count = $('#prcount').val();
    var desc = $('#prdes').val();
    var maker = $('#prmaker').val();

    if(name != ""){
        $.ajax({
            type:"post",
            url:"actions.php",
            data: {
                reason:"update",
                product_id: id,
                product_name: name,
                product_price: price,
                product_count: count,
                product_description: desc,
                product_maker: maker
            },
            success: function(responce){
                getContent('posts.php');
            }
        });
    }
}


function uploadProduct(){
    var name = $('#prname').val();
    var price = $('#prprice').val();
    var count = $('#prcount').val();
    var desc = $('#prdes').val();
    var maker = $('#prmaker').val();

    if(name != ""){
        $.ajax({
            type:"post",
            url:"actions.php",
            data: {
                reason:"upload",
                product_name: name,
                product_price: price,
                product_count: count,
                product_description: desc,
                product_maker: maker
            },
            success: function(responce){
                $("#addResponse").html(responce);
            }
        });
    } else{
        $('#addResponse').html("Name Can not be empty!");
    }
}

getContent("posts.php");