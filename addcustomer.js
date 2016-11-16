var customermodule = angular.module('CustomerModule', ['ngMessages']);

customermodule.controller('AddCustomerController', ['$scope', function ($scope) {

    $scope.customer = {
        Name: "",
        DOB: new Date(1990, 5, 5),
        Address: "",
        Email: "",
        PhoneNo: 0,
        SecretKey:""
     
    }

}]);
