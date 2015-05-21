$(function () {
    var hotelsContainer = $('#hotelsContainer');

    $.ajax({
        url: 'hotels.json',
        dataType: 'json',
        success: function (jsonData) {
            generateTable(hotelsContainer, jsonData);
        },
        error: function () {
            console.log('Error while loading hotels data');
        }
    });

});