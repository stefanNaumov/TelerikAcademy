/// <reference path="../libs/require.js" />
/// <reference path="../libs/jquery.js" />
define(['jquery'], function ($) {
    var app = function (url) {
        var defer = $.Deferred();
        $.ajax({
            type: 'GET',
            url: url,
            contentType: 'application/json',
            success: function (data) {
                defer.resolve(data);
            },
            error: function (error) {
                defer.reject(error);
            }
        });
        return defer.promise();
    }
    return app;
});