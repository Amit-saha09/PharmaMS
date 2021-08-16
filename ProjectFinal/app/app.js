var app = angular.module("myApp", ["ngRoute"]);
var user="dog";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/login.html",
        controller:'login'
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
