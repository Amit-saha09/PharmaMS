app.controller("medicineadd",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");









//   $scope.r = {};
//$scope.p = {};

var hasError ;

function nameValidation(name){
   if(name ==="")
   {
      $scope.nameError = "Name must be fill";
      hasError =true;
   }
   else if(name.split(" ").length < 2){
      $scope.nameError = "Must contain atleast 2 words!";
      hasError = true;
  }
}
function quantityValidation(quantity){


if(quantity == undefined)
{
   $scope.quantityError = "quantity must be fill";
   hasError =true;
}

}

function priceValidation(price){


if(price == undefined)
{
   $scope.priceError = "price must be fill";
   hasError =true;
}

}

function companyValidation(company){


if(company == undefined)
{
   $scope.companyError = "company must be fill";
   hasError =true;
}

}
function descriptionValidation(description){


if(description == undefined)
{
   $scope.descriptionError = "Description must be fill";
   hasError =true;
}

}

function medtype_idValidation(medtype_id){


if(medtype_id == undefined)
{
   $scope.medtype_idError = "medtype id must be fill";
   hasError =true;
}

}
function medstatus_idValidation(medstatus_id){


if(medstatus_id== undefined)
{
   $scope.medstatus_idError = "medicine Status must be fill";
   hasError =true;
}

}

$scope.addmed = function(r){
  $scope.nameError = "";
  $scope.quantityError = "";
  $scope.priceError = "";
  $scope.companyError ="";
  $scope.descriptionError ="";
  $scope.medtype_idError ="";
  $scope.medstatus_idError ="";

  nameValidation(r.name);
  quantityValidation(r.quantity);
  priceValidation(r.price);
  companyValidation(r.company);
  descriptionValidation(r.description);
  medtype_idValidation(r.medtype_id);
  medstatus_idValidation(r.medstatus_id);



if(!hasError){
       ajax.post("https://localhost:44397/api/medicines/add",r,
       function(resp){

       },function(err){});
      }

    };

  });
