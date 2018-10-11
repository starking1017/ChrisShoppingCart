$(document).ready(function () {
    $('[data-confirm]').click(function (e) {
        if (!confirm(jQuery(this).attr("data-confirm"))) {
            e.preventDefault();
        }
    });
});

function ShowSnackber() {
    // Get the snackbar DIV
    var x = document.getElementById("snackbar");
    // Add the "show" class to DIV
    x.className = "show";
    // After 3 seconds, remove the show class from DIV
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}

//add productId
function AddToCart(productId) {
    $.ajax({
        type: 'POST',
        url: '/Cart/AddToCart/',
        data: { pId: productId }
    })
        .done(function (msg) {
            $('li#Cart').html(msg);

            ShowSnackber();
        });
}


function RemoveFromCart(productId) {
    if (confirm('Do you want to delete this item?')) {
        $.ajax({
            type: 'POST',
            url: '/Cart/RemoveFromCart/',
            data: { pId: productId }
        })
            .done(function (msg) {
                $('li#Cart').html(msg);
            });
    }
}

function ClearCart() {
    if (confirm('Do you really want to delete all items from cart?')) {
        $.ajax({
            type: 'POST',
            url: '/Cart/ClearCart/',
            data: {}
        })
            .done(function (msg) {
                $('li#Cart').html(msg);
            });
    }
}