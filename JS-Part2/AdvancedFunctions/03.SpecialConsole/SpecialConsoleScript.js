var SpecialConsole = (function () {

    function formatString(args) {
        if (args.length > 1) {

            var str = args[0].toString();

            for (var i = 1; i < args.length; i++) {
                str = str.replace("{" + (i - 1) + "}", args[1]);
            }
            return str;
        }
        return args[0];
    }
    return {

        writeLine: function () {
            console.log(formatString(arguments));
        },
        writeError: function () {
            console.error(formatString(arguments));
        },
        writeWarning: function () {
            console.warn(formatString(arguments));
        }
        
    }
})();