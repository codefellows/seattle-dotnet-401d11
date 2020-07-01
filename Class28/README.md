# Class 28: Claims

## Learning Objectives
1. Students will be introduced to the differences between a Claim/Identity/Principle
1. Students will learn what a Claim is and why they are used. 
1. Students will learn how to Add/Create a Claim for a user and inject them into a View.

## Lecture Outline

### Authorize Tags

There may be use-cases where you want to make specific pages within your web-app to only be accessible by registered users who are logged in. These tags are placed either at the top, above the class declaration, or above the individual actions within a controller.

1. `[Authorize]`: Only registered logged in users can access
2. `[AllowAnonymous]`: Users who are not logged in can access these page. This is the default behavior. 


### Identity Components
The Identity API is made up of three main components:

1. Claims - A claim is an individual piece of information that can be attached to a user for security or authentication purposes.
2. Identity - An identity contains many claims.
3. Principle - A principle contains many identities. 

