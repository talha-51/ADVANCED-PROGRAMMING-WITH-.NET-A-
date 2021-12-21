app.controller('addAnnouncement',function($scope,ajax){

    $scope.submit = function(){
        var data = {
            admin_id: $scope.admin_id,
            description: $scope.description,
            status: "active"
        };
        console.log(data);
        ajax.post("https://localhost:44380/api/admin/addAnnouncement",data,success,error);

        function success(resp){
            alert("New Announcement Added");
            console.log(resp);
        }
        function error(err){
            alert("Failed to Add Announcement");
        }
    }
})