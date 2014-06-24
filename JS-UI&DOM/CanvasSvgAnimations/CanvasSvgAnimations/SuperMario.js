/// <reference path="kineticJS.js" />
/// <reference path="Raphael.js" />
window.onload = function () {
    "use strict";
    var stage = new Kinetic.Stage({
        container: 'kinetic-cont',
        width: window.outerWidth,
        height: 800
    });

    var layer = new Kinetic.Layer();

    var imageObj = new Image();
    
    imageObj.onload = function () {
        var character = new Kinetic.Sprite({
            x: 100,
            y: 540,
            scaleX: 4,
            scaleY:5,
            image:imageObj,
            animation: 'idle',
            animations: {
                idle: [
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    112, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                    128, 1, 15, 100,
                ],
                moveLeft: [
                    //192,1,16,100,
                    96, 1, 15, 100,
                    80, 1, 15, 100,
                    64, 1, 15, 100,
                    48, 1, 15, 100,
                ],
                moveRight:[
                    //32, 1, 16, 100,
                    128, 1, 15, 100,
                    144, 1, 16, 100,
                    160, 1, 16, 100,
                    176,1,16,100
                ],
            },
            framerate: 2,
            frameIndex: 0
        });

        layer.add(character);
        stage.add(layer);

        character.start();

        var frameCount = 0;

        character.on('frameIndexChange', function (evt) {
            if ((character.animation() === 'moveLeft'
                || character.animation() === 'moveRight')
                && ++frameCount > 4) {
                character.animation('idle');
                frameCount = 0;
            }
        });

        function onKeyPress(evt) {
            switch (evt.keyCode) {
                case 37:
                    character.setX(character.attrs.x -= 16);
                    character.attrs.animation = 'moveLeft'
                    break;
                case 39:
                    character.setX(character.attrs.x += 16);
                    character.attrs.animation = 'moveRight'
                    break;
                default:
            }
        }
        window.addEventListener('keydown', onKeyPress);
    };
    imageObj.src = '../mario.png';

    var paper = new Raphael(0, 0, window.outerWidth, window.innerHeight);
    paper.image('../Skyworld_Terrain.png', 0, 0, window.outerWidth, window.innerHeight);
}