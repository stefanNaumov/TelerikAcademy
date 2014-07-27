/// <reference path="../libs/require.js" />
/// <reference path="../libs/jquery.js" />

define(['jquery'], function ($) {
    var app = function (sendUrl,data) {
        var defer = $.Deferred();

        $.ajax({
            url: sendUrl,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (data) {
                defer.resolve(data);
            },
            error: function (error) {
                defer.reject(error)
            }
        });
        return defer.promise();
    }
    return app;
});