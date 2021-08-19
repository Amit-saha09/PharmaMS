app.controller("medicineadd",function($scope,ajax,$location){



    $scope.addmed= function(r){

       ajax.post("https://localhost:44397/api/medicines/add",r,
       function(resp){

       },function(err){
          
       });

    };

  });
