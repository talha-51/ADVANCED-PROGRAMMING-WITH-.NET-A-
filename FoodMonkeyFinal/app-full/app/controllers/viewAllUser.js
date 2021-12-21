app.controller("viewAllUser",function($scope,$http){

    $http.get("https://localhost:44380/api/admin/viewAllUser").
    then(function(resp){
        $scope.post = resp.data;
    });

});