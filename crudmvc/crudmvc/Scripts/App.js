var myApp = angular.module('myApp', []);
myApp.controller('mainController', function ($scope,$http) {
    $http.get('/home/GetDatos')
    .success(function (result) {
        $scope.datosr = result;
    })
    .error(function (data) {
        console.log(data);
    });
    $scope.newdatos = "";
    $scope.addDato = function () {
        $http.post("/home/AddDatos/", { newdatos: $scope.newdatos })
        .success(function (result) {
            $scope.datosr = result;
            $scope.newdatos = "";
        })
        .error(function (data) {
            console.log(data);
        });
    }
});