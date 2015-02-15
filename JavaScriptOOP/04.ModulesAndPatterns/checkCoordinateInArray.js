'use strict';
var JsSnake = JsSnake || {};

JsSnake.checkCoordinateInArray = (function (coord, arr) {
    var isInArray = false;
    $.each(arr, function (index, item) {
        if (JsSnake.equalCoordinates(coord, item)) {
            isInArray = true;
        }
    });
    return isInArray;
});