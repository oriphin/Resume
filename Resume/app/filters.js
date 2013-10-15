'use strict';

resumeApp.filter('between', function () {
    return function (items, startyear, endyear) {
        return items.filter(function (element, index, array) {
            return element.indexyear >= startyear && element.indexyear <= endyear;
        });
    }
});