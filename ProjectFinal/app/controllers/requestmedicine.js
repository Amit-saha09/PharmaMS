app.controller("requestmedicine",function($scope,ajax,$location){

   var id= logid;

   ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    $scope.r=resp.data;
  },
  function(err){

  });
 
     $scope.addremed= function(r){
         r.customer_id=customer.id;
         r.requeststatus_id= 3;
 
 
     
        ajax.post("https://localhost:44397/api/requestmedicines/add",r,
        function(resp){
 
        },function(err){

        });
       };
 });
 
 