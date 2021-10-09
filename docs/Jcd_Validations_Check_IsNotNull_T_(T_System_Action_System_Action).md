### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.IsNotNull&lt;T&gt;(T, Action, Action) Method
Check if the provided value is not null and, if applicable, take an indicated action.  
```csharp
public static bool IsNotNull<T>(T value, System.Action onSuccess=null, System.Action onFailure=null)
    where T : class;
```
#### Type parameters
<a name='Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action)_T'></a>
`T`  
The type of the data being evaluated
  
#### Parameters
<a name='Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action)_value'></a>
`value` [T](Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.IsNotNull&lt;T&gt;(T, System.Action, System.Action).T')  
The value being evaluated
  
<a name='Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when value != null.
  
<a name='Jcd_Validations_Check_IsNotNull_T_(T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when value != null.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if value is null, false otherwise
