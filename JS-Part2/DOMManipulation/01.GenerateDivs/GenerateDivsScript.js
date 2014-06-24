
function generateDivs() {
    var divsCount = (document.getElementById("divsCount").value | 0);
    var content = document.getElementById("content");
    var docFragment = document.createDocumentFragment();

    while (content.firstChild) {
        content.removeChild(content.firstChild);
    }
    for (var i = 0; i < divsCount; i++) {
        var div = document.createElement("div");
        div.style.backgroundColor = generateRandomColor();
        div.style.borderColor = generateRandomColor();
        div.style.borderWidth = (generateRandomNumber(1, 20)) + "px";
        div.style.borderRadius = (generateRandomNumber(1, 100)) + "px";
        div.style.color = generateRandomColor();
        div.style.width = (generateRandomNumber(20,100)) + "px";
        div.style.height = (generateRandomNumber(20, 100)) + "px";
        div.style.position = "absolute";
        div.style.top = generateRandomNumber(5, screen.height - 20) + "px";
        div.style.right = generateRandomNumber(5, screen.width - 20) + "px";
        var strong = document.createElement("strong");
        strong.textContent = "div";
        div.appendChild(strong);
        docFragment.appendChild(div);
    }
    content.appendChild(docFragment);
}

function generateRandomNumber(min,max) {
    return (Math.random() * (max - min) | 0);
}
function generateRandomColor() {
    var r = Math.floor(Math.random() * 256);
    var g = Math.floor(Math.random() * 256);
    var b = Math.floor(Math.random() * 256);
    return "rgb(" + r + "," + g + "," + b + ")";
}
