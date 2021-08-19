app.controller("login",function($scope,ajax,$location){

    
  
    $scope.login = function(){

      
       
         
            var email= $scope.email;
            var password= $scope.password;
           ajax.get("https://localhost:44397/api/logins/get/"+email+"/"+password,
           function(response){
                logdata= response.data;
                if(logdata.email== email && logdata.password== password){
                   sessionStorage.setItem("userid",logdata.id);
                   sessionStorage.setItem("useremail",logdata.email);
                   sessionStorage.setItem("userpass",logdata.password);
                   sessionStorage.setItem("usertype",logdata.usertype);
                    $location.path("/employeeprofile");
                }
                else{
                    $location.path("/login");
                }
           },function(err){
    
           });
      
        
    
    };
  });




  /* var hasError = false;
       if(email == undefined)
       {
           hasError = true;
           $scope.err_email = "Please input the email"
       }else if(password == undefined){
        hasError = true;
        $scope.err_password = "Please input the password"
       }else if(email == undefined && password == undefined)
       {
        hasError = true;
        $scope.err_both = "Please input the email and password"
       }*/