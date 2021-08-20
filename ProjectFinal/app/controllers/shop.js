app.controller("shop",function($scope,$http,ajax){
    var cus2id= sessionStorage.getItem("ownid");
    var cart= sessionStorage.getItem("cartid");
    ajax.get("https://localhost:44397/api/medicines",success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };

    $scope.add = function(m){
       
        ajax.post("https://localhost:44397/api/Cartitem/Add/"+cart,m,
        function(response){
          
    
        },function(err){});
    
     };
   

});