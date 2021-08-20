app.controller("passwordchange",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    var id= logid;
  
    ajax.get("https://localhost:44397/api/logins/user/get/"+id,
    function(response){
      $scope.p = response.data;
    },
    function(err){
  
    });
  
    $scope.change = function(p){
        var cusid= p.id;
       ajax.post("https://localhost:44397/api/logins/user/update/password/"+cusid,p,
       function(resppnse){
            $location.path("/customer");
       },function(err){});
  
    };
    
  });