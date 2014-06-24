function generateTagCloud(tags, min, max) {

    var tagsArr = getTags(tags);
    var allElements = tags.length;
    var setFontSizesArr = setFontSizes(tagsArr, allElements,min,max);
    appendTagCloud(setFontSizesArr);

    function getTags(tags) {
        var countArr = [];
        var isAnExistingKey = false;

        for (var i = 0; i < tags.length; i++) {

            var currentTag = tags[i];
            
            for (var j = 0; j < countArr.length; j++) {
                if (countArr[j].name == currentTag) {

                    countArr[j].count += 1;
                    isAnExistingKey = true;
                }
            }
            if (!isAnExistingKey) {
                countArr.push({ name: currentTag, count: 1,fontsize:'' });
            }
            isAnExistingKey = false;
        }

        return countArr;
    }

    function setFontSizes(tagsArr,allElementsCount, minFont, maxFont) {
        var fontSize = maxFont;
        for (var i = allElementsCount; i >= 0; i -= 1) {

            for (var j = 0; j < tagsArr.length; j += 1) {

                if (tagsArr[j].count == i) {
                    fontSize -= 2;
                    tagsArr[j].fontsize = fontSize;
                }
            }

            if (fontSize <= minFont) {
                maxFont += 1;
            }
        }
        return tagsArr;
    }
    function appendTagCloud(tags) {

        var docFragment = document.createDocumentFragment();
        var tagCloud = document.getElementById('tagCloud');
        var tag = document.createElement('span');
        var whiteSpace = document.createElement('span');
        whiteSpace.innerHTML = '     ';
        for (var i = 0; i < tags.length; i++) {
            tag.innerHTML = tags[i].name;
            tag.style.fontSize = tags[i].fontsize + 'px';
            docFragment.appendChild(tag.cloneNode(true));
            docFragment.appendChild(whiteSpace);
        }
        tagCloud.appendChild(docFragment);
    }
}