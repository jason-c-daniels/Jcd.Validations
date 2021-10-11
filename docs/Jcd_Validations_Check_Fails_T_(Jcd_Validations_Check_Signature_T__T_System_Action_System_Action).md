### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.Fails&lt;T&gt;(Signature&lt;T&gt;, T, Action, Action) Method
Evaluates a predicate ( [condition](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).condition') ) on a value ( [value](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_value 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).value') ) and returns the logical complement of the result of the evaluation.  
```csharp
public static bool Fails<T>(Jcd.Validations.Check.Signature<T> condition, T value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Type parameters
<a name='Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_T'></a>
`T`  
The datatype being evaluated
  
#### Parameters
<a name='Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition'></a>
`condition` [Jcd.Validations.Check.Signature&lt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[T](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_T 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).T')[&gt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')  
The condition being evaluated
  
<a name='Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_value'></a>
`value` [T](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_T 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).T')  
The value being evaluated
  
<a name='Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).condition') returns false when passed [value](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_value 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).value')
  
<a name='Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).condition') returns true when passed [value](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_value 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).value')
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The logical complement of the result of executing [condition](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).condition')( [value](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_value 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).value') )  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [condition](Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action).md#Jcd_Validations_Check_Fails_T_(Jcd_Validations_Check_Signature_T__T_System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, System.Action, System.Action).condition') is null.
