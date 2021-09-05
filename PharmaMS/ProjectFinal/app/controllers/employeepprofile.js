app.controller("employeeprofile",function($scope,ajax,$location){
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
 



       function dobValidation(dob){
          if(dob == undefined)
          {
             $scope.dobError = "dob must be fill";
             hasError =true;
          }
    }*/

    ajax.get("https://localhost:44397/api/employees/login/"+id,
    function(resp){
      $scope.q = resp.data;
    },
    function(err){

    });

    $scope.updateem = function(q){
        var cusid= q.id;




        /*
           $scope.nameError = "";
           $scope.dobError = "";
           $scope.bloodgroupError = "";
           $scope.genderError ="";
           $scope.ContactError ="";
           $scope.addresstError ="";
           $scope.salaryError ="";

           nameValidation(q.name);
           dobValidation(q.dob);
           bloodgroupValidation(q.bloodgroup);
           GenderValidation(q.gender);
           ContactValidation(q.contact);
           addressValidation(q.gender);
           salaryValidation(q.salary);





         if(!hasError){*/
       ajax.post("https://localhost:44397/api/employees/update/"+cusid,q,
       function(resp){
            $location.path("/employee");
       },function(err){});

    
   };

  });
