app.controller("requestmedicine",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");


   var id= sessionStorage.getItem("userid");


   ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    logdata=resp.data;
    sessionStorage.setItem("ownid",logdata.id);
  },
  function(err){

  });
 
     $scope.addremed= function(r){
         r.customer_id=sessionStorage.getItem("ownid");
         r.requeststatus_id=3;
        
 
     
        ajax.post("https://localhost:44397/api/requestmedicines/add",r,
        function(resp){

 
        },function(err){

        });
       };
 });
 
 