# Class 27: Razor Pages

## Learning Objectives
1. Students will be introduced to Razor Pages. 
1. Students will be introduced to MVVM and how Razor Pages can live within an MVC application.
1. Students will learn about the `PageModel` and its function within Razor Pages.

## Lecture Outline

### Razor Pages

Razor Pages are new to .NET Core specifically and are an alternative architectural pattern to how your site is constructed. It still utulizes MVC and it's routing, but is more of an MVVM approach to web developement. 

The advantage of razor pages is there is a lot less "magic" happening. This means that we have a bit more control, as developers, of what is happening in the data flow pipeline. 

### Why

Razor Pages allow us to really utulize the "Single Responsibility" principle within practice. This means that we can gaurantee that our Models are really only doing "one" thing and only one thing. 

### How

Razor Pages are enabled through the startup file. 
1. Add `endpoints.MapRazorPages();` to your Startup file under `Configure()`
2. Create a `Pages` directory in the root of your site
3. Place all Razor Pages in this directory


`OnGet()` - The reserved method name that will retreive the data for the page on load.

`OnPost()` - The reserved method that gets called when a form is posted back to the Page Model. 

