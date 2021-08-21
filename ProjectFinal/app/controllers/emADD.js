app.controller("emADD",function($scope,ajax,$location){
   $scope.myVar= sessionStorage.getItem("usertype");


 
   //$scope.p = {};
   
   var hasError ;

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
      hasError = true;*/
}
 
    
      function dobValidation(dob){  
         if(dob == undefined)
         {
            $scope.dobError = "dob must be fill";
            hasError =true;
         }
   }
    

    $scope.updateem = function(p){
      $scope.nameError = "";
      $scope.dobError = "";
      $scope.bloodgroupError = "";
      $scope.genderError ="";
      $scope.ContactError ="";
      $scope.addresstError ="";
      $scope.salaryError ="";
      $scope.emailError ="";
      $scope.passwordError ="";
      nameValidation(p.name);
      dobValidation(p.dob);
      bloodgroupValidation(p.bloodgroup);
      GenderValidation(p.gender);
      ContactValidation(p.contact);
      addressValidation(p.address);
      salaryValidation(p.salary);
      emailValidation(p.email);
      passwordValidation(p.password);
 
     

      
         
      if(!hasError){
       ajax.post("https://localhost:44397/api/logins/user/add",p,
       function(resp){
          $location.path("/employee");


       },function(err){});
      }
    };
   


   });










   /* function validation(){
         if(p.name == undefined || p.dob == undefined || p.booldgroup == undefined || p.gender == undefined ||
            p.contact == undefined || p.address == undefined || p.salary == undefined || p.email == undefined ||
             p.password == undefined)
         {
          
          $scope.nameError = "Please input all";
          hasError = true;
         }  */