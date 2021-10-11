### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsWhitespaceOrEmpty(string, string, string) Method
Ensures that a string is contains 1 or is [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty')
```csharp
public static string IsWhitespaceOrEmpty(string value, string name=null, string message=null);
```
#### Parameters
<a name='Jcd_Validations_Argument_IsWhitespaceOrEmpty(string_string_string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value to test.
  
<a name='Jcd_Validations_Argument_IsWhitespaceOrEmpty(string_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_IsWhitespaceOrEmpty(string_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If the value is null, or non-whitespace of 1 or more characters.  
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When value is null
