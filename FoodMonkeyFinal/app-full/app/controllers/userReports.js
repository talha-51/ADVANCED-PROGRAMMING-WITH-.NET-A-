app.controller("userReports",function($scope,$http){

    $http.get("https://localhost:44380/api/admin/reports").
    then(function(resp){
        $scope.post = resp.data;
    });

});