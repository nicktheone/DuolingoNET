# DuolingoNET
[![NuGet](https://img.shields.io/nuget/v/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)
[![NuGet](https://img.shields.io/nuget/dt/DuolingoNET.svg)](https://www.nuget.org/packages/DuolingoNET)

Unofficial .NET Core Duolingo (https://www.duolingo.com/) API. Available as a [NuGet package](https://www.nuget.org/packages/DuolingoNET).

### Usage
- Register an account on [Duolingo](https://www.duolingo.com/register).

- Create an instance of the `Duolingo` class and provide it with either a `username` or `email`, a `password` and a `HttpClient`.

```cs
var duolingo = new Duolingo(username, password, httpclient);
```
Note: a valid Duolingo account is needed to get any data from the API. If you signed in with Google you need to switch to a Duolingo account.

### Documentation

###### Account
- [Get User Data Raw](#getuserdataraw)
- [Get User Info](#getuserinfo)
- [Get Friends](#getfriends)
- [Get Calendar](#getcalendar)
- [Get Streak](#getstreak)
#### GetUserDataRaw()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var userData = GetUserDataRaw();
```
Returns a `User.Root` containing all the raw data for the user, as pulled by the API. Lacks ads and tracking data.
#### GetUserInfo()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var userData = GetUserInfo();
```
Returns a `UserInfo` containing various information on the user.
#### GetFriends()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var friends = GetFriends();
```
Returns a `User.PointsRankingData` representing the friends of the the user.
#### GetCalendar()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var friends = GetCalendar();
```
Returns a `User.Calendar` representing the actions of the user.
#### GetStreak()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var friends = GetStreak();
```
Returns a `Streak` representing the info on the active streak of the user.
###### Language
- [Get Learned Skills](#getlearnedskills)
- [Get Known Words](#getknownwords)
- [Get Lexeme Data](#getlexemedataasync)
- [Get Vocabulary](#getvocabularyasync)
- [Get Learning Languages](#getlearninglanguages)
#### GetLearnedSkills()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var skills = GetLearnedSkills();
```
Returns a `List<User.Skill>` containing all the skills learned within the active language(`"learned": True`) by the user.
#### GetKnownWords()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var skills = GetKnownWords();
```
Returns a `List<string>` containing all the words known within the active language by the user.
#### GetLexemeDataAsync()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var lexeme = GetLexemeDataAsync(lexemeId);
```
Returns a `Task<Lexeme.Root>` representing a single word.
##### Paramaters
string `lexemeId` **required**

-- The id of the word you want to retrieve data for.
#### GetVocabularyAsync()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var lexeme = GetVocabularyAsync(lexemeId);
```
Returns a `Task<Vocabulary.Root>` representing the user's vocabulary.
#### GetLearningLanguages()
```cs
var duolingo = new Duolingo(username, password, httpclient);
var learningLanguages = GetLearningLanguages();
```
Returns a `List<User.Language>` representing the languages being studied by the user.
