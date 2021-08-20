app.controller("requestmedicinedetails",function($scope,$http,ajax,$location){
    var id= medid;
    ajax.get("https://localhost:44397/api/requestmedicines/"+id,success,error);
    function success(response){
      $scope.r=response.data;
    }
    function error(error){

    };

    $scope.updatemed = function(r){
        ajax.post("https://localhost:44397/api/requestmedicines/update/"+id,r,success,error);
    function success(response){
      $location.path("/adminrequestmedicine");
    }
    function error(error){

    };
};
   



   

  

});