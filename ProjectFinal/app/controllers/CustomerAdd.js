app.controller("CustomerAdd",function($scope,ajax){

   $scope.q = {};
 
   $scope.addem = function(q){

      var hasError = false;
      if(q.name == undefined || q.dob == undefined || q.booldgroup == undefined || q.gender == undefined ||
         q.contact == undefined || q.address == undefined || q.salary == undefined || q.email == undefined ||
          q.password == undefined)
      {
       hasError = true;
       $scope.err_both = "Please input all";
      } 

      if(!hasError){
       ajax.post("https://localhost:44397/api/logins/user/add",q,
       function(resp){

       },function(err){});

      }
    };
   

  });  
