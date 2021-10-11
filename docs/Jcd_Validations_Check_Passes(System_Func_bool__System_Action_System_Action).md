### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.Passes(Func&lt;bool&gt;, Action, Action) Method
Evaluates a parameterless predicate ( [condition](Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Passes(System.Func&lt;bool&gt;, System.Action, System.Action).condition') ) and returns the result  
of the evaluation.  
```csharp
public static bool Passes(System.Func<bool> condition, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition'></a>
`condition` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The condition being evaluated
  
<a name='Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Passes(System.Func&lt;bool&gt;, System.Action, System.Action).condition') returns true  
  
<a name='Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if [condition](Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Passes(System.Func&lt;bool&gt;, System.Action, System.Action).condition') returns false  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of executing [condition](Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Passes(System.Func&lt;bool&gt;, System.Action, System.Action).condition')()
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [condition](Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action).md#Jcd_Validations_Check_Passes(System_Func_bool__System_Action_System_Action)_condition 'Jcd.Validations.Check.Passes(System.Func&lt;bool&gt;, System.Action, System.Action).condition') is null.
