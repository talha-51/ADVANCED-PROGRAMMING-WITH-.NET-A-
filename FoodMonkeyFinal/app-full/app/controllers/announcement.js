app.controller("announcement",function($scope,$http){

    $http.get("https://localhost:44380/api/admin/announcement").
    then(function(resp){
        $scope.post = resp.data;
    });

});