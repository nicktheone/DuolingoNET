# DuolingoNET
[![NuGet](https://img.shields.io/nuget/v/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)
[![NuGet](https://img.shields.io/nuget/dt/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)

Unofficial .NET Core Duolingo (https://www.duolingo.com/) API. Available as a [NuGet package](https://www.nuget.org/packages/NPushover/).

### Usage

- Register an account on [Duolingo](https://www.duolingo.com/register).

- Create an instance of the 'Duolingo' class and provide it with either a 'username' or 'email' and 'password'.

```cs
var duolingo = new Duolingo("USERNAME, PASSWORD");
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
###### Language
- [GetLearnedSkills](#getlearnedskills)
- [GetKnownWords](#getknownwords)
- [GetLexemeDataAsync](#getlexemedataasync)
- [GetVocabularyAsync](#getvocabularyasync)
#### GetLearnedSkills
```cs
var duolingo = new Duolingo("USERNAME, PASSWORD");
var skills = GetLearnedSkills();
```
Returns a `List<User.Skill>` containing all the skills learned (`"learned": True`) by the user.
#### GetKnownWords
```cs
var duolingo = new Duolingo("USERNAME, PASSWORD");
var skills = GetKnownWords();
```
Returns a `List<string>` containing all the words known by the user.
#### GetLexemeDataAsync
```cs
var duolingo = new Duolingo("USERNAME, PASSWORD");
var lexeme = GetLexemeDataAsync(lexemeId);
```
Returns a `Lexeme.Root` representing a single word.
##### Paramaters
string `lexemeId` **required**

-- The id of the word you want to retrieve data for.
#### GetVocabularyAsync
```cs
var duolingo = new Duolingo("USERNAME, PASSWORD");
var lexeme = GetVocabularyAsync(lexemeId);
```
Returns a `Vocabulary.Root` representing the user's vocabulary.
