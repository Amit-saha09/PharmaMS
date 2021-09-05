app.controller("customer_dashboard",function($scope,$http,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

   
    var id= sessionStorage.getItem("userid");
    ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    var q = resp.data;
    sessionStorage.setItem("ownid",q.id);

    ajax.get("https://localhost:44397/api/Cart/pending/"+q.id,success,error);
    function success(response){
      var pmedicine=response.data;
      sessionStorage.setItem("cartid",pmedicine.id);
    }
    function error(error){

    };
  },
  function(err){

  });
   
   
 

});