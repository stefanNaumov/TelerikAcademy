/// <reference path="../libs/require.js" />
/// <reference path="item.js" />

define(function () {
    var Store;
    Store = (function () {

        function Store(name) {
            if (!(name.length >= 6 && name.length <= 30)) {
                throw "Invalid name";
            }
            this.name = name;
            this.items = [];
        }
        
        Store.prototype.addItem = function (item) {

            this.items.push(item);
            return this;
        }

        Store.prototype.getAll = function () {
            return sortLexicographically(this.items);
            
        }

        Store.prototype.getSmartPhones = function () {
            sortLexicographically(this.items);
            var smartPhones = [];
            for (var i = 0; i < this.items.length; i++) {
                
                if (this.items[i].type === 'smart-phone') {
                    smartPhones.push(this.items[i]);
                }
            }

            return smartPhones;
        }

        Store.prototype.getMobiles = function () {
            sortLexicographically(this.items);
            var mobiles = [];

            for (var i = 0; i < this.items.length; i++) {

                if (this.items[i].type === 'smart-phone' || this.items[i].type === 'tablet') {
                    mobiles.push(this.items[i]);
                }
            }

            return mobiles;
        }

        Store.prototype.getComputers = function () {
            sortLexicographically(this.items);
            var computers = [];

            for (var i = 0; i < this.items.length; i++) {

                if (this.items[i].type === 'pc' || this.items[i].type === 'notebook') {
                    computers.push(this.items[i]);
                }
            }

            return computers;
        }

        Store.prototype.filterItemsByPrice = function (options) {
            var sortedByPrice = [];
            
            if (!options) {
                return this.items.sort(function (a, b) { return a.price - b.price; })
            }

            else if (options.min && !(options.max)) {
                
                for (var i = 0; i < this.items.length; i++) {

                    if (this.items[i].price >= options.min) {
                        sortedByPrice.push(this.items[i]);

                    }
                }

                return sortedByPrice.sort(function (a, b) { return a.price - b.price; })
            }
            
            else if (!(options.min) && options.max) {
                for (var i = 0; i < this.items.length; i++) {

                    if (this.items[i].price <= options.max) {
                        sortedByPrice.push(this.items[i]);

                    }
                }

                return sortedByPrice.sort(function (a, b) { return a.price - b.price; })
            }
            else {
                for (var i = 0; i < this.items.length; i++) {

                    if (this.items[i].price >= options.min && this.items[i].price <= options.max) {
                        sortedByPrice.push(this.items[i]);

                    }
                }

                return sortedByPrice.sort(function (a, b) { return a.price - b.price; })
            }
        }

        Store.prototype.filterItemsByType = function (type) {
            sortLexicographically(this.items);
            var filteredElements = [];
            for (var i = 0; i < this.items.length; i++) {
                
                if (this.items[i].type === type) {
                    filteredElements.push(this.items[i]);
                }
            }

            return filteredElements;
        }

        Store.prototype.filterItemsByName = function (name) {
            var sortedByName = [];

            for (var i = 0; i < this.items.length; i++) {
                
                if (this.items[i].name.toLowerCase().indexOf(name) != -1) {
                    sortedByName.push(this.items[i]);
                }
            }

            return sortedByName;
        }

        Store.prototype.countItemsByType = function () {
            var dict = [];

            for (var i = 0; i < this.items.length; i++) {

                if (!(this.items[i].type in dict)) {
                    dict[this.items[i].type] = 1;
                }
                else {
                    dict[this.items[i].type]++;
                }
            }
            return dict;
        }
        //private function
        function sortLexicographically(items) {
            return items.sort(function (a, b) { return a.name.localeCompare(b.name); })
        }

        return Store;
    }());
    return Store;
});