### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.InRange&lt;T&gt;(T, T, T, string, string) Method
Ensure a value is within the bounds of a defined minimum and maximum.  
```csharp
public static void InRange<T>(T value, T min, T max, string name=null, string message=null)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_T'></a>
`T`  
The type of the compared values.
  
#### Parameters
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).T')  
The value being tested.
  
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_min'></a>
`min` [T](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).T')  
The minimum value for the range (inclusive)
  
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_max'></a>
`max` [T](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_T 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).T')  
The maximum value for the range (inclusive)
  
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When [value](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_value 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).value'), [min](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_min 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).min') or [max](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md#Jcd_Validations_Argument_InRange_T_(T_T_T_string_string)_max 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string).max') are null.  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the value is outside of the specified range.
