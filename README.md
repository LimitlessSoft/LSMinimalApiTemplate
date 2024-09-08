Template project used to build `LSMinimalApiTemplate` nuget template package

To use template, download nuget template (`dotnet new install LSMinimalApiTemplate`) and run `dotnet new LSMinimalApi -n "NameOfYourProject"`

Before merging to master branch, make sure `LSMinimalApiTemplate.csproj`'s `PackageVersion` is updated.
Once new changes are merged in master branch, new version of nuget package will be published to nuget.

# Contribution
To contribute fork this project, branch from `develop`, make change and make PR into `develop` branch
Since there is no established protocol, your change may not be accepted.
Best thing to do is create issue and discuss change there until someone create protocol for the contributors.
Code merged into `master` is automatically packed and pushed to nuget

![GitHub last commit (branch)](https://img.shields.io/github/last-commit/LimitlessSoft/LSMinimalApiTemplate/develop?label=Last%20develop%20commit)
![GitHub Release](https://img.shields.io/github/v/release/LimitlessSoft/LSMinimalApiTemplate)
<br>
![Nuget](https://img.shields.io/nuget/v/LSMinimalApiTemplate?label=LSMinimalApi%20nuget)
![Nuget](https://img.shields.io/nuget/dt/LSMinimalApiTemplate?label=LSMinimalApi%20nuget)



