function update(element) {
    var quantity = $('#' + element + '-quantity').val();

    if (isNormalInteger(quantity) === false) {
        alert("Quantity must bigger then 0!");
        location.reload();
    } else {
        $.post({
            url: '/Order/UpdateCart/',
            data: { pId: element, pQuantity: quantity },
            success: function () {
                location.reload();
            }
        });
        return false;
    }
}

function isNormalInteger(str) {
    var n = Math.floor(Number(str));
    return n !== Infinity && String(n) === str && n > 0;
}

function removeItemFromCart(productId) {
    if (confirm('Do you want to remove this item?')) {
        $.ajax({
            type: 'POST',
            url: '/Cart/RemoveFromCart/',
            data: { pId: productId }
        })
            .done(function (msg) {
                location.reload();
            });
    }
}