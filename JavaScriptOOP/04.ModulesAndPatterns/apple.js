'use strict';
var JsSnake = JsSnake || {};

JsSnake.apple = (function () {
    var position = [25, 20];

    function draw(ctx) {
        ctx.save();
        ctx.fillStyle = 'Crimson';
        ctx.beginPath();
        var radius = JsSnake.blockSize / 2;
        var x = position[0] * JsSnake.blockSize + radius;
        var y = position[1] * JsSnake.blockSize + radius;
        ctx.arc(x, y, radius, 0, Math.PI * 2, true);
        ctx.fill();
        ctx.restore();
    }

    function random(low, high) {
        return Math.floor(Math.random() * (high - low + 1) + low);
    }

    // Get a random position within the game field.
    function getRandomPosition() {
        var x = random(1, JsSnake.widthInBlocks - 5);
        var y = random(1, JsSnake.heightInBlocks - 5);
        return [x, y];
    }

    function setNewPosition(snakeArray) {
        var newPosition = getRandomPosition();
        //if new position is already covered by the snake, try again
        if (JsSnake.checkCoordinateInArray(newPosition, snakeArray)) {
            return setNewPosition(snakeArray);
        }
            //otherwise set position to the new position
        else {
            position = newPosition;
        }
    }

    function getPosition() {
        return position;
    }

    return {
        draw: draw,
        setNewPosition: setNewPosition,
        getPosition: getPosition
    };
});