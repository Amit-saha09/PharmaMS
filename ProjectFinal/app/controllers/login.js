app.controller("login",function($scope,ajax,$location){

    
  
    $scope.login = function(){
        var email= $scope.email;
        var password= $scope.password;
       ajax.get("https://localhost:44397/api/logins/get/"+email+"/"+password,
       function(response){
            logdata= response.data;
            if(logdata.email== email && logdata.password== password){
                logid= logdata.id;
                logemail=logdata.email;
                logpass=logdata.password;
                logtype=logdata.usertype;
                $location.path("/employeeprofile");
            }
            else{
                $location.path("/login");
            }
       },function(err){

       });
  
    };
  });