'use strict';

resumeApp.controller('resumeController',
    function resumeController($scope, resumeData) {

        $scope.person = resumeData.person;
        //$scope.sigRResponce = "";
        //$scope.greetAll = function () {
        //    eventData.sendRequest();
        //}

        //$scope.updateGreetingMessage = function (text) {
        //    $scope.sigRResponce = text;
        //}

        //eventData.initialize($scope.updateGreetingMessage);

    }
);
