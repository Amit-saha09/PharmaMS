app.controller("mycart",function($scope,$http,ajax,$location){
    var cus2id= sessionStorage.getItem("ownid");
    var cart= sessionStorage.getItem("cartid");
    ajax.get("https://localhost:44397/api/Cartitem/GetAll/"+cart,success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };
    $scope.delete = function(m){
       
        ajax.get("https://localhost:44397/api/Cartitem/Delete/"+m.id,
        function(response){
          $location.path("/mycart")
    
        },function(err){});
    
     };
});