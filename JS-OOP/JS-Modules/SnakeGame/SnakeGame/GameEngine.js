var GameEngine = (function () {

    var Snake = function (x, y, direction) {
        this.direction = direction;
        this.last = null;
        this._queue = [];
        this.insert(x, y);
    }
    Snake.prototype.insert = function (x,y) {
        this._queue.unshift({ x:x, y:y });
        this.last = this._queue[0];
    }
    Snake.prototype.remove = function () {
        return this._queue.pop();
    }

    var Grid = function (rows, cols,defVal) {
        this.width = cols;
        this.height = rows;
        this._field = [];

        for (var x = 0; x < cols; x++) {
            this._field.push([]);
            for (var y = 0; y < rows; y++) {
                this._field[x].push(defVal);
            }
        }
    }
    Grid.prototype.setValue = function (x,y,value) {
        this._field[x][y] = value;
    }
    Grid.prototype.getValue = function (x,y) {
        return this._field[x][y];
    }

    return {
        Snake: function (x, y, dir) {
            return new Snake(x, y, dir);
        },
        Grid: function (x, y, defVal) {
            return new Grid(x, y, defVal);
        }
    }
}());