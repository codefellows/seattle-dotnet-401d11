# Class 26: Intro to Identity

## Learning Objectives
1. Students will be introduced to Azure Dev Ops Project Management Tool 
1. Students will be introduced to ASP.NET Core Identity and successfully integrate it into an existing codebase. 

## Lecture Outline

### Azure Dev Ops

Azure Dev Ops is a popular tool that is used amongst 
many developer teams to manage source code and tasks of projects. 

We wil use Azure Dev Ops for the entirety of the E-Commerce project.
You will become comfortable with the environment and the tooling. 
You will learn how to make User Story cards, manage them through the 
KanBan board provided through weekly sprints. 

Resources:
1. [Azure Dev Ops](https://dev.azure.com/)
1. [Team Explorer Reference](https://docs.microsoft.com/en-us/azure/devops/user-guide/work-team-explorer?view=azure-devops)


### Identity

**Authentication** : Authentication is the process of determining **Who you are**

**Authorization** : Authorization revolves around **what you are allowed to do** (Example is permissions) 
 

### Integration

Integrating identity into your web application only takes a few steps. Many of them, you already know how to do.
1. Add the `app.UseAuthentication` into your `Configure()` method within your `Startup.cs` file. 
1. Create your Application User and derive it form `IdentityUser`. Add any additional properties that you wish to include with your user
1. Create your identity DBContext (derive a new `DBContext` from `IdentityDbContext<T>` (`T` should be your application user you created earlier)
1. Register your new database in the `Startup.cs` file
1. Register Identity into your `Startup.cs` file. (Switch out TUser and the DBContext with their respective names): 
    ```csharp
    services.AddIdentity<TUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
    ```
1. In future days, you will add the register/login functionality.


### End of Day Goal

By the end of today, you should have your Azure DevOps created with your ECommerce partner, and a very basic code base pushed up. Keep it simple, get familiar with Azure DevOps (ADO). 