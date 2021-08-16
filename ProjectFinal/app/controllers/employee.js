app.controller("employee",function($scope,$http,ajax){
    ajax.get("https://localhost:44397/api/employees",success,error);
    function success(response){
      $scope.employee=response.data;
    }
    function error(error){

    }

});