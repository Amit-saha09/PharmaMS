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
<<<<<<< HEAD
        templateUrl : "views/pages/medicineadd.html",
        controller:"CustomerAdd"

=======
        templateUrl : "views/pages/medicinelist.html",
        controller:"medicinelist"
>>>>>>> d3804de90cc9f7d5e442184430d90388cce40830
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
<<<<<<< HEAD

=======
        
>>>>>>> d3804de90cc9f7d5e442184430d90388cce40830
    })

    .when("/emADD", {
        templateUrl : "views/pages/emADD.html",
        controller:"emADD"

    })
    .when("/medicineadd", {
        templateUrl : "views/pages/medicineadd.html",
        controller:"medicineadd"

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
