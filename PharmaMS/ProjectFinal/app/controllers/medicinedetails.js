



app.controller("medicinedetails",function($scope,$http,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

    var id= medid;
    ajax.get("https://localhost:44397/api/medicines/"+id,success,error);
    function success(response){
      $scope.r=response.data;
    }
    function error(error){

    };

    $scope.updatemed = function(r){
        ajax.post("https://localhost:44397/api/medicines/update/"+id,r,success,error);
    function success(response){
      $location.path("/medicinelist");
    }
    function error(error){

    };
};
   



    $scope.delete = function(r){
        ajax.get("https://localhost:44397/api/medicines/delete/"+id,success,error);
    function success(response){
      $location.path("/medicinelist");
    }
    function error(error){
    };

    };
   

  

});