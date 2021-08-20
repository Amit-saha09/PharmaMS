app.controller("customerrequestmedicineview",function($scope,$http,ajax,$location){
    var id= sessionStorage.getItem("userid");
    ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    var q = resp.data;
    sessionStorage.setItem("ownid",q.id);

    ajax.get("https://localhost:44397/api/requestmedicines/customer/"+q.id,success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };
  },
  function(err){

  });



   
   
 

});