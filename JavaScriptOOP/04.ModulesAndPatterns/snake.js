//var JsSnake = {};
'use strict';
var JsSnake = JsSnake || {};

JsSnake.snake = (function () {
    var previousPosArray;
    var posArray = [];
    posArray.push([16, 20]);
    posArray.push([16, 20]);
    var direction = 'right';
    var nextDirection = direction;

    function setDirection(newDirection) {
        var allowedDirections;

        switch (direction) {
            case 'left':
            case 'right':
                allowedDirections = ['up', 'down'];
                break;
            case 'up':
            case 'down':
                allowedDirections = ['left', 'right'];
                break;
            default:
                throw ('Error! Invalid direction.');
        }
        if (allowedDirections.indexOf(newDirection) > -1) {
            nextDirection = newDirection;
        }
    }

    function drawSection(ctx, position) {
        var x = JsSnake.blockSize * position[0];
        var y = JsSnake.blockSize * position[1];
        ctx.fillRect(x, y, JsSnake.blockSize, JsSnake.blockSize);
    }

    function draw(ctx) {
        ctx.save();
        ctx.fillStyle = 'GreenYellow';
        for (var i = 0; i < posArray.length; i += 1) {
            drawSection(ctx, posArray[i]);
        }
        ctx.restore();
    }

    function checkCollision() {
        var wallCollision = false;
        var snakeCollision = false;
        var head = posArray[0]; // head
        var rest = posArray.slice(1); //the rest
        var snakeX = head[0];
        var snakeY = head[1];
        var minX = 1;
        var minY = 1;
        var maxX = JsSnake.widthInBlocks - 1;
        var maxY = JsSnake.heightInBlocks - 1;
        var outsideHorizontalBounds = snakeX < minX || snakeX >= maxX;
        var outsideVerticalBounds = snakeY < minY || snakeY >= maxY;

        if (outsideHorizontalBounds || outsideVerticalBounds) {
            wallCollision = true;
        }
        //check if the snake head coords overlap the rest of the snake
        snakeCollision = JsSnake.checkCoordinateInArray(head, rest);
        return wallCollision || snakeCollision;
    }

    function advance(apple) {
        var nextPosition = posArray[0].slice();
        direction = nextDirection;
        switch (direction) {
            case 'left':
                nextPosition[0] -= 1;
                break;
            case 'up':
                nextPosition[1] -= 1;
                break;
            case 'right':
                nextPosition[0] += 1;
                break;
            case 'down':
                nextPosition[1] += 1;
                break;
            default:
                throw ('Invalid direction');
        }

        previousPosArray = posArray.slice();
        posArray.unshift(nextPosition);
        if (isEatingApple(posArray[0], apple)) {
            $(JsSnake).trigger('appleEaten', [posArray]);
        } else {
            posArray.pop();
        }
    }

    function isEatingApple(head, apple) {
        var isEatingApple = JsSnake.equalCoordinates(head, apple.getPosition());
        return isEatingApple;
    }

    function retreat() {
        posArray = previousPosArray;
    }

    return {
        draw: draw,
        advance: advance,
        retreat: retreat,
        setDirection: setDirection,
        checkCollision: checkCollision
    };
});
