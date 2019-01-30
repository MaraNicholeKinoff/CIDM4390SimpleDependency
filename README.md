# CIDM4390 Simple Dependency

## 01/30/2019 Steps & Notes

1. dotnet new console -o "SimpleDependency"
2. dotnet new classlib -o "MessagePrinter"
3. dotnet new sln
    - You want to have the sln file talk to the other files.
4. dotnet sln add ./SimpleDependency/SimpleDependency.csproj
5. dotnet sln add ./MessagePrinter/MessagePrinter.csproj
6. cd SimpleDependency/
7. dotnet add reference ../MessagePrinter/MessagePrinter.csproj
8. dotnet build
9. cd ..
10. dotnet build
11. dotnet run --project ./SimpleDependency/SimpleDependency.csproj
    - This will run the SimpleDependency project while still in the main folder.
12. Go into .vscode/launch.json.
    - Change "console": "internalConsole", to "console": "internalTerminal",