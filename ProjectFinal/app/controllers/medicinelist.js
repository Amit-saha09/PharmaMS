app.controller("medicinelist",function($scope,$http,ajax){
  $scope.myVar= sessionStorage.getItem("usertype");

    ajax.get("https://localhost:44397/api/medicines",success,error);
    function success(response){
      $scope.medicine=response.data;
    }
    function error(error){

    };
    $scope.setid = function(m){
     medid=m.id;

  };

  $scope.search = function(){
    var name= $scope.name;
    ajax.get("https://localhost:44397/api/medicines/name/"+name,
    function(response){
      $scope.medicine=response.data;

    },function(err){});

 };

});