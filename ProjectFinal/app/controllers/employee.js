app.controller("employee",function($scope,$http,ajax){
  $scope.myVar= sessionStorage.getItem("usertype");

    ajax.get("https://localhost:44397/api/employees",success,error);
    function success(response){
      $scope.employee=response.data;
    }
    function error(error){

    }

});