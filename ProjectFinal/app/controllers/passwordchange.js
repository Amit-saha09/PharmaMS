app.controller("passwordchange",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    var id= sessionStorage.getItem("userid");
  
    


    var hasError ;
    function emailValidation(email){
      
      
      if(email == undefined)
      {
         $scope.emailError = "salary must be fill";
         hasError =true;
      }
   
   }
   function passwordValidation(salary){
      
      
    if(password == undefined)
    {
       $scope.passwordError = "salary must be fill";
       hasError =true;
    }
 
 }
 function confirmpasswordValidation(salary){
      
      
  if(confirmpassword == undefined)
  {
     $scope.confirmpasswordError = "salary must be fill";
     hasError =true;
  }

}
    ajax.get("https://localhost:44397/api/logins/user/get/"+id,
    function(response){
      $scope.p = response.data;
    },
    function(err){
  
    });
  
    $scope.change = function(p){
        var cusid= p.id;
        $scope.confirmpasswordError ="";
        $scope.passwordError ="";
        $scope.emailError = "";
        emailValidation(p.email);
        passwordValidation(p.password);
        confirmpasswordValidation(p.confirmpassword);

        if(!hasError){
       ajax.post("https://localhost:44397/api/logins/user/update/password/"+cusid,p,
       function(resppnse){
            $location.path("/logout");
       },function(err){});
      }
    };
    
  });