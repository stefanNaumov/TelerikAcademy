var Class = (function () {

    function createClass(properties) {
        var createObj = function () {
            this.init.apply(this, arguments);
        }
        for (var prop in properties) {
            createObj.prototype[prop] = properties[prop];
        }
        if (!createObj.prototype.init) {
            createObj.prototype.init = function () { };
        }
        return createObj;
    }
    Function.prototype.inherit = function (parent) {
        var oldPrototype = this.prototype;
        var parentPrototype = new parent();
        this.prototype = Object.create(parentPrototype);
        this.prototype._super = parentPrototype;
        for (var prop in oldPrototype) {
            this.prototype[prop] = oldPrototype[prop];
        }
    }

    return {
        create: createClass,
    };
}());
var Asshole = {};