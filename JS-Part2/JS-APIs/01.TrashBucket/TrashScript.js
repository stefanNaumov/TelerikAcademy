var trashElementsCount = document.getElementsByClassName("randomTrash").length;
var startTime;
var collectedGarbageCount = 0;
function bucketState(state) {
    var bucket = document.getElementById("trashBucket");
    bucket.src = "/Trash" + state + ".JPG";
}
function allowDrop(evt) {
    evt.preventDefault();

}
function drop(evt) {
    collectedGarbageCount++;
    
    evt.preventDefault();
    
    var data = evt.dataTransfer.getData("id");
    var element = document.getElementById(data);
    trashArea.removeChild(element);

    if (collectedGarbageCount == trashElementsCount) {
        userInput();
    }
}
function drag(evt) {
    evt.dataTransfer.setData("id", evt.target.id);
}
function generateRandomTrash() {
    var trashElements = Math.floor(Math.random() * (10 - 5) + 5);

    for (var i = 0; i < trashElements; i++) {

        var img = document.createElement("img");
        img.src = "trash.jpg";
        img.id = "img" + (i + 1);
        img.style.top = Math.floor((Math.random() * (500 + 150))) + "px";
        img.style.left = (Math.floor(Math.random() * 300)) + "px";
        img.draggable = "true";
        img.ondragstart = "drag(event)";
        img.className = "randomTrash";
        document.getElementById("trashArea").appendChild(img);
        //alert(img.id);
    }
}
function startGame() {
    startTime = new Date().getTime();
    //generateRandomTrash();
    
    
}
function userInput() {
    
    var endTime = new Date().getTime();

    var label = document.createElement("label");
    label.innerHTML = "Player name:";
    label.htmlFor = "playerName";

    var input = document.createElement("input");
    input.id = "playerName";

    document.body.appendChild(label);
    document.body.appendChild(input);

    var name = document.getElementById("playerName");

    var key = (startTime - endTime) / 1000;
    var value = name.value;

    localStorage.setItem(key, value);
    
}

function printHighScore() {
    var storageArray = [];
    for (var i = 0; i < localStorage.length; i++) {

        storageArray[i] = parseFloat(localStorage.key(i));
    }
    storageArray.sort(function (a, b) { return a - b });
    var div = document.getElementById("highScore");
    div.innerHTML = "";
    for (var j = 0; j < 5; j++) {
        var key = storageArray[j];
        var value = localStorage.getItem(key);
        div.innerHTML += key + " - ";
        div.innerHTML += value + "<br/>";
    }
}