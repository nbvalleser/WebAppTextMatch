angular.module('app', [])
    .controller('HomeController', ['$scope', '$http', function ($scope, $http) {

        var $ctrl = this;
        var data;

    $scope.LoadMatchResult = function (txt) {
        $http.post('/Home/MatchText', { MainText: txt.main, SubText: txt.sub }).then(
            function successCallBack(result) {
                $scope.getresult = result.data[0].displayresult;
                console.log(result.data[0].displayresult);
                /*alert($scope.getresult);*/
            },
            function errorCallBack() {
                console.log(result);
            });        
    };
}]);
