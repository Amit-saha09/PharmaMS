var app = angular.module("myApp", ["ngRoute"]);
var logdata;

app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
<<<<<<< HEAD
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"

=======
        templateUrl : "views/pages/login.html",
        controller:"login"
        
>>>>>>> a2f7fc55d592417e0c73122ac65e813fce73ed2b
    })

    .when("/emADD", {
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"

    })
<<<<<<< HEAD
    .when("/CustomerAdd", {
        templateUrl : "views/pages/CustomerAdd.html",
        controller: "CustomerAdd"
=======

    .when("/login", {
        templateUrl : "views/pages/login.html",
        controller:"login"
        
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
>>>>>>> a2f7fc55d592417e0c73122ac65e813fce73ed2b
    })
    .when("/demo2", {
        templateUrl : "views/pages/demo2.html",
          controller: 'demo2'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'

    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
