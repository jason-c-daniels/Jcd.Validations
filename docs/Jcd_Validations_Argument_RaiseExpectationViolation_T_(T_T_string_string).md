### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string) Method
A helper method to raise an ArgumentException with a message that shows the values.  
```csharp
public static void RaiseExpectationViolation<T>(T expected, T actual, string name=null, string message=null);
```
#### Type parameters
<a name='Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_T'></a>
`T`  
The data type for [expected](Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string).md#Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_expected 'Jcd.Validations.Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string).expected') and [actual](Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string).md#Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_actual 'Jcd.Validations.Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string).actual')
  
#### Parameters
<a name='Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_expected'></a>
`expected` [T](Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string).md#Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_T 'Jcd.Validations.Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string).T')  
the expected value
  
<a name='Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_actual'></a>
`actual` [T](Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string).md#Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_T 'Jcd.Validations.Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string).T')  
the actual value
  
<a name='Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
