app.controller("login",function($scope,ajax,$location){

    
  
    $scope.login = function(s){
       ajax.get("https://localhost:44397/api/login/GetUser",s,
       function(resp){
        var login=response.data;
        if(login.email==s.email && login.password== s.password){
            user= login.usertype_type;
            $location.path("/");
        }
        else{
            $location.path("/login");
        }
       },function(err){});
  
    };
  });