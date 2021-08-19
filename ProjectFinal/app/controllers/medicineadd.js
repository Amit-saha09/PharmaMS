app.controller("medicineadd",function($scope,ajax,$location){

   $scope.r = {};

    $scope.addmed= function(r){


      var hasError = false;

      if(r.name == undefined || r.quantity == undefined || r.price == undefined || r.company == undefined ||
         r.description_id == undefined || r.medtype_id == undefined || r.medstatus_id == undefined)
          
      {
       hasError = true;
       $scope.err_both = "Please input all";
      } 


if(!hasError){
       ajax.post("https://localhost:44397/api/medicines/add",r,
       function(resp){

       },function(err){});
      }

    };

  });
