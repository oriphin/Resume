'use strict';

resumeApp.controller('resumeController',
    function resumeController($scope, resumeData) {

        $scope.resume = resumeData.resume;
        $scope.snippet = '<p>Driving inovative cutting edge applications, agile software development life cycles, best practices and patterns whilst offering mentoring and leadership to six software developers. </p><p> Improving software stability by automated unit tests, workflowed work items, automated build servers and aspect oriented programming</p>';
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
