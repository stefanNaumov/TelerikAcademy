var movingElements = (function () {
    var rectangularMovingObjs = [];
    var ellipseMovingObjs = [];
    var angle = 0;
    var radius = 50;
    var rectHeight = 100;
    var rectWidth = 500;

    function addElement(movement) {

        if (movement == 'ellipse') {
            var div = generateDiv(ellipseMovingObjs);
            ellipseMovingObjs.push(div);
            addDivsToBody(ellipseMovingObjs);
            moveElementEllipse();
        }
        else if (movement == 'rect') {
            var div = generateDiv(rectangularMovingObjs);
            rectangularMovingObjs.push(div);
            addDivsToBody(rectangularMovingObjs);
            moveEllementRectangular();
        }
    }

    function moveElementEllipse() {
        
        for (var i = 0; i < ellipseMovingObjs.length; i++) {
            var left = ellipseMovingObjs[i].style.left;
            var top = ellipseMovingObjs[i].style.top;
            ellipseMovingObjs[i].style.left = (i + 1) * 150 + Math.cos(angle + 2 * Math.PI / ellipseMovingObjs.length * i) / radius * 10000 + 'px';
            ellipseMovingObjs[i].style.top = 200 + Math.sin(angle + 2 * Math.PI / ellipseMovingObjs.length * i) / radius * 7000 + 'px';
        }
        angle += 0.1;

        setTimeout(moveElementEllipse, 50);
    }
    function moveEllementRectangular() {

        var left;
        var top;

        for (var i = 0; i < rectangularMovingObjs.length; i++) {

            left = parseInt(rectangularMovingObjs[i].style.left);
            top = parseInt(rectangularMovingObjs[i].style.top);

            if (top <= 0 && left < rectWidth) {
                top = 0;
                left += 2;
            }
            else if (left >= rectWidth && top < rectHeight) {

                top += 2;

            }
            else if (top >= rectHeight && left > 0) {

                left -= 2;
            }
            else {
                top -= 2;
            }
            

            rectangularMovingObjs[i].style.left = left + 'px';
            rectangularMovingObjs[i].style.top = top + 'px';
        }
        setTimeout(moveEllementRectangular, 20);
    }

    function addDivsToBody(divElements) {

        for (var i = 0; i < divElements.length; i++) {
            document.body.appendChild(divElements[i]);
        }

    }
    function generateRandomNum(from, to) {

        return Math.floor(Math.random() * (to - from) + from);
    }

    function generateRandomColor() {
        var red = generateRandomNum(0, 255);
        var green = generateRandomNum(0,255);
        var blue = generateRandomNum(0,255);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }
    function generateDiv(elementsArr) {
        var left = 200;
        var top = 200;

        var width = 100;
        var height = 100;

        var div = document.createElement('div');
        div.innerHTML = 'div';
        div.style.position = 'absolute';
        div.style.display = 'inline-block';
        div.style.left = generateRandomNum(50,500) + 'px';
        div.style.top = generateRandomNum(10, 100) + 'px';
        div.style.background = generateRandomColor();
        div.style.fontSize = generateRandomNum(8, 26) + 'px';
        div.style.padding = generateRandomNum(1, 25) + 'px';

        return div;
    }
    return {
        addElement:addElement
    }
})();

