define(["jquery"], function($) {
    var controls = {};

    var ComboBox = function(items) {
        this.items = items;
    };

    ComboBox.prototype.render = function(template) {
        var $itemsList = $('<ul/>')
            .addClass('box-list');

        var len = this.items.length;

        var $listItem = $('<li/>');

        for (var i = 0; i < len; i += 1) {
            $listItem.attr('id', this.items[i].id);
            $listItem.html(template(this.items[i]));
            $itemsList.append($listItem.clone(true));
        }

        $itemsList.children().hide();

        $itemsList.children()
            .first()
            .addClass('selected')
            .show();

        return $itemsList;
    };

    controls.ComboBox = function(itemsSource) {
        return new ComboBox(itemsSource);
    };

    return controls;
});