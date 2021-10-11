### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.Fails(Func&lt;bool&gt;, Action, Action) Method
Evaluates a parameterless predicate ( [condition](Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails(System.Func&lt;bool&gt;, System.Action, System.Action).condition') ) and returns the  
logical complement of the result of the evaluation.  
```csharp
public static bool Fails(System.Func<bool> condition, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition being evaluated
  
<a name='Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails(System.Func&lt;bool&gt;, System.Action, System.Action).condition') returns false  
  
<a name='Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails(System.Func&lt;bool&gt;, System.Action, System.Action).condition') returns true  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The logical complement of the result of executing [condition](Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails(System.Func&lt;bool&gt;, System.Action, System.Action).condition')()
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [condition](Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Fails(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Fails(System.Func&lt;bool&gt;, System.Action, System.Action).condition') is null.
