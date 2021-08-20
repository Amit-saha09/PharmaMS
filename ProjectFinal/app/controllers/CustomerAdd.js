app.controller("CustomerAdd",function($scope,ajax){
   $scope.myVar= sessionStorage.getItem("usertype");


   //$scope.q = {};

   var hasError ;

   function nameValidation(name){

      if(name == "undefined")
      {
         $scope.nameError = "Name must be fill";
         hasError =true;
      }
     
   }

    
   $scope.addem = function(q){
   
      $scope.nameError = "";
      nameValidation(q.name);

      if(!hasError){
       ajax.post("https://localhost:44397/api/logins/user/add",q,
       function(resp){

       },function(err){});

      }
    };
   

  });  
