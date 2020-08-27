# CSharp Missing File Finder

Console app that scans a C# project file (.csproj) and displays physically missing files. This can be handy if you have a large nested project with lots of missing references.

## Prerequisites

- GIT
- .NET Core 3.1 SDK

## Usage

I should hope if you are using this tool that you won't need this, but just in case...

__Visual Studio__

1) See [Tutorial: Open a project from a repo]("https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2019") to clone this repo into Visual Studio.
2) Open the solution via the solution explorer pane.
3) Start the app in either debug or release mode, follow the instructions on screen

__VS Code__

1) In your favourite command line interface navigate to an empty folder
2) Run the following commands: 

```
> git clone https://github.com/simon-curtis/CSharpMissingFileFinder.git`
> cd CSharpMissingFileFinder
> code .
```
3) Open up a terminal window (`ctrl + shift + p` and choose "Terminal: Create new terminal window")
4) Run `dotnet run`

__Dotnet CLI__

1) In your favourite command line interface navigate to an empty folder
2) Run the following commands: 

```
> git clone https://github.com/simon-curtis/CSharpMissingFileFinder.git`
> cd CSharpMissingFileFinder
> dotnet run
```
3) follow the instructions on screen