'use strict';
var JsSnake = JsSnake || {};

JsSnake.game = (function () {
    var canvas, ctx;
    var frameLength;
    var snake;
    var apple;
    var score;
    var timeout;
    JsSnake.width = 500;
    JsSnake.height = 500;
    JsSnake.blockSize = 15;
    JsSnake.widthInBlocks = JsSnake.width / JsSnake.blockSize;
    JsSnake.heightInBlocks = JsSnake.height / JsSnake.blockSize;

    function init() {
        var $canvas = $('#JsSnake');
        if ($canvas.length === 0) {
            $('body').append('<canvas id="jsSnake">');
        }
        $canvas = $('#jsSnake');
        $canvas.attr('width', JsSnake.width);
        $canvas.attr('height', JsSnake.height);
        canvas = $canvas[0];
        ctx = canvas.getContext('2d');
        score = 0;
        frameLength = 250; //500
        snake = JsSnake.snake();
        apple = JsSnake.apple();
        bindEvents();
        gameLoop();
    }

    function gameLoop() {
        ctx.clearRect(0, 0, JsSnake.width, JsSnake.height);
        snake.advance(apple);
        draw();

        if (snake.checkCollision()) {
            snake.retreat(); //move snake back to previous position
            snake.draw(ctx); //draw snake in its previous position
            gameOver();
        } else {
            timeout = setTimeout(gameLoop, frameLength);
        }
    }

    function draw() {
        snake.draw(ctx);
        drawBorder();
        apple.draw(ctx);
        drawScore();
    }

    function drawScore() {
        ctx.save();
        ctx.font = 'bold 50px sans-serif';
        ctx.fillStyle = 'rgba(0, 0, 0, 0.3)';
        ctx.textAlign = 'center';
        ctx.textBaseline = 'middle';
        var centreX = JsSnake.width - 40;
        var centreY = 40;
        ctx.fillText(score.toString(), centreX, centreY);
        ctx.restore();
    }

    function gameOver() {
        ctx.save();
        ctx.font = 'bold 30px sans-serif';
        ctx.fillStyle = 'black';
        ctx.textAlign = 'center';
        ctx.textBaseline = 'middle';
        ctx.strokeStyle = 'white';
        ctx.lineWidth = 2;
        var centreX = JsSnake.width / 2;
        var centreY = JsSnake.width / 2;
        ctx.strokeText('Game Over', centreX, centreY - 10);
        ctx.fillText('Game Over', centreX, centreY - 10);
        ctx.font = 'bold 15px sans-serif';
        ctx.strokeText('Score: ' + score, centreX, centreY + 15);
        ctx.fillText('Score: ' + score, centreX, centreY + 15);
        ctx.strokeText('Press space to restart', centreX, centreY + 35);
        ctx.fillText('Press space to restart', centreX, centreY + 35);
        ctx.restore();
    }

    function drawBorder() {
        ctx.save();
        ctx.strokeStyle = 'Chocolate';
        ctx.lineWidth = JsSnake.blockSize;
        ctx.lineCap = 'square';
        var offset = ctx.lineWidth / 2;
        var corners = [
          [offset, offset],
          [JsSnake.width - offset, offset],
          [JsSnake.width - offset, JsSnake.height - offset],
          [offset, JsSnake.height - offset]
        ];
        ctx.beginPath();
        ctx.moveTo(corners[3][0], corners[3][1]);
        $.each(corners, function (index, corner) {
            ctx.lineTo(corner[0], corner[1]);
        });

        ctx.stroke();
        ctx.restore();
    }

    function restart() {
        clearTimeout(timeout);
        $('body').unbind('keydown');
        $(JsSnake).unbind('appleEaten');
        $(canvas).unbind('click');
        JsSnake.game.init();
    }

    function bindEvents() {
        var keysToDirections = {
            37: 'left',
            38: 'up',
            39: 'right',
            40: 'down'
        };

        $(document).keydown(function (event) {
            var key = event.which;
            var direction = keysToDirections[key];

            if (direction) {
                snake.setDirection(direction);
                event.preventDefault();
            } else if (key === 32) {
                restart();
            }
        });

        $(JsSnake).bind('appleEaten', function (event, snakePositions) {
            apple.setNewPosition(snakePositions);
            score++;
            frameLength *= 0.9; //0.99
        });

        $(canvas).click(restart);
    }

    return {
        init: init
    };
})();