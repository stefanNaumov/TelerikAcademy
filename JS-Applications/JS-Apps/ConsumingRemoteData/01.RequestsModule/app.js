/// <reference path="scripts/require.js" />

'use strict';
require.config({
    paths: {
        'jquery': 'scripts/jquery',
        'q': 'scripts/q',
        'httpRequest':'scripts/httpRequestModule'
    }
});

require(['httpRequest'], function (req) {

    $('#getBtn').on('click', getData);
    function getData(){
        req.getJSON('scripts/data.js').then(function (data) {
            var ul = $('<ul/>');
            for (var i = 0; i < data.length; i++) {
                var li = $('<li/>');
                li.append('Name: ');
                var span = $('<span/>');
                span.append(data[i].firstName + ' ' + data[i].lastName);

                li.append(span);
                ul.append(li);
            }

            ul.appendTo('#output');
        });
    }
});