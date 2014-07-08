/// <reference path="../libs/require.js" />
define(function () {
    var Item;
    Item = (function () {
        function Item(type, name, price) {
            if (!(name.length >= 6 && name.length <= 40)) {
                throw "Invalid name";
            }
            if (!(type === 'accessory' || type === 'smart-phone' || type === 'notebook' || type === 'pc' || type === 'tablet')) {
                throw "Invalid device type";
            }
            this.type = type;
            this.name = name;
            this.price = price;
        }
        return Item;
    }());
    return Item;
});