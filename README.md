# DuolingoNET
[![NuGet](https://img.shields.io/nuget/v/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)
[![NuGet](https://img.shields.io/nuget/dt/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)

Unofficial .NET Core Duolingo (https://www.duolingor.com/) API. Available as a [NuGet package](https://www.nuget.org/packages/NPushover/).

### Usage

- Register an account on [Duolingo](https://www.duolingo.com/register).

- Create an instance of the 'Duolingo' class and provide it with either a 'username' or 'email' and 'password'.

```c#
var duolingo = new Duolingo('USERNAME, PASSWORD');
```

- Alternatively, it's possible to simply instantiate a new class and load the username/email and password from a JSON file 'LoginData.json' in the application folder.

```javascript
{
    "login": "USERNAME",
    "password": "PASSWORD"
}
```
Note: a valid account is needed to get any data from Duolingo.

### Documentation
###### Prova
