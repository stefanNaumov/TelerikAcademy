var movingShapesModule = (function () {

    'use strict';
    var ellipseMovementObjs = [];
    var rectMovingObjs = [];
    var rectHeight = 300;
    var rectWidth = 500;
    var angle = 0;
    var radius = 50;
    var fragment = document.createDocumentFragment();
    function generateDivElement() {

        var div = document.createElement('div');
        div.innerText = 'div';
        div.style.position = 'absolute';
        div.style.display = 'inline-block';
        div.style.left = randomGenerator(50, 400) + 'px';
        div.style.top = randomGenerator(10, 100) + 'px';
        div.style.background = generateColor();
        div.style.fontSize = randomGenerator(8, 26) + 'px';
        div.style.padding = randomGenerator(1, 25) + 'px';

        return div;
    }

    function generateColor() {
        var red = randomGenerator(0, 255);
        var green = randomGenerator(0, 255);
        var blue = randomGenerator(0, 255);

        return 'rgb(' + red + ',' + green + ',' + blue + ');';
    }

    function addShape(shape) {

        var currDiv = generateDivElement();

        if (shape === 'rect') {
            rectMovingObjs.push(currDiv);
            fragment.appendChild(currDiv);
            document.body.appendChild(fragment);
            handleRectMovement();
        }

        if (shape === 'ellipse') {
            ellipseMovementObjs.push(currDiv);
            fragment.appendChild(currDiv);
            document.body.appendChild(fragment);
            handleEllipseMovement();
        }
    }
    
    function handleRectMovement() {
        
        for (var i = 0; i < rectMovingObjs.length; i++) {

            var left = parseInt(rectMovingObjs[i].style.left);
            var top = parseInt(rectMovingObjs[i].style.top);

            if (top <= 10 && left < rectWidth) {
                top = 10;
                left += 3;
            }
            else if (top < rectHeight && left >= rectWidth) {

                top += 3;
            }
            else if (top >= rectHeight && left > 0) {
                    
                left -= 3;
            }
            else {
                    
                top -= 3;
            }
                
            rectMovingObjs[i].style.left = left + 'px';
            rectMovingObjs[i].style.top = top + 'px';
        }
        requestAnimationFrame(handleRectMovement);
    };

    function handleEllipseMovement() {
        
        for (var i = 0; i < ellipseMovementObjs.length; i++) {

            ellipseMovementObjs[i].style.left = (i + 1) * 150 + Math.cos(angle + 2 * Math.PI / ellipseMovementObjs.length * i)
                / radius * 10000 + 'px';
            ellipseMovementObjs[i].style.top = 200 + Math.sin(angle + 2 * Math.PI / ellipseMovementObjs.length * i)
                / radius * 7000 + 'px';
        }
        angle += 0.1;
        requestAnimationFrame(handleEllipseMovement);
    }

    function randomGenerator(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
    
    return {
        addShape:addShape
    }
}());