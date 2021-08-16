app.controller("customer",function($scope,$http,ajax){
    ajax.get("https://localhost:44397/api/customers",success,error);
    function success(response){
      $scope.customer=response.data;
    }
    function error(error){

    }

});