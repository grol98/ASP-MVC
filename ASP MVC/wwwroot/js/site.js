// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ShowOrder(orderId) {
    $('#show_order_number').val($(`#Number${orderId}`).html());
    $('#show_order_senders_city').val($(`#SendersCity${orderId}`).html());
    $('#show_order_senders_address').val($(`#SendersAddress${orderId}`).html());
    $('#show_order_receivers_city').val($(`#ReceiversCity${orderId}`).html());
    $('#show_order_receivers_address').val($(`#ReceiversAddress${orderId}`).html());
    $('#show_order_cargo_weight').val($(`#CargoWeight${orderId}`).html());
    $('#show_order_date_of_cargo_pickup').val($(`#DateOfCargoPickup${orderId}`).html())
}