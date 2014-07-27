/// <reference path="../libs/require.js" />
/// <reference path="../libs/jquery.js" />


//TODO:code works but needs refactoring
define(['jquery', 'sammy'], function ($,sammy) {

    var app = function (targetEl, url, userName, loader,sender) {
        return sammy(targetEl, function () {

            this.get('#/about', function () {
                $('#chatWindow').remove();
                var about = $('<div>').html('This is some chat about tab, which is absolutely useless')
                .attr('id', 'about-tab-cont');

                $(targetEl).append(about);
            });

            this.get('#/chat', function () {

                $('#about-tab-cont').remove();

                var chatWindow = $('<div/>')
                    .html('Creepy Chat')
                    .attr('id', 'chatWindow');
                function loadData() {
                    
                    var getData = loader(url).then(function (data) {

                        var ul = $('<ul/>');
                        ul.attr('id', 'chatList');
                        for (var i = data.length - 1; i > data.length - 20; i--) {
                            var li = $('<li/>').html(data[i].by + ' : ')
                            .attr('id', 'chatListUser');
                            var span = $('<span/>').html(data[i].text)
                            .attr('id', 'chatListText');

                            li.append(span);
                            ul.append(li);
                        }
                        chatWindow.append(ul);
                    });
                    
                }
                function loadInput() {
                    console.log(56666666);
                    var inputBox = $('<input/>')
                       .attr('type', 'text')
                       .attr('id', 'userInput');

                    var sendBtn = $('<button/>')
                    .html('SEND')
                    .attr('id', 'sendBtn');
                    $(sendBtn).on('click', function () {
                        var input = $(inputBox).val();

                        var currPersonObj = {
                            user: userName,
                            text: input
                        };
                        sender(url, currPersonObj).then(function () {
                            $('#chatList').remove();
                            loadData();
                        });
                        $('#userInput').val('');
                    });
                    console.log(inputBox);
                    chatWindow.append(inputBox).append(sendBtn);
                }
                loadData();
                loadInput();

                setInterval(function () {
                    $('#chatList').remove();
                    loadData();
                }, 5000);

                $(targetEl).append(chatWindow);
            });
        });
    }
    return app;
});
