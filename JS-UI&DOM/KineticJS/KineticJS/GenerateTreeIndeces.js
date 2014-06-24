function GenerateIndeces(treeRoots, allTreeElements) {
    var y = 0;
    var xIndeces = [];

    while (treeRoots.length > 0) {

        if (!xIndeces[y]) {
            xIndeces[y] = 0;
        }

        var rootsLength = treeRoots.length;
        var partners = [];

        for (var i = 0; i < rootsLength; i++) {

            if (partners.indexOf(treeRoots[i].name) >= 0) {
                continue;
            }

            treeRoots[i].xIndeces = xIndeces[y]++;
            treeRoots[i].y = y;
            
            if (treeRoots[i].partner) {
                partners.push(treeRoots[i].partner.name);
                treeRoots[i].partner.xIndeces = xIndeces[y]++;
                treeRoots[i].partner.y = y;
            }
            else {
                continue;
            }

            var children = treeRoots[i].children;

            if (children.length == 0) {

                children = treeRoots[i].partner.children;
            }

            for (var k = 0; k < children.length; k++) {
                treeRoots.push(children[k])
            }
        }
        
        treeRoots.splice(0, rootsLength);
        y++;
    }

    return allTreeElements;
}