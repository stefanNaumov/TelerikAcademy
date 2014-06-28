var CanvasShapes = function (canvasID) {
    var ctx = document.getElementById(canvasID).getContext('2d');
    
    function drawRect(x, y, width, height, color) {
        ctx.beginPath();
        ctx.rect(x, y, width, height);
        ctx.fillStyle = color;
        ctx.fill();
        ctx.stroke();
    }

    function drawCircle(x, y, radius, color) {
        ctx.beginPath();
        ctx.arc(x, y, radius, 0, 2 * Math.PI);
        ctx.fillStyle = color;
        ctx.fill();
        ctx.stroke();
    }

    function drawLine(xStart,yStart,xEnd,yEnd,strokeColor) {
        ctx.beginPath();
        ctx.moveTo(xStart, yStart);
        ctx.lineTo(xEnd, yEnd);
        ctx.strokeStyle = strokeColor;
        ctx.stroke();
    }

    return {
        drawRectangle: drawRect,
        drawCircle: drawCircle,
        drawLine:drawLine
    }
};