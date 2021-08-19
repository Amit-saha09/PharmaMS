app.controller("emADD",function($scope,ajax){

   $scope.p = {};

    $scope.updateem = function(p){
       
      var hasError = false;
      
      /*if(p.name== undefined)
      {
         hasError = true;
         $scope.err_both = "Please input all";
      }*/
      
      if(p.name == undefined || p.dob == undefined || p.booldgroup == undefined || p.gender == undefined ||
         p.contact == undefined || p.address == undefined || p.salary == undefined || p.email == undefined ||
          p.password == undefined)
      {
       hasError = true;
       $scope.err_both = "Please input all";
      } 
      
      if(!hasError){
       ajax.post("https://localhost:44397/api/logins/user/add",p,
       function(resp){

       },function(err){});
      }
    };
   

  });
