(function () {
    //define factory
    angular.module('psaApp').factory('PersonSearchFactory', PersonSearchFactory);
    PersonSearchFactory.$inject = ['$http','API_BASE_URL'];
    function PersonSearchFactory($http, API_BASE_URL) {
        var factory = {};
        $http.defaults.headers.post["Content-Type"] = "application/json";
        factory.Search = function (queryString) {
            return $http({
                method: "Get",
                url: API_BASE_URL + '/personSearch?queryString=' + queryString,
            });
        }
        return factory;
    }
})();