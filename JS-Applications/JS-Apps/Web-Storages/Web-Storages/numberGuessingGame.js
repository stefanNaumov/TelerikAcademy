﻿'use strict';
var highScore = 0;
document.getElementById('sheepCounter').innerHTML = 0;
document.getElementById('ramCounter').innerHTML = 0;
function gameStart() {
    var numbersArr = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
    highScore += 1;

    var userNumber = document.getElementById('userInput').value;

    if (userNumber.length != 4) {
        alert('input must be 4 digits exactly!');
    }
    else {
        userNumber = parseUserInput(userNumber);

        var gameNumber = generateComputerNumber(numbersArr, 4);

        manageSheepAndRamCounters(userNumber, gameNumber);
    }

    //fisher-yates shuffle
    function generateComputerNumber(array, numberOfElements) {

        var at = 0;
        var tmp, current, top = array.length;

        if (top) {
            while (--top && at++ < numberOfElements) {
                current = Math.floor(Math.random() * (top - 1));
                tmp = array[current];
                array[current] = array[top];
                array[top] = tmp;
            }
        }

        return array.slice(-numberOfElements);
    }

    //returns an array from user's input string
    function parseUserInput(number) {
        var userInputArr = [];

        for (var i = 0; i < number.length; i++) {
            userInputArr.push(number[i]);
        }

        return userInputArr;
    }
}

function manageSheepAndRamCounters(userNumber, computerNumber) {

    var sheepCounter = 0;
    var ramsCounter = 0;
    for (var i = 0; i < userNumber.length; i++) {

        for (var j = 0; j < computerNumber.length; j++) {

            if (userNumber[i] === computerNumber[j]) {

                if (i === j) {
                    ramsCounter += 1;

                }
                else {
                    sheepCounter += 1;

                }
                //debugging log
                //console.log(userNumber[i] + ' ' + computerNumber[j] + '    ' + i + ' ' + j);
            }

            if (ramsCounter === 2) {
                var allRams = parseInt(document.getElementById('ramCounter').innerHTML);
                allRams += ramsCounter;
                document.getElementById('ramCounter').innerHTML = allRams;

                //hide the game and prompt name from the user for the highscore list
                if (allRams >= 4) {
                    document.getElementById('wrapper').style.display = 'none';
                    var score = document.getElementById('showScore');
                    score.style.display = 'inline-block';
                    score.innerHTML = 'Your score is ' + highScore;
                    document.getElementById('userNameLabel').style.display = 'inline-block';
                    document.getElementById('userName').style.display = 'inline-block';
                    document.getElementById('nameButton').style.display = 'inline-block';
                }
                ramsCounter = 0;
            }
            if (sheepCounter === 2) {
                var allSheep = parseInt(document.getElementById('sheepCounter').innerHTML);
                allSheep = allSheep + sheepCounter;
                document.getElementById('sheepCounter').innerHTML = allSheep;
                sheepCounter = 0;
            }
        }
    }

}

function saveUserData() {
    var currentUserName = document.getElementById('userName').value;
    if (currentUserName.length <= 1) {
        alert('Invalid name!');
        return;
    }

    localStorage.setItem('Game' + currentUserName, highScore);

}

function getUsersData() {

    if (!String.prototype.startsWith) {
        String.prototype.startsWith = function (str) {
            return this.indexOf(str) === 0;
        }
    }
    var highScoreList = [];

    if (localStorage.length > 0) {

        for (var user in localStorage) {

            if (user.startsWith('Game')) {

                var currUser = {
                    name: user.substring(4),
                    score: localStorage.getItem(user)
                };
                console.log(currUser);
                highScoreList.push(currUser);
            }
        }
    }

    fillHighScoreList(highScoreList);
}

function fillHighScoreList(highScoreList) {

    var scoreList = document.getElementById('scoreList');
    scoreList.innerHTML = '';
    _.chain(highScoreList)
    .sortBy('score')
    .each(function (user) {
        var li = document.createElement('li');
        li.innerHTML = 'Name: ' + user.name + ' - Guesses: ' + user.score;

        scoreList.appendChild(li);
    })
}