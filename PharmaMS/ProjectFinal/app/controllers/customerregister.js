app.controller("customerregister",function($scope,ajax,$location){
    $scope.myVar= sessionStorage.getItem("usertype");




    $scope.addcustomer = function(p){

       ajax.post("https://localhost:44397/api/logins/user/customer/add",p,
       function(resp){
           $location.path("/login");

       },function(err){});

    };

  });
