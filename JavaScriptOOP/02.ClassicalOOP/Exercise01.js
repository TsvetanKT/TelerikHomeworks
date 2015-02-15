var CanvasModule = function (selector) {

    var DEFAULT_LINE_WIDTH = 1,
        DEFAULT_STROKE_STYLE = 'black',
        DEFAULT_FILL_COLLOR = 'white',
        canvas = document.querySelector(selector),
        ctx = canvas.getContext('2d');

    function colorTheme(linePixels, strokeCollor, fillColor) {
        ctx.lineWidth = linePixels || DEFAULT_LINE_WIDTH;
        ctx.strokeStyle = strokeCollor || DEFAULT_STROKE_STYLE;
        ctx.fillStyle = fillColor || DEFAULT_FILL_COLLOR;
    }
    
    function drawRect(position, width, height, linePixels, strokeCollor, fillColor) {
        colorTheme(linePixels, strokeCollor, fillColor);
        ctx.beginPath();
        ctx.rect(position.x, position.y, width, height);
        ctx.fill();
        ctx.stroke();
    }

    function drawCircle(centerPosition, radius, linePixels, strokeCollor, fillColor) {
        colorTheme(linePixels, strokeCollor, fillColor);
        ctx.beginPath();
        ctx.arc(centerPosition.x, centerPosition.y, radius, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();
    }

    function drawLine(fromPosition, toPosition, linePixels, strokeCollor) {
        colorTheme(linePixels, strokeCollor);
        ctx.beginPath();
        ctx.moveTo(fromPosition.x, fromPosition.y);
        ctx.lineTo(toPosition.x, toPosition.y);
        ctx.stroke();
    }

    return {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine: drawLine
    };
};