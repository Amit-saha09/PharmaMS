app.controller("login",function($scope,ajax,$location){

    
  
    $scope.login = function(){

      
       
          $scope.usernameError = "";
        $scope.passwordError = "";

        var hasError = false;

      
      
        function validation(){
            if($scope.email == undefined)
            {
                $scope.usernameError = "username";
                hasError = true;
            }else if($scope.password == undefined)
            {
                $scope.passwordError = "password";
                hasError = true;
            }
        }

    
      
      
        validation();


         if(!hasError){
            var email= $scope.email;
            var password= $scope.password;
           ajax.get("https://localhost:44397/api/logins/get/"+email+"/"+password,
           function(response){
                logdata= response.data;
                if(logdata.email== email && logdata.password== password){
                   sessionStorage.setItem("userid",logdata.id);
                   sessionStorage.setItem("useremail",logdata.email);
                   sessionStorage.setItem("userpass",logdata.password);
                   if(logdata.usertype_id==1){
                       var admin="ADMIN";
                       sessionStorage.setItem("usertype",admin);
                       $location.path("/admin_dashboard")
                   }
                   else if(logdata.usertype_id==2){
                       var manager="MANAGER";
                       sessionStorage.setItem("usertype",manager);
                       $location.path("/manager_dashboard")
                   }
                   else {
                    var customer="CUSTOMER";
                    sessionStorage.setItem("usertype",customer);
                    $location.path("/customer_dashboard")
                }
               
                  
                  
                }
                else{
                    $location.path("/login");
                }
           },function(err){
    
           });
      
        }
    
    };
  });