app.controller("emADD",function($scope,ajax){



    $scope.addem = function(p){

       ajax.post("https://localhost:44397/api/logins/user/add",p,
       function(resp){

       },function(err){});

    };

  });
