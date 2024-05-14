# EmergentChallenge

This is a challenge that I did where the ideia was to get all the version of software/application greater than the input that I provide.

For that I implement a service called "VersionService" where I validate if the inputed version is a valid input (like "1.0.2" and not "1,0.2"). I do that using Regex.

I also implemented this challenge via EntityFramework, so in case you wanna run that on your local DB, 
just change the ConnectionString in the ´appsettings.json´ and run the commands:
  - dotnet ef migrations add Initial --verbose --project Data  --startup-project EmergentWeb
  - dotnet ef database update --verbose --project Data  --startup-project EmergentWeb

  - 
