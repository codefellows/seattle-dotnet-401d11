# Class 29: Policies

## Learning Objectives
1. Students will be able to Add/Assign roles to the application and user.
1. Students will be able to verify a user fits in a specific role.
1. Students will be able to Register a role based policy.
1. Students will be able to Create/Register custom claims based policies and register them with Dependency Injection.

## Lecture Outline

### Roles

Roles are important to applications because it allows us to group together users and give specific permissions to that group. Some companies use Azure Active Directory to manage their roles of their users, while others will create their own built in within the application. Since we don't have Azure Active Directory access, we will implement the roles manually into our app.

To add a user to role, we can add the following code. `user` must refer to a full ApplicationUser.
```csharp
await _userManager.AddToRoleAsync(user, ApplicationRoles.Admin);
```

To check if a user is in a specific role, we can do that like this:

```csharp
await _userManager.IsInRoleAsync(user, ApplicationRoles.Admin)
```

### Policies

Policies are important for us to be able to manage who accesses what parts of our site through certain "Rules" that we have in place. Much like a policy being a specific rule that must be followed within a business, a policy within a .NET Core Web App can be implemented on specific pages to restrict access to specific users given some claim or defining feature (for example: email address or age of user).

### Vocabulary

1.  IdentityRole: 
2.  Handler:
3.  Requirement:
