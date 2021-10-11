### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.PassesAll&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, string, string) Method
Ensures a series of custom checks all pass.  
```csharp
public static T PassesAll<T>(System.Collections.Generic.IEnumerable<Jcd.Validations.Check.Signature<T>> conditions, T value, string name=null, string message=null);
```
#### Type parameters
<a name='Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_conditions'></a>
`conditions` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Jcd.Validations.Check.Signature&lt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[T](Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md#Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_T 'Jcd.Validations.Argument.PassesAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string).T')[&gt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The set of custom checks.
  
<a name='Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_value'></a>
`value` [T](Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md#Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_T 'Jcd.Validations.Argument.PassesAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string).T')  
The value to check.
  
<a name='Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Returns
[T](Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md#Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string)_T 'Jcd.Validations.Argument.PassesAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string).T')  
the value
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the value fails any of the custom checks.
