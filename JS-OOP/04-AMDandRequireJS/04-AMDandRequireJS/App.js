
/// <reference path="JQuery.js" />
/// <reference path="RequireJS.js" />
'use strict';
(function () {
    require.config({
        paths: {
            'JQuery': 'JQuery',
            'Handlebars': 'handlebars-v1.3.0',
        }
    });

    require(["Init"], function (init) {
        init.init();
        
    });
}());

