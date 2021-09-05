app.controller("customerprofile",function($scope,ajax,$location){
  $scope.myVar= sessionStorage.getItem("usertype");

  var id= sessionStorage.getItem("userid");

 /* var hasError ;

   function nameValidation(name){
      if(name == undefined)
      {
         $scope.nameError = "Name must be fill";
         hasError =true;
      }
      else if(name.split(" ").length < 2){
         $scope.nameError = "Must contain atleast 2 words!";
         hasError = true;
     }
   }
   function bloodgroupValidation(bloodgroup){
      if(bloodgroup == undefined)
      {
         $scope.bloodgroupError = "blood group must be fill";
         hasError =true;
      }
   }
   function GenderValidation(gender){
      
      
         if(gender == undefined)
         {
            $scope.genderError = "Gender must be fill";
            hasError =true;
         }
      
   }
   function ContactValidation(contact){
      
      
      if(contact == undefined)
      {
         $scope.contactError = "Contact must be fill";
         hasError =true;
      }
   
}
function addressValidation(address){
      
      
   if(address == undefined)
   {
      $scope.addressError = "address must be fill";
      hasError =true;
   }

}
function salaryValidation(salary){
      
      
   if(salary == undefined)
   {
      $scope.salaryError = "salary must be fill";
      hasError =true;
   }

}
function emailValidation(email){
      
      
   if(email == undefined)
   {
      $scope.emailError = "email must be fill";
      hasError =true;
   }
   else if(email.split(" ").length > 1){
      $scope.emailError = "Invalid email!";
      hasError = true;
  }
  else if(email.includes("@")==false){
      $scope.emailError = "Invalid email!";
      hasError = true;
  }

}
function passwordValidation(password){
      
      
   if(password == undefined)
   {
      $scope.passwordError = "password must be fill";
      hasError =true;
   } /*else if(password.split(" ").length > 1){
      $scope.passwordError = "Can not contain space!";
      hasError = true;
}
 
    
      function dobValidation(dob){  
         if(dob == undefined)
         {
            $scope.dobError = "dob must be fill";
            hasError =true;
         }
   }
*/
  ajax.get("https://localhost:44397/api/customers/login/"+id,
  function(resp){
    $scope.q = resp.data;
  },
  function(err){

  });

  $scope.updatecus = function(q){
   
      var cusid= q.id;

      $scope.nameError = "";
      $scope.dobError = "";
      $scope.bloodgroupError = "";
      $scope.genderError ="";
      $scope.ContactError ="";
      $scope.addresstError ="";
     
      $scope.emailError ="";
      $scope.passwordError ="";
      nameValidation(q.name);
      dobValidation(q.dob);
      bloodgroupValidation(q.bloodgroup);
      GenderValidation(q.gender);
      ContactValidation(q.contact);
      addressValidation(q.address);
      
      emailValidation(q.email);
      passwordValidation(q.password);

      if(!hasError){
     ajax.post("https://localhost:44397/api/employees/update/"+cusid,q,
     function(resp){
          $location.path("/customer_dashboard");
     },function(err){});
   }
  };
  
});