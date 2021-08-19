var app = angular.module("myApp", ["ngRoute"]);
var logdata;
var logid;
var logemail;
var logpass;
var logtype;
var medid;


app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/medicinelist.html",
        controller:"medicinelist"
    })


    .when("/customerregister", {
        templateUrl : "views/pages/customerregister.html",
        controller:"customerregister"
        
    })

    .when("/customerprofile", {
        templateUrl : "views/pages/customerprofile.html",
        controller:"customerprofile"
        
    })

    .when("/employeeprofile", {
        templateUrl : "views/pages/employeeprofile.html",
        controller:"employeeprofile"
        
    })

    .when("/medicinedetails", {
        templateUrl : "views/pages/medicinedetails.html",
        controller:"medicinedetails"
        
    })

    .when("/emADD", {
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"
        
    })

    .when("/login", {
        templateUrl : "views/pages/login.html",
        controller:"login"

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
