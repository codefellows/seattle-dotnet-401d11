# Class 33: IEmailSender/Sendgrid

## Learning Objectives
1. Students will learn about generating and sending emails from their site.
1. Students will learn about SendGrid email crafting.

## Lecture Outline

### Sendgrid

1. What are email servers?
2. What do they do?
3. How/Why do we use them?
4. What is SendGrid?

Sendgrid is used as an email service for many sites. This allows us to send emails from our web app. ASP.NET Core can successfully do this through installing the right NuGet package of SendGrid and setting up some basic code send out an email:


```csharp
SendGridClient client = new SendGridClient(Configuration["SendGridKey"]);
SendGridMessage msg = new SendGridMessage();

msg.SetFrom("admin@cfblogposts.com", "Blog Admin");
msg.AddTo(email);
msg.SetSubject(subject);
msg.AddContent(MimeType.Html, htmlMessage);

await client.SendEmailAsync(msg);
```