$(".addCard").click(function () {
    console.log(this.id);
    $.ajax({
        url: "/home/AddBasket?productId=" + this.id,
        type: "get",
        success: function (res) {
            console.log(res, this.id);
        }
    })
});
