# WebTest01
## Selenium DotNet with .Net Framework 8.0
### Dotnet Run commands using dotnet CLI:
> ${PROJ_DIR} > dotnet build
> ${PROJ_DIR} > dotnet test [Run All Tests]

>dotnet test --filter FullyQualifiedName~xyz"
>dotnet test --filter "FullyQualifiedName = YourNamespace.TestClass1.Test1"

##### With OR condition
dotnet test --filter "FullyQualifiedName ~ TestSelenium1 | FullyQualifiedName ~ TestSelenium2" 

##### Few More Condition
Nunit:
  FullyQualifiedName
  Name
  Priority
  TestCategory

Operators:
  = exact match
 !=not exact match
 ~ contains
 !~ doesn't contain
