app.controller("customerprofile",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

  var id= logid;

  ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    $scope.q = resp.data;
  },
  function(err){

  });

  $scope.updatecus = function(q){
      var cusid= q.id;
     ajax.post("https://localhost:44397/api/employees/update/"+cusid,q,
     function(resp){
          $location.path("/customer");
     },function(err){});

  };
  
});