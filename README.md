# Jcd.Validations
A helper class to aid in parameter validation in methods.

## Example Constructor Argument Validations.
```csharp
    public class Conductor
    {
        ...
        public Conductor(Helper helper, int min, int max, string bossName)
        {
            _helper = Argument.IsNotNull(helper, nameof(helper));
            _min = Argument.InRange(min, 1, 10, nameof(min));
            _max = Argument.InRange(max, _min, 10, nameof(max));
            _bossName = Argument.IsNotEmpty(bossName, nameof(bossName));
            ...
```

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Validations)](https://github.com/jason-c-daniels/Jcd.Validations/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/djbghxj1ot3axbfs?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-validations)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Validations)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.validations)


[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Validations?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Validations)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Validations?logo=nuget)](https://www.nuget.org/packages/Jcd.Validations)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Validations/blob/main/docs/Jcd_Validations.md)
