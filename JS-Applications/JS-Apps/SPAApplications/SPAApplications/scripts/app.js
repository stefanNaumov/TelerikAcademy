/// <reference path="libs/require.js" />
/// <reference path="libs/sammy.js" />

require.config({
    paths: {
        jquery: 'libs/jquery',
        sammy: 'libs/sammy',
        renderer: 'logic/chatRenderer',
        logger: 'logic/logger',
        loadData: 'logic/loadData',
        sendData:'logic/sendData'
    }
});
require(['jquery', 'sammy','renderer','logger','loadData','sendData'], function ($, sammy,renderer,logger,loader,sender) {

    var url = 'http://crowd-chat.herokuapp.com/posts';

    var log = logger('#logger');
    log.run();
    $('#logBtn').on('click', function () {
        var userName = $('#userName').val();
        sessionStorage.setItem('username', userName);
        if (userName.length > 1) {
            $('#logger').remove();

            $('body').append($('<div/>').attr('id', 'main-content'));

           

            var chatAnch = $('<a/>').html('Chat')
            .attr('href', '#/chat');


            var aboutAnch = $('<a/>').html('About')
            .attr('href', '#/about');

            $('#main-content')
                .append(chatAnch)
                .append(aboutAnch);
            var app = renderer('#main-content', url, userName,loader,sender);

            app.run('#/chat');
        }
        else {
            alert('Invalid username!');
        }
    });
});