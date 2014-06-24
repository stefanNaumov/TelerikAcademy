
var inputData = document.getElementsByTagName("input");
var textArea = document.getElementsByTagName("textarea");


function colorChange() {

    textArea[0].style.color = inputData[0].value;
    textArea[0].style.backgroundColor = inputData[1].value;
}