app.controller('createpost',function($scope,ajax){
    $scope.submit = function(){
        // alert("submitted");

        var data ={
            title: $scope.title,
            body: $scope.body,
            userId: 1

        }
        // console.log(data);
        ajax.post("https://jsonplaceholder.typicode.com/posts/",data,success,error);
        
        function success(resp){
            console.log(resp);
         }

          function error(err){
             console.log(err);
          }





        //  $scope.post
        // ajax.post("https://jsonplaceholder.typicode.com/posts/",data,success,error);

        // function success(resp){
        //     console.log(resp);
        // }
                
        // function error(err){
        //     console.log(err);
        // }

       
    };
});
