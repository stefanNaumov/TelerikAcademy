/// <reference path="RequireJS.js" />
/// <reference path="JQuery.js" />
/// <reference path="ComboBox.js" />

'use strict';
define(['ComboBox','PeopleData','JQuery'], function (ComboBox,data) {
    
    var init = function () {
        var template = $('#template').html();
        
        var comboBox = ComboBox.generate(template, data);
    };

    return {
        init: init
    }
});