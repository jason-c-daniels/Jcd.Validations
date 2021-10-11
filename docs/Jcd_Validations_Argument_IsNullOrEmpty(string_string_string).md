### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsNullOrEmpty(string, string, string) Method
Ensures that a string is null or [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty')
```csharp
public static string IsNullOrEmpty(string value, string name=null, string message=null);
```
#### Parameters
<a name='Jcd_Validations_Argument_IsNullOrEmpty(string_string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to test.
  
<a name='Jcd_Validations_Argument_IsNullOrEmpty(string_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_IsNullOrEmpty(string_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If the value is [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty') or null.  
