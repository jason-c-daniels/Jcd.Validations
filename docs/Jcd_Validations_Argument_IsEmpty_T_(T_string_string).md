### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsEmpty&lt;T&gt;(T, string, string) Method
Ensure an enumerable has zero items.  
```csharp
public static T IsEmpty<T>(T list, string name=null, string message=null)
    where T : class, System.Collections.IEnumerable;
```
#### Type parameters
<a name='Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_T'></a>
`T`  
The type of the enumerated values.
  
#### Parameters
<a name='Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_list'></a>
`list` [T](Jcd_Validations_Argument_IsEmpty_T_(T_string_string).md#Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_T 'Jcd.Validations.Argument.IsEmpty&lt;T&gt;(T, string, string).T')  
The enumerable to test.
  
<a name='Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[T](Jcd_Validations_Argument_IsEmpty_T_(T_string_string).md#Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_T 'Jcd.Validations.Argument.IsEmpty&lt;T&gt;(T, string, string).T')  
the container
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When [list](Jcd_Validations_Argument_IsEmpty_T_(T_string_string).md#Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_list 'Jcd.Validations.Argument.IsEmpty&lt;T&gt;(T, string, string).list') is null.
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When [list](Jcd_Validations_Argument_IsEmpty_T_(T_string_string).md#Jcd_Validations_Argument_IsEmpty_T_(T_string_string)_list 'Jcd.Validations.Argument.IsEmpty&lt;T&gt;(T, string, string).list') at least one item was found.  
