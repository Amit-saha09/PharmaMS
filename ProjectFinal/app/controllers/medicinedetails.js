



app.controller("medicinedetails",function($scope,$http,ajax,$location){
    var id= medid;
    ajax.get("https://localhost:44397/api/medicines/"+id,success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };

    $scope.updatemed = function(m){
        ajax.post("https://localhost:44397/api/medicines/update/"+id,success,error);
    function success(response){
      $location.path("/medicinelist");
    }
    function error(error){

    };
};
   



    $scope.delete = function(m){
        ajax.get("https://localhost:44397/api/medicines/delete/"+id,success,error);
    function success(response){
      $location.path("/medicinelist");
    }
    function error(error){
    };

    };
   

  

});