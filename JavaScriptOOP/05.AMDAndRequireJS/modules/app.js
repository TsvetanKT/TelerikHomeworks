require.config({
    paths: {
        jquery: '../libs/jquery-2.1.1.min',
        handlebars: '../libs/handlebars',
        input: 'input',
        controls: 'controls'
    }
});

require(['jquery', 'handlebars', 'input', 'controls'], 
    function($, handlebars, input, controls) {

    var templateString = $('#combo-template').html();
    var template = Handlebars.compile(templateString);
    var comboBoxView = controls.ComboBox(input.getPeople());

    var ComboBoxHtml = comboBoxView.render(template);

    $('#boxes').html(ComboBoxHtml);
    $('#boxes').find('.box-list').on('click', 'li', function() {
        $(this).siblings().hide();
        $(this).addClass('selected');
    });

    $('#boxes').find('.box-list').on('click', 'li.selected', function() {
        $('li.selected').removeClass('selected');
        $(this).parent().children().show();
    });
});