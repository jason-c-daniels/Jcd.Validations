### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.IsTrue(bool, Action, Action) Method
Returns the value of value, and executes any success or failure conditions.  
```csharp
public static bool IsTrue(bool value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_IsTrue(bool_System_Action_System_Action)_value'></a>
`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value to evaluate and return
  
<a name='Jcd_Validations_Check_IsTrue(bool_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when value == true.
  
<a name='Jcd_Validations_Check_IsTrue(bool_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when value == true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
the value of value
### Remarks
This is a rudimentary helper method. While public it has little value outside of this or a  
similar framework.  
