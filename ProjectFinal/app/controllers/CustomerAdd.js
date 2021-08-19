app.controller("CustomerAdd",function($scope,ajax){



    $scope.addem = function(q){

       ajax.post("https://localhost:44397/api/logins/user/add",q,
       function(resp){

       },function(err){});

    };

  });
