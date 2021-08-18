var app = angular.module("myApp", ["ngRoute"]);

app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"

    })

    .when("/emADD", {
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"

    })
    .when("/CustomerAdd", {
        templateUrl : "views/pages/CustomerAdd.html",
        controller: "CustomerAdd"
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
