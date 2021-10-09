### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string) Method
A helper method to raise an ArgumentOutOfRange exception.  
```csharp
public static void RaiseArgumentOutOfRangeException<T>(T value, T min, T max, string name=null, string message=null);
```
#### Type parameters
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_T'></a>
`T`  
The data type for [value](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_value 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).value'), [min](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_min 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).min') and [max](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_max 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).max')
  
#### Parameters
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).T')  
the offending value
  
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_min'></a>
`min` [T](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).T')  
the minimum, inclusive, value for the range
  
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_max'></a>
`max` [T](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md#Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string).T')  
the maximum, inclusive, value for the range
  
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
