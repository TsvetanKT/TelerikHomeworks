var movingShapes = (function () {

    function randomColor() {
        return "rgb(" + parseInt(Math.random() * 256, 10) + "," 
            + parseInt(Math.random() * 256, 10) + "," 
            + parseInt(Math.random() * 256, 10) + ")";
    }

    function moveEllipseDiv(angle, singleDiv) {
        var firstRadius = 100,
            secondRadius = 150, 
            xCenter = 200,
            yCenter = 200,
            x = Math.floor(xCenter + (firstRadius * Math.cos(angle))),
            y = Math.floor(yCenter + (secondRadius * Math.sin(angle)));

        angle = angle + 0.02;
        singleDiv.style.top = x + "px";
        singleDiv.style.left = y + "px";

        setTimeout(function () {
            moveEllipseDiv(angle, singleDiv);
        }, 10);
    }

    function moveRectDiv(dir, offset, singleDiv) {
        var xStart = 100,
            yStart = 500,
            rectSideA = 400,
            rectSideB = 200,
            x,
            y;

        offset += 2;
        if ((offset === rectSideA && dir % 2 === 0) || (offset === rectSideB && dir % 2 === 1)) {
            dir += 1;
            dir %= 4;
            offset = 0;
        }

        switch (dir) {
        case 0:
            y = yStart + offset;
            x = xStart;
            break;
        case 1:
            x = xStart + offset;
            y = yStart + rectSideA;
            break;
        case 2:
            y = yStart + rectSideA - offset;
            x = xStart + rectSideB;
            break;
        case 3:
            x = xStart + rectSideB - offset;
            y = yStart;
            break;
        //default: console.log('Default on switch Error');
        }
        singleDiv.style.top = x + "px";
        singleDiv.style.left = y + "px";

        setTimeout(function () {
            moveRectDiv(dir, offset, singleDiv);
        }, 10);
    }

    function add(shape) {
        var wrapper = document.getElementById("wrapper"),
            oneDiv = document.createElement("div");

        oneDiv.className = "circle";
        oneDiv.style.backgroundColor = randomColor();
        oneDiv.style.color = randomColor();
        oneDiv.style.border = "5px solid " + randomColor(); 
        oneDiv.innerHTML = "Div";
        wrapper.appendChild(oneDiv);
        if (shape === 'rect') {
            moveRectDiv(0, 0, oneDiv);
        } else if (shape === 'ellipse') {
            moveEllipseDiv(0, oneDiv);
        }
    }

    return {
        add: add
    };

}());