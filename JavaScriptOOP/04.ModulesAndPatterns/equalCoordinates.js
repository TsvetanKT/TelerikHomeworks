'use strict';
var JsSnake = JsSnake || {};

JsSnake.equalCoordinates = (function (coord1, coord2) {
    var isequalCoordinates = coord1[0] === coord2[0] && coord1[1] === coord2[1];
    return isequalCoordinates;
});