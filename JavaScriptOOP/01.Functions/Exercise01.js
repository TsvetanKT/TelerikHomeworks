var domModule = (function() {
    var buffer = [];

    function appendChild(child, parentSelector) {
        var parent = document.querySelector(parentSelector);
        parent.appendChild(child);
    }

    function removeChild(parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector);
        var child = parent.querySelector(childSelector);
        parent.removeChild(child);
    }

    function addHandler(elementSelector, eventType, eventHandler) {
        var elements = document.querySelectorAll(elementSelector);
        for (var i = 0; i < elements.length; i += 1) {
            elements[i].addEventListener(eventType, eventHandler);
        }
    }

    function appendToBuffer(parentSelector, element) {
        if (buffer[parentSelector]) {
            buffer[parentSelector].push(element);

            if (buffer[parentSelector].length == 100) {
                var frag = document.createDocumentFragment();
                for (var i = 0; i < buffer[parentSelector].length; i++) {
                    frag.appendChild(buffer[parentSelector][i]);
                }

                var parent = document.querySelector(parentSelector);
                parent.appendChild(frag);

                buffer[parentSelector] = [];
            }

        } else {
            buffer[parentSelector] = [];
            buffer[parentSelector].push(element);
        }
    }

    // function clear(element) {
    //     buffer = [];
    //     var myNode = document.querySelector(element);

    //     while (myNode.firstChild) {
    //         myNode.removeChild(myNode.firstChild);
    //     }
    // }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        //clear: clear
    };

}());