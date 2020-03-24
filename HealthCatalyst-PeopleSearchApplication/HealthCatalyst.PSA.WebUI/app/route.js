(function () {
    "use strict";
    //define states for routing
    angular.module('psaApp').config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: '/home',
            templateUrl: 'app/person-search/view/person.search.view.html',
        });
        $urlRouterProvider.otherwise('/home');
    }])
})();
