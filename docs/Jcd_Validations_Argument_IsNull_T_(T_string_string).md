### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsNull&lt;T&gt;(T, string, string) Method
Ensure the argument is null  
```csharp
public static T IsNull<T>(T value, string name=null, string message=null)
    where T : class;
```
#### Type parameters
<a name='Jcd_Validations_Argument_IsNull_T_(T_string_string)_T'></a>
`T`  
The type of the argument.
  
#### Parameters
<a name='Jcd_Validations_Argument_IsNull_T_(T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_IsNull_T_(T_string_string).md#Jcd_Validations_Argument_IsNull_T_(T_string_string)_T 'Jcd.Validations.Argument.IsNull&lt;T&gt;(T, string, string).T')  
The value of the argument.
  
<a name='Jcd_Validations_Argument_IsNull_T_(T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the argument name.
  
<a name='Jcd_Validations_Argument_IsNull_T_(T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the error message.
  
#### Returns
[T](Jcd_Validations_Argument_IsNull_T_(T_string_string).md#Jcd_Validations_Argument_IsNull_T_(T_string_string)_T 'Jcd.Validations.Argument.IsNull&lt;T&gt;(T, string, string).T')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When [value](Jcd_Validations_Argument_IsNull_T_(T_string_string).md#Jcd_Validations_Argument_IsNull_T_(T_string_string)_value 'Jcd.Validations.Argument.IsNull&lt;T&gt;(T, string, string).value') is not null
