app.controller("employeeprofile",function($scope,ajax,$location){
    var id= sessionStorage.getItem("userid");

    ajax.get("https://localhost:44397/api/employees/login/"+id,
    function(resp){
      $scope.q = resp.data;
    },
    function(err){
  
    });
  
    $scope.updateem = function(q){
        var cusid= q.id;
       ajax.post("https://localhost:44397/api/employees/update/"+cusid,q,
       function(resp){
            $location.path("/employee");
       },function(err){});
  
    };
    
  });