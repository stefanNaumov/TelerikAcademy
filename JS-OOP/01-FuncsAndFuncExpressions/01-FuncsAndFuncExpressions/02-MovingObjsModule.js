var movingShapesModule = (function () {

    'use strict';

    function generateDivElement() {

        var div = document.createElement('div');
        div.innerText = 'div';
        div.style.position = 'absolute';
        div.style.display = 'inline-block';
        div.style.left = randomGenerator(50, 500) + 'px';
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

        }

        if (shape === 'ellipse') {

        }
    }

    function randomGenerator(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
    return {
        addShape:addShape
    }
}());