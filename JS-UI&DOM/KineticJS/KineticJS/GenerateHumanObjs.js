function generateHumanObjs(familyObjs) {
    

    function Human(name) {
        this.name = name;
        this.parent = false;
        this.partner = false;
        this.children = [];
    }

    var allHumans = (function () {
        var humansArray = [];

        for (var i = 0; i < familyObjs.length; i++) {

            var currentHuman = getHuman(familyObjs[i].father);

            if (!currentHuman.partner) {
                currentHuman.partner = getHuman(familyObjs[i].mother);
                currentHuman.partner.partner = currentHuman;
            }

            for (var j = 0; j < currentHuman.children.length; j++) {

                var currentChild = getHuman(familyObjs.children[j]);
                currentChild.parent = currentHuman;
                currentHuman.children.push(currentChild);
            }
        }
        return humansArray;
        function getHuman(currHumanName) {
            for (var i = 0; i < humansArray.length; i++) {
                
                if (humansArray[i].name == currHumanName) {
                    return humansArray[i];
                }
            }
            var newHuman = new Human(currHumanName);
            humansArray.push(newHuman);

            return newHuman;
        }
    }());

    var getTreeRoots = (function () {
        var treeRoots = [];

        for (var i = 0; i < allHumans.length; i++) {
            
            if (allHumans[i].children.length > 0 && !allHumans[i].parent) {
                treeRoots.push(allHumans[i]);
            }
        }
        return treeRoots;
    }());

    return {
        FamilyTreeRoots: getTreeRoots,
        FamilyTree: allHumans
    }
};