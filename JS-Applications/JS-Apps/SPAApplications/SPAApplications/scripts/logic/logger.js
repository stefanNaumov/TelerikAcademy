/// <reference path="../libs/require.js" />
/// <reference path="../libs/jquery.js" />
define(['jquery', 'sammy'], function ($, sammy) {

    var app = function (targetObj) {
        $('#main-content').remove();
        return sammy(targetObj, function () {

            var nameLabel = $('<label/>').html('Username')
            .attr('id', 'nameLabel');

            var nameInput = $('<input/>')
                .attr('type','text')
            .attr('id', 'userName');

            var logBtn = $('<button/>').html('Log')
            .attr('id','logBtn');

            $(targetObj).append(nameLabel).append(nameInput).append(logBtn);
        });
    }
    return app;
});