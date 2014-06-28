var specialConsole = (function () {

    function formatInput(args) {

        if (args.length > 1) {

            var messageStr = args[0];

            for (var i = 1; i < args.length; i++) {
                messageStr = messageStr.replace('{' + (i - 1) + '}', args[i]);
            }
            return messageStr;
        }
        return args[0];
    }

    return {
        writeLine: function () {
            console.log(formatInput(arguments));
        },
        warn: function(){
            console.log(formatInput(arguments))
        },
        error: function () {
            console.log(formatInput(arguments));
        }
    }
}());