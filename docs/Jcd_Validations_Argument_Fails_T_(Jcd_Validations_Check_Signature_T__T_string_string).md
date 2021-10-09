### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.Fails&lt;T&gt;(Signature&lt;T&gt;, T, string, string) Method
Ensures a custom check fails.  
```csharp
public static void Fails<T>(Jcd.Validations.Check.Signature<T> condition, T value, string name=null, string message=null);
```
#### Type parameters
<a name='Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_condition'></a>
`condition` [Jcd.Validations.Check.Signature&lt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[T](Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string).md#Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_T 'Jcd.Validations.Argument.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, string, string).T')[&gt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')  
The custom check.
  
<a name='Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string).md#Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_T 'Jcd.Validations.Argument.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, string, string).T')  
The value to check.
  
<a name='Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the value passes the custom check.
