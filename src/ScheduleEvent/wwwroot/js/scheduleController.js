//schedulecontroller.js

(function() {

    "use strict";

    //getting existing module
    angular.module("app-schedule")
        .controller("scheduleController", scheduleController);

    function scheduleController() {

        var vm = this;

        $('#calendar')
            .fullCalendar({
                weekends: true,
                dayClick:function() {
                    alert("a day has been clicked");
                }

    });

        vm.events = [
        {
            Title: 'Test title',
            Description: 'this is a description',
            StartAt: new Date(2016,10,19,18),
            EndAt: new Date(2016,10,19,22),
            IsFullDay: false
        }, {
            Title: 'Test title2',
            Description: 'this is a description2',
            StartAt: new Date(),
            EndAt: new Date(),
            IsFullDay: false
        }];

       
    }

})();