### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsEmpty(string, string, string) Method
Ensures that a string is [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty')
```csharp
public static string IsEmpty(string value, string name=null, string message=null);
```
#### Parameters
<a name='Jcd_Validations_Argument_IsEmpty(string_string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to test.
  
<a name='Jcd_Validations_Argument_IsEmpty(string_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_IsEmpty(string_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the value
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If the value is null.
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If the value is not [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').
