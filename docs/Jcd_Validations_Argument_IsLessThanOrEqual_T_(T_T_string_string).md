### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string) Method
Ensure a value is less than or equal to another specified value.  
```csharp
public static void IsLessThanOrEqual<T>(T value, T comparison, string name=null, string message=null)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_T'></a>
`T`  
The type of the compared values.
  
#### Parameters
<a name='Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_T 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).T')  
The value being tested.
  
<a name='Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_comparison'></a>
`comparison` [T](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_T 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).T')  
What [value](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_value 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).value') must be less than or equivalent to.  
  
<a name='Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When either [value](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_value 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).value') or [comparison](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_comparison 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).comparison') are null.  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the [value](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_value 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).value') is greater than [comparison](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md#Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string)_comparison 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string).comparison').  
