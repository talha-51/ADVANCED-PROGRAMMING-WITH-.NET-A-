var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/adminHome.html",
        controller: 'adminHome',
    })
    .when("/viewAllUser", {
        templateUrl : "views/pages/viewAllUser.html",
        controller: 'viewAllUser'
    })
    .when("/viewAllTransaction", {
        templateUrl : "views/pages/viewAllTransaction.html",
          controller: 'viewAllTransaction'
    })
    .when("/userReports", {
        templateUrl : "views/pages/userReports.html",
        controller: 'userReports'
    })
    .when("/announcement", {
        templateUrl : "views/pages/announcement.html",
        controller: 'announcement'
    })
    .when("/addAdmin", {
        templateUrl : "views/pages/addAdmin.html",
        controller: 'addAdmin'
    })
    .when("/addAnnouncement", {
        templateUrl : "views/pages/addAnnouncement.html",
        controller: 'addAnnouncement'
    })
//     .when("/users", {
//         templateUrl : "views/pages/users.html",
//         controller: 'users',
        
        
//     })
//     .when("/primaryMenue", {
//         templateUrl : "views/pages/primaryMenue.html",
//         controller: 'primaryMenue',
        
        
//     })
//     .when("/fullMenue", {
//         templateUrl : "views/pages/fullMenue.html",
//         controller: 'fullMenue',
        
        
//     })
//     .when("/post/create", {
//         templateUrl : "views/pages/createpost.html",
//         controller: 'createpost',
        
        
//     })
//     .when("/home", {
//         templateUrl : "views/pages/home.html",
//         controller: 'home',
        
    
//     .when("/posts/:id", {
//         templateUrl : "views/pages/post.html",
//         controller: 'post',
        
//     })
    
//     .otherwise({
//         redirectTo:"/"
//     });
//       $locationProvider.html5Mode(true);
//       $locationProvider.hashPrefix('');
//       if(window.history && window.history.pushState){
//       $locationProvider.html5Mode(true);
//   }

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
})
