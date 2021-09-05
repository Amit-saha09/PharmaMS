app.controller("logout",function($scope,$http,ajax,$location){
    sessionStorage.clear();
 
  $location.path("/viewhomepage")
 
 });