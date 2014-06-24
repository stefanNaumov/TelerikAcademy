function rotateDivs() {
    setInterval("generateDivs()", 100);
}
function clearElements() {
    document.body.innerHTML = "";
}
var initialAngle = 0;
var button = document.getElementById("button");
function generateDivs() {
    clearElements();
    var centerX = 600;
    var centerY = 350;
    var radius = 180;

    for (var i = 0; i < 5; i++) {
        var angle = 75 * i + initialAngle;
        createDivElement(centerX, centerY, radius, angle);
    }
    initialAngle += 5;
}
function createDivElement(centerX, centerY, radius, angle) {
    var div = document.createElement("div");
    div.style.position = "absolute";
    div.style.top = (centerY + radius * Math.sin(angle * Math.PI / 180)) + "px";
    div.style.left = (centerX + radius * Math.cos(angle * Math.PI / 180)) + "px";
    document.body.appendChild(div);
}
