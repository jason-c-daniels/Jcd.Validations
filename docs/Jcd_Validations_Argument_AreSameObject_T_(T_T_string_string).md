### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.AreSameObject&lt;T&gt;(T, T, string, string) Method
Ensure two objects refer to the same instance, or both are null.  
```csharp
public static T AreSameObject<T>(T value, T comparison, string name=null, string message=null)
    where T : class;
```
#### Type parameters
<a name='Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_T'></a>
`T`  
  
#### Parameters
<a name='Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string).md#Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_T 'Jcd.Validations.Argument.AreSameObject&lt;T&gt;(T, T, string, string).T')  
The value being tested.
  
<a name='Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_comparison'></a>
`comparison` [T](Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string).md#Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_T 'Jcd.Validations.Argument.AreSameObject&lt;T&gt;(T, T, string, string).T')  
The expected value.
  
<a name='Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[T](Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string).md#Jcd_Validations_Argument_AreSameObject_T_(T_T_string_string)_T 'Jcd.Validations.Argument.AreSameObject&lt;T&gt;(T, T, string, string).T')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the objects are not the same, or only one is null.  
