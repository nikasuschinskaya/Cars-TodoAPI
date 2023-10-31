function loadCars() {
    $.ajax({
        url: '/api/cars',
        type: 'GET',
        success: function (data) {
            $('#carList').empty();

            $.each(data, function (index, car) {
                $('#carList').append('<li>ID: ' + car.id + ', Brand: ' + car.brand + ', Power: ' + car.power + ', Price: ' + car.price + ', Color: ' + car.color + '</li>');
            });
        }
    });
}

function addCar() {
    var brand = $('#brand').val();
    var power = $('#power').val();
    var price = $('#price').val();
    var color = $('#color').val();

    $.ajax({
        url: '/api/cars',
        type: 'POST',
        data: JSON.stringify({ brand: brand, power: power, price: price, color: color }),
        contentType: 'application/json',
        success: function () {
            loadCars(); 
        }
    });
}

function updateCar() {
    var id = $('#updateId').val();
    var brand = $('#updateBrand').val();
    var power = $('#updatePower').val();
    var price = $('#updatePrice').val();
    var color = $('#updateColor').val();

    $.ajax({
        url: '/api/cars/' + id,
        type: 'PUT',
        data: JSON.stringify({ brand: brand, power: power, price: price, color: color }),
        contentType: 'application/json',
        success: function () {
            loadCars(); 
        }
    });
}

function deleteCar() {
    var id = $('#deleteId').val();

    $.ajax({
        url: '/api/cars/' + id,
        type: 'DELETE',
        success: function () {
            loadCars();
        }
    });
}

$(document).ready(function () {
    loadCars();

    $('#addCar').click(addCar);
    $('#updateCar').click(updateCar);
    $('#deleteCar').click(deleteCar);
});
