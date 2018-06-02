This application is an ASP.NET Core 2.0 application using an MS SQL Database to store the data of persons, and using the MVC pattern 
to seperate the applacation code in models, Vievs and controllers.

The application is used for demostrate some of my skills as a Full Stack Developer and I did chose to use GIT and GitHub to get experience
with these greats tools.

1) Models

The model  "MydbContext" are mapping the columns from the MS Database into the class members of the model "PersonTableCoreTwoJS"
using EntityFramework. The two models can now be used in the controllers.

2) Controllers

The cotroller "PersonTableCoreTwoJSApController" are using the two models to get, put, post and delete data (CRUD)
in the database as well as showing the data in the Views (UI) by handling API calls and sending and returning JSON Data.

3) Views

The consuming parts of the Web API are done by making MVC Views containing AngularJS, ReactJS and jQuery as internal Web API clients.
As an example by clicking the Angular API link in the menu, you will make a request to the "AngularAPIController" which will display the coresponding View Index.cshtml
in the View folder called "AngularAPI". That View is the Angular Web API Client displaying JSON Dataset from the MS SQL Database.

In Addition to the Angular Web API Client there are clients made by React and jQuery.

The controller "PersonTableCoreTwoJSController" and the matching Views in the View folder "and "PersonTableCoreTwoJS" are also making 
CRUD operations to the Database but are using Razing and MVC, and are not Web API Clients.
Note: I only did use these Views and Controllers for testing everything was ready to make Web API Calls, and therefor I dont have
have a link in the menu to these Controllers.
