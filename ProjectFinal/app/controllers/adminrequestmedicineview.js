app.controller("adminrequestmedicineview",function($scope,$http,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    ajax.get("https://localhost:44397/api/requestmedicines/admin",success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };
    $scope.setid = function(m){
     sessionStorage.setItem("medid",m.id);
    

  };

 

});