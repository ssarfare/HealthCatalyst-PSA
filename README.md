# HealthCatalyst-PeopleSearchApplication

### Business Requirements 

1. The application accepts search input in a text box and then displays in a pleasing style a list of people where any part of their first or last name matches what was typed in the search box (displaying at least name, address, age, interests, and a picture).  
2. Solution should either seed data or provide a way to enter new users or both. 
3. Simulate search being slow and have the UI gracefully handle the delay.

### Technical Requirements 

1. A Web Application using WebAPI and a front-end JavaScript framework (e.g., Angular, React, etc.)  
2. Use an ORM framework to talk to the database 
3. Unit Tests for appropriate parts of the application 

### Prerequisits to run
1. Clone or download the source code.
2. Make sure the path you clone or download the source code to is not __too long__, it will cause error for packages to install.
3. Make sure the path you clone or download the source code to has __write access__. 


### Technical Details
###### Major Projects:
1. HealthCatalyst.PSA.WebUI - Front end web application created using ASP.NET Web Application (.NET Framework) and AngularJs.
2. HealthCatalyst.PSA.WebAPI - Web Api created with ASP.NET Web API.

* Used Entity Framework Code First Approach to create database on localDb.
* Used Ajax calls for making http requests.
* Testing performed with MSTest.
* Used Bootstrap 4 for UI design.
