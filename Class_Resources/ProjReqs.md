# Midterm Project - Week 5

Welcome to your midterm project! 

**READ THE ENTIRE DOCUMENT BEFORE STARTING YOUR PLANNING!**

## Requirements

Your midterm project is broken up into 2 smaller projects (Full stack CRUD MVC project and API project). Each project should live in it's own repo on GH (They can live in the same organization).
your Full CRUD web app will consume your custom API. You may use a 3rd party
API in addition, but it is not required. This may add some value to your project. 

Below are the requirements specific to each project, followed by requirements that both projects should contain. No templating is allowed for either projects. Both the Web App and API project should be created from an "empty" Web Project within Visual Studio. 

### Web App Requirements
1. Use the MVC Architectural pattern
	- Models
      - At least 2 Models
	  - Utilize dependency injection with the Repository Design Pattern for your whole project. Your project should contain:
		- At least 1 "Service"
		- At least 1 interface
	- Views 
      - `.cshtml` pages
	  - No scaffolding CRUD operations of the views. 
	  - You may use any CSS/Sass/JS front end technologies you wish, as long as they work well with all of the requirements.
	- Controllers
      - At least 2 Controllers
	  - No scaffolding or templating of controller with CRUD operations.
	  - Do not have your `DbContext` injected into your controllers. Your D.I. should be injecting your interface into the controllers for the basic CRUD operations.

1. Documentation (README)
     - Provide documentation for your web app. Include
     the work-flow, screen shots of the app, DB Schema, and basic
    functionality directions on how to use the site.

1. API Calls
	- You web app should make a call to at least 2 controllers from the API project. 

### Custom API
1. MVC architectural pattern
   - Have at least 2 Controllers
   - Have at least 2 Models
   - No Views Required
   - At least 2 Endpoints in each Controller
   - Utilize dependency injection with the Repository Design Pattern for your whole project.2. Documentation:
   - Use [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-2.1){:target="_blank"}  for your custom API Documentation.


### Shared Requirements
Both the Full stack MVC project and Web API project should **EACH** contain:

1. Written in C#

1. Testing:
  - Unit Tests
	- XUnit
	- Getters/Setters
	- API Endpoints (for API Team)
	- CRUD operations

1. Clearly commented code
	- Clearly document your code 
	- What does this code do?
	- Why do you have it?
	- Where is the request being sent?
	- What is the request expected response?
    - Use Summary Comments!

1. Database
  - SQL Server Database
  - At least 2 tables
  - Digital DB Schema (should be present in your Readme)
	- No Whiteboard images allowed.
  - Associations clearly defined

## Deployment Platform:
- Azure
- App Services
- SQL Server


## Out of Scope
The following is not permitted in the midterm project:

1. Absolutely no passwords. You **may not** implement any sort of Authentication and Authorization of passwords of any kind. Do not try and store passwords in your database...even if you try to "hash" them yourselves or use 3rd party hashings. Don't do it...seriously.

