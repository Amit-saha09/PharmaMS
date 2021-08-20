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
      templateUrl : "views/pages/medicineadd.html",
      controller:"medicineadd"
    })

    .when("/admin_dashboard", {
        templateUrl: "views/pages/admin_dashboard.html",
        controller: "admin_dashboard"
    })

    .when("/manager_dashboard", {
        templateUrl: "views/pages/manager_dashboard.html",
        controller: "manager_dashboard"
    })
    
    .when("/mycart",{
        templateUrl: "views/pages/mycart.html",
        controller: "mycart"
    })

    .when("/shop",{
        templateUrl: "views/pages/shop.html",
        controller: "shop"
    })


    .when("/customer_dashboard",{
        templateUrl: "views/pages/customer_dashboard.html",
        controller: "customer_dashboard"
    })

    .when("/customerrequestmedicineview",{
        templateUrl: "views/pages/customerrequestmedicineview.html",
        controller: "customerrequestmedicineview"
    })
    .when("/requestmedicine", {
        templateUrl : "views/pages/requestmedicine.html",
        controller:"requestmedicine"
    })

    .when("/adminrequestmedicineview", {
        templateUrl : "views/pages/adminrequestmedicineview.html",
        controller:"adminrequestmedicineview"
    })

    .when("/managerrequstmedicineview", {
        templateUrl : "views/pages/managerrequstmedicineview.html",
        controller:"managerrequstmedicineview"
    })

    .when("/requestmedicinedetails", {
        templateUrl : "views/pages/requestmedicinedetails.html",
        controller:"requestmedicinedetails"
    })

    .when("/medicinelist", {

        templateUrl : "views/pages/medicinelist.html",
        controller:"medicinelist"
    })


    .when("/passwordchange", {

        templateUrl : "views/pages/passwordchange.html",
        controller:"passwordchange"
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
