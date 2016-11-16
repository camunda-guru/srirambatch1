var customermodule = angular.module('CustomerModule', ['ngMessages']);

customermodule.controller('AddCustomerController', ['$scope','$http', function ($scope,$http) {

    $scope.customer = {
        Name: "",
        DOB: new Date(1990, 5, 5),
        Address: "",
        Email: "",
        PhoneNo: 0,
        SecretKey:""
     
    }
    $scope.submit=function()
    {
        console.log("Customer data reaching....");
        console.log($scope.customer);

        $http({
            method: 'post',
            datatype: 'jsonp',
            params: { CustomerData: $scope.customer },
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'

            },
            url: 'http://localhost:39189/Customers'

        }).success(function (data) {
            //$scope.result = JSON.parse(data);
            console.log(data);

        });

    }

}]);
