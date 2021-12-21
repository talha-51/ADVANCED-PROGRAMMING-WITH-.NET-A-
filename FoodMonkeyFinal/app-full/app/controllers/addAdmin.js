app.controller('addAdmin',function($scope,ajax){

    $scope.submit = function(){
        var data = {
            name: $scope.name,
            email: $scope.email,
            password: $scope.password,
            type: "admin",
            phone_number: $scope.phone_number,
            status: "active",
            NID_number: $scope.NID_number,
            area: $scope.area,
            address: $scope.address
        };
        console.log(data);
        ajax.post("https://localhost:44380/api/admin/addAdmin",data,success,error);

        function success(resp){
            alert("New Admin Added");
            console.log(resp);
        }
        function error(err){
            alert("Failed to Add Admin");
        }
    }
})