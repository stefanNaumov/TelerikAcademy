var dom = (function () {

    var fragmentsBuffer = {};
    var maxBufferCount = 100;

    function getElement(selector) {
        var element = document.querySelector(selector);
        return element;
    }
    function getElements(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    }
    function addChild(parentName, childName,innerHTML) {
        var parent = getElement(parentName);
        var child = createElement(childName, innerHTML);
        parent.appendChild(child);
    }
    function removeElement(selector) {
        var elementsToRemove = getElements(selector);

        for (var i = 0; i < elementsToRemove.length; i++) {
            document.removeChild(elementsToRemove[i]);
        }
    }
    function createElement(elementString, innerHTML){
        var element = document.createElement(elementString);
        element.innerHTML = innerHTML;
        return element;
    }
    function addHandler(tagStr, event, handler) {
        var element = getElement(tagStr);
        element.addEventListener(event, handler, false);
        
    }
    function addElementsViaBuffer(selector,element,innerHTML) {
        var element = createElement(element, innerHTML);
        if (!fragmentsBuffer[selector]) {
            fragmentsBuffer[selector] = document.createDocumentFragment();
        }
        fragmentsBuffer[selector].appendChild(element);

        if (fragmentsBuffer[selector].childNodes.length >= maxBufferCount) {
            var parentElement = getElement(selector);
            parentElement.appendChild(fragmentsBuffer[selector]);
        }
        
    }
    return {
        appendChild: addChild,
        removeChild: removeElement,
        createElement: createElement,
        addEventHandler: addHandler,
        addElementViaBuffer: addElementsViaBuffer
    };
})();