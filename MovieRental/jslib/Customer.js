const { get } = require("jquery");

app.controller("Customer", function ($scope, $http) {

    $scope.newdata = {
        Name = '',
        Age = null,
        Email = '',
        Phone = null,
        IsSubscribedToNewsLetter = false,
        MembershipTypeId = null
    }

    $scope.dataset = [];

    $scope.Load = [];

    $http({
        method: 'GET',
        url: 'https://localhost:44362/api/customer/getcustomers',
        dataType: "json"
    }).then(function (res) {
        if (res.data.IsSuccess && res.data.Data)
            $scope.Load = res.data.Data;

        else
            Swal.fire('Failed');
        
    })
})