app.controller("managerrequstmedicineview",function($scope,$http,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    ajax.get("https://localhost:44397/api/requestmedicines/manager",success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };
   
 

});