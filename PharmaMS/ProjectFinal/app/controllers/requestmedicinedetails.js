app.controller("requestmedicinedetails",function($scope,$http,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    var id= sessionStorage.getItem("medid");
    ajax.get("https://localhost:44397/api/requestmedicines/"+id,success,error);
    function success(response){
      $scope.r=response.data;
    }
    function error(error){

    };

    $scope.updatemed = function(r){
        ajax.post("https://localhost:44397/api/requestmedicines/update/"+id,r,success,error);
    function success(response){
      $location.path("/adminrequestmedicineview");
    }
    function error(error){

    };
};
   



   

  

});