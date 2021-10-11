### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsFalse(bool, string, string) Method
Ensures the argument value is false.  
```csharp
public static bool IsFalse(bool value, string name=null, string message=null);
```
#### Parameters
<a name='Jcd_Validations_Argument_IsFalse(bool_string_string)_value'></a>
`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value of the argument.
  
<a name='Jcd_Validations_Argument_IsFalse(bool_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the argument name.
  
<a name='Jcd_Validations_Argument_IsFalse(bool_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the error message.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When [value](Jcd_Validations_Argument_IsFalse(bool_string_string).md#Jcd_Validations_Argument_IsFalse(bool_string_string)_value 'Jcd.Validations.Argument.IsFalse(bool, string, string).value') is true
