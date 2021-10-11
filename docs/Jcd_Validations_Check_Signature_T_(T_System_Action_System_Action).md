### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.Signature&lt;T&gt;(T, Action, Action) Delegate
The signature for delegates used in Passes< [T](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action).T')>, Fails<  
[T](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action).T')>, and aggregates of these methods (e.g. PassesAll). Most  
helpers implement this signature.  
```csharp
public delegate bool Check.Signature<in T>(T value, System.Action onSuccess, System.Action onFailure);
```
#### Type parameters
<a name='Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_T'></a>
`T`  
The data type to perform a validation on.
  
#### Parameters
<a name='Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_value'></a>
`value` [T](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action).T')  
the value to validate
  
<a name='Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the delegate detects a "success" condition.  
  
<a name='Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the delegate detects a "failure" condition.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if successful, false otherwise.
