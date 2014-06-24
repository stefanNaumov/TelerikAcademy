var vehicles = (function () {

    var _afterBurnerState = Object.freeze({
        "ON": 1,
        "OFF":2
    });

    Function.prototype.inherit = function (parent) {
        this.prototype = new parent();
        this.prototype.constructor = this;
    }
    Function.prototype.extend = function (parent) {
        for (var i = 1; i < arguments.length; i++) {
            var name = arguments[i];
            this.prototype[name] = parent.prototype[name];
        }
        return this;
    }
    function Vehicle(speed, propulsionUnits) {
        this.speed = speed;
        this.propulsionUnits = propulsionUnits;
    }
    Vehicle.prototype.accelerate = function () {
        for (var i = 0; i < this.propulsionUnits; i++) {
            this.speed += this.propulsionUnits[i].getAcceleration();
        }
    }
    function PropulsionUnit() {

    };
    function Wheel(radius) {
        this.radius = radius;
    }
    Wheel.inherit(PropulsionUnit);

    Wheel.prototype.getAcceleration = function () {
        return parseInt(2 * this.radius);
    };
    function PropellingNozzle(power, afterBurnerSwitch) {
        this.power = power;
        this.afterBurnerSwitch = afterBurnerSwitch;
    }
    PropellingNozzle.inherit(PropulsionUnit);

    PropellingNozzle.prototype.getAcceleration = function () {
        if (this.afterBurnerSwitch == _afterBurnerState.ON) {
            return parseInt(2 * this.power);
        }
        else {
            return this.power;
        }
    }
    function LandVehicle(speed,wheels) {
        Vehicle.apply(this, arguments);
    }
    LandVehicle.inherit(Vehicle);

    return {
        AfterBurnerState: _afterBurnerState,
        Wheel:Wheel,
        PropellingNozzle: PropellingNozzle,
        LandVehicle: LandVehicle

    }
})();