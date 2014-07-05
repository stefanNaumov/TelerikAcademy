/// <reference path="RequireJS.js" />
/// <reference path="handlebars-v1.3.0.js" />
/// <reference path="JQuery.js" />

define(['JQuery', 'Handlebars'], function () {
    var ComboBox = function (template, peopleList) {

        renderTemplate(template, peopleList);
        
    }
    function renderTemplate(template, PeopleList) {
        var compiledTemplate = Handlebars.compile(template);
        var selectedClass = 'selected';
        var collapsedClass = 'collapsed';
        var visibleClass = 'visible';

        var container = $('#container');
        for (var i = 0; i < PeopleList.length; i++) {

            $(compiledTemplate(PeopleList[i])).appendTo(container);
        }
       
        var areVisible = false;
        container.children().addClass(collapsedClass);
        container.children().first().addClass(visibleClass).addClass(selectedClass).removeClass(collapsedClass);

        container.children().on('click', function () {
            
            container.children().find('.selected').removeClass(selectedClass).removeClass(visibleClass);
            

            if (!areVisible) {
                container.children().removeClass(collapsedClass).addClass(visibleClass);
               
                areVisible = true;
            }
            else {
                container.children().removeClass(visibleClass).addClass(collapsedClass);
                $(this).addClass(visibleClass).addClass(selectedClass);
                areVisible = false;
            }
            $('.collapsed').hide();
            $('.visible').show();
        });
        
        $('.collapsed').hide();
        $('.visible').show();
        
    }
    return {
        generate: ComboBox
    }
});