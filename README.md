Each api in microservices folder can be run with swagger ui. Enter the launchSettings.Json file, and then  change the commented line and the below line.
As an example, launchSettings.Json file in the CustomerApi folder;
//"launchUrl": "swagger/index.html",  
 "launchUrl": "customerapi/customer/get/3",
 
 For testing in Api Gateway, please undo changes. 
      
      
      
   