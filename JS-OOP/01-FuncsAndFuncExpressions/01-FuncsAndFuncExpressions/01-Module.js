var domModule = (function() {

    var elementsBuffer = {};

    function appendChild(element, container) {

        var container = document.querySelector(container);
        container.appendChild(element);
    }

    function removeElement(parentSelector,elementToRemove) {

        var parent = document.querySelector(parentSelector);
        
        var elementToRemove = document.querySelector(elementToRemove);

        parent.removeChild(elementToRemove);
    }

    function addHandler(selector, eventType, eventListener) {

        var objToListen = document.querySelector(selector);
        objToListen.addEventListener(eventType, eventListener);
    }

    function appendToBuffer(currentContainer, elementToAdd) {

        if (!elementsBuffer[currentContainer]) {
            elementsBuffer[currentContainer] = document.createDocumentFragment();
        }

        elementsBuffer[currentContainer].appendChild(elementToAdd);

        if (elementsBuffer[currentContainer].childNodes.length >= 100) {

            var containerElement = document.querySelector(currentContainer);
            containerElement.appendChild(elementsBuffer[currentContainer]);
        }

    }

    function getByCssSelector(selector) {
        //a little hack
        if (selector.indexOf('#') > 0) {
            return document.getElementById(selector);
        }
        else if (selector.indexOf('.') > 0) {
            return document.getElementsByClassName(selector);
        }
        else {
            return document.getElementsByTagName(selector);
        }
    }
    return {
        appendChild: appendChild,
        removeElement: removeElement,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        findByCssSelector: getByCssSelector
    }
}());