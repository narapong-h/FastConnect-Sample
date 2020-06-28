# FastConnect-Sample

## Require NuGet Package
1. G.Libbrary.FastConnect
1. Dapper
   
```bash
   Install-Package G.Libbrary.FastConnect
   Install-Package Dapper -Version 2.0.35
```


## Installation
1. Create .net core project.
1. Add nuget package listed before.
1. Add and edit appsettings.json

``` json
{
  "ConnectionString": {
    "Default": "Data Source=localhost;User Id=<username>;Password=<password>;Min Pool Size=15;Connection Lifetime=180;",
    "Test_Env": "Data....."
  }
}
```
