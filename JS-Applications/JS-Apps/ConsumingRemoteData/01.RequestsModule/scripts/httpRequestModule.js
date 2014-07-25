define(['jquery', 'q'], function ($, q) {

    function getJson(fileUrl) {
        var def = $.Deferred();
        $.ajax({
            url: fileUrl,
            type: 'GET',
            contentType:'application/json',
            dataType: 'json',
            success: function (data) {
                def.resolve(data);
            },
            error: function (error) {
                def.reject(error);
            }
        });
       
        
        return def.promise();
    }

    function postJson(fileUrl,personData) {
        var def = $.Deferred();

        $.ajax({
            url: fileUrl,
            type: 'POST',
            contentType: 'application/json',
            data: personData,
            dataType: 'json',
            success: function (data) {
                def.resolve(data);
            },
            error: function (data) {
                def.reject(data);
            }
        });

        return def.promise();
    }

    return {
        getJSON: getJson,
        postJSON: postJson
    };
});