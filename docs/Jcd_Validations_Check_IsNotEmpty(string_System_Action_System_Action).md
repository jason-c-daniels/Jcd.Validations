### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.IsNotEmpty(string, Action, Action) Method
Checks if a string has 1 or more characters in it, or is null.  
```csharp
public static bool IsNotEmpty(string value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_IsNotEmpty(string_System_Action_System_Action)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to check.
  
<a name='Jcd_Validations_Check_IsNotEmpty(string_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is not empty
  
<a name='Jcd_Validations_Check_IsNotEmpty(string_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is empty
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the string is not empty, false otherwise.
