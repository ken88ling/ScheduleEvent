//schedulecontroller.js

(function() {

    "use strict";

    //getting existing module
    angular.module("app-schedule")
        .controller("scheduleController", scheduleController);

    function scheduleController($http) {

        var vm = this;
        vm.newEvent = {};

        vm.errorMessage = "";

        vm.getEvents= function() {
            $http.get("/api/events")
                .then(function (res) {
                    //success
                    angular.copy(res.data, vm.events);
                },
                    function (err) {
                        //failure
                        vm.errorMessage = "Failed to load data: " + err;
                    });
        }
        

        // call the calendar UI
        $('#calendar')
            .fullCalendar({
                height: 450,
                editable: true,
                displayEventTime: true,
                header: {
                    left: 'month,agendaWeek,agendaDay',
                    center: 'title',
                    right: 'today,prev,next'
                },
                timeFormat: {
                    month: ' ', // for hide on month view
                    agenda: 'h:mm t'
                },
                selectable: true,
                selectHelper: true,
                select: function() {
                    vm.SelectEvent();
                    vm.ShowModal();
                },
                eventClick:function() {
                    vm.eventClickInvoke();
                    vm.ShowModal();
                }
            });

        vm.SelectedEvent = null;

        vm.eventClickInvoke = function(e) {
            vm.SelectedEvent = e;
            var fromDate = moment(event.start).format('YYYY/MM/DD LT');
            var endDate = moment(event.end).format('YYYY/MM/DD LT');
            vm.newEvent = {
                EventId: e.id,
                StartAt: fromDate,
                EndAt: endDate,
                IsFullDay: false,
                Title: e.title,
                Description: e.description
            }

            alert(e.id + " " + e.title + " " + e.description);
        };

        vm.SelectEvent = function (start, end) {
            var fromDate = moment(start).format('YYYY/MM/DD LT');
            var endDate = moment(end).format('YYYY/MM/DD LT');
            vm.newEvent = {
                EventId: 0,
                StartAt: fromDate,
                EndAt: endDate,
                IsFullDay: false,
                Title: '',
                Description: ''
            };

            vm.ShowModal = function() {
                $('#myModal').modal('show');
            };

            

           

            vm.addEvent = function() {
                alert(vm.newEvent.Title);
            };
        }
    }
})();