// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// jQuery за изтриване на продукт от списъка
$(document).ready(function () {
    $(".delete-product").click(function () {
        var button = $(this);
        var productId = button.data("id");

        $.ajax({
            url: "/ShoppingList/DeleteProductInShoppingList",
            type: "POST",
            data: { productId: productId.toString() },
            success: function () {
                button.closest("li").fadeOut(500, function () { $(this).remove(); });
            },
            error: function (xhr) {
                alert("Грешка при изтриване на продукта. " + xhr.responseText);
            }
        });
    });
});

$(document).on("click", ".add-to-fridge", function () {
    var button = $(this);
    var productId = button.data("id");

    console.log("Добавяне в хладилника, ID:", productId);

    // Първа заявка: Добавяне в хладилника
    $.ajax({
        url: "/MyFridge/AddProductInFridge",
        type: "POST",
        data: { productId: productId.toString() },
        success: function () {
            console.log("Продуктът е добавен в хладилника!");

            // Втора заявка: Изтриване от шопинг листа
            $.ajax({
                url: "/ShoppingList/DeleteProductInShoppingList",
                type: "POST",
                data: { productId: productId.toString() },
                success: function () {
                    console.log("Продуктът е премахнат от шопинг листа.");
                    button.closest("li").fadeOut(500, function () { $(this).remove(); });

                    // Проверяваме дали списъкът е празен и показваме съобщение
                    if ($("#shoppingList li").length === 0) {
                        $("#shoppingList").hide();
                        $("#emptyMessage").show();
                    }
                },
                error: function (xhr) {
                    console.error("Грешка при изтриване от шопинг листа:", xhr.responseText);
                }
            });
        },
        error: function (xhr) {
            console.error("Грешка при добавяне в хладилника:", xhr.responseText);
        }
    });
});


