# XamarinPasswordManagerApp



## General info
The PasswordManagerApp mobile version was created using Xamarin and C#. This app enable users to store sensitive data in a secure way. The main feature of this app is to check if stored password has previously appeared in data breach. 

The application can be developed, built and run cross-platform on Android and iOS.

Take your safe password wallet wherever you want

Features
- Store any amount of login data to external websites 
- Secure encryption with a symmetric key from a master password that only you know
- Check your data for compromise when adding or editing 
- If necessary, you can share your data with another user(experimental). 

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Features](#features)
* [Security](#security)
* [Configuration](#configuration)
* [Setup](#setup)
    * [Requirements](#requirements)
    * [Build](#to-run-this-project)
* [Usage](#usage)

## Technologies

* [Have I Been Pwned API](https://haveibeenpwned.com) - allows Internet users to check whether their personal data has been compromised by data breaches
* [JSON Web Token](https://jwt.io/) - defines a compact and self-contained way for securely transmitting information between parties as a JSON object
* [Quartz.NET](https://www.quartz-scheduler.net/) - job scheduling system
* [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) - library that allows server code to send asynchronous notifications to client-side web applications
* [Otp.NET](https://www.nuget.org/packages/Otp.NET) - an implementation of TOTP
* [Password Generator](https://www.nuget.org/packages/PasswordGenerator/) - library which generates random passwords

## Features

### Password pwned check

The web vault check every 5h or on user demand whether stored passwords have been compromised. To be more specific, system call
[Have I Been Pwned API](https://haveibeenpwned.com) to check if selected password has appeared in a data breach.


#
<p align="center"> <img src="https://i.ibb.co/Y7SF041/image.png" alt="imagepasscheck"></p>

Client application pass **only first 5 characters** of password hash to the [Have I Been Pwned API](https://haveibeenpwned.com)
 .As the response client received a set of matching records( password hash list followed by a count of how many times it appears in a data breach). What makes our app safe is client app can then search the result records for the presence of source hash. 

We do not send full password hash to the external API.



## Security

* After successfull authentication [server](https://github.com/PrzemyslawRodzik/PasswordManagerAppServer) generates tenable [JWT Token](https://jwt.io/) which gives user permission to access sensitive data
* [JWT Token](https://jwt.io/) payload is additionally encrypted
* Web vault check authenticity and integrity of JWT token
* Two-factor authentication
* Sensitive user data are encrypted with symmetric key( based on user's password hash) 
* User is notified in case of password breach or unauthorized login attempt
* User's passwords breach are checked in a secure way( More in [this](#password-pwned-check) paragraph)




## Configuration 
 To run this app first of all you''ll need to run *backend* [PasswordManagerApp server](https://github.com/PrzemyslawRodzik/PasswordManagerAppServer).
 

 
## Setup
### Requirements

- [Xamarin](https://dotnet.microsoft.com/apps/xamarin)

#### To run this project:

#
<div align="center" width=50%>
<a href="https://ibb.co/K2G5kpw"><img width="250" height="400" src="https://i.ibb.co/zX5mYTJ/Screenshot-1606384206.png" alt="Screenshot-1606384206" border="0"></a>
<a href="https://ibb.co/width="250" height="400" f9RHLs9"><img width="119" height="51" src="https://i.ibb.co/VxyT5sx/Screenshot-2020-11-23-14-04-50-74-bd6d1f84847f3f89a5743be6b0969a04-1.jpg" alt="Screenshot-2020-11-23-14-04-50-74-bd6d1f84847f3f89a5743be6b0969a04-1" border="0"></a>
<a href="https://ibb.co/vQhdQwz"><img width="250" height="400" src="https://i.ibb.co/5nkjnMc/Screenshot-2020-11-23-14-03-28-27-bd6d1f84847f3f89a5743be6b0969a04.jpg" alt="Screenshot-2020-11-23-14-03-28-27-bd6d1f84847f3f89a5743be6b0969a04" border="0"></a>

</div>





