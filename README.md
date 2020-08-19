# Carsales
A very small project written in .Net Core, Web Api and Angular 10, which covers the followings:

-NLayer 

*Presentation Layer: Provides an interface to the user. Uses the Application Layer to achieve user interactions.

*Application Layer: Mediates between the Presentation and Domain Layers. Orchestrates business objects to perform specific application tasks.

*Domain Layer: Includes business objects and their rules. This is the heart of the application.

*Infrastructure Layer: Provides generic technical capabilities that support higher layers mostly using 3rd-party libraries.

-Repository pattern

-Dependency Injection

-Integrating to Swagger for api documentation

Running instruction:

Carsales Api:

-.Netcore 3.1

-.EntityFrameworkCore 3.1.6

-Open the Carsales solution

-Set the Database Connection string in the appsettings.json

-Once you set the connection string properly all you need to do is running the Carsales.Api project and it will create the database with some contents for Car and Boats.

-Run (Ctrl+F5) the solution

-Browse to https://localhost:44391/swagger/index.html 

Carsales Angular:

-Angular 10

-Browse to the Carsales \Angular\Carsales.Client\ClientApp folder in CMD

-You need to restore package.json via npm or Yarn

-execute the "npm start" command

-Browse to https://localhost:4200

and ... DONE!
