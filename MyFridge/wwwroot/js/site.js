// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// jQuery за изтриване на продукт от списъка

//Adding product in ShoppingList from Market
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

//Adding product in MyFridge from ShoppingList
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

$(document).on("click", ".add-to-shopping-list", function () {
    var button = $(this);
    var productName = button.data("product");

    console.log("Добавяне в списъка за пазаруване:", productName);

    $.ajax({
        url: "/ShoppingList/AddProductInShoppingList",
        type: "GET",
        data: { productName: productName },
        success: function () {
            console.log("Продуктът е добавен в шопинг листа!");

            // Променяме бутона, за да покажем, че продуктът е добавен
            button.removeClass("btn-warning").addClass("btn-success").text("Добавено ✓");
            button.prop("disabled", true); // Деактивираме бутона
        },
        error: function (xhr) {
            console.error("Грешка при добавяне в шопинг листа:", xhr.responseText);
        }
    });
});

