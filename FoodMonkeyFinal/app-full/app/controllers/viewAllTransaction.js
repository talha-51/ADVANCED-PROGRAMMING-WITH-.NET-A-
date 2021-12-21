app.controller("viewAllTransaction",function($scope,$http){

    $http.get("https://localhost:44380/api/admin/orders").
    then(function(resp){
        $scope.post = resp.data;
    });

});