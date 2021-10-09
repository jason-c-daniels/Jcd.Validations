### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.IsNotWhitespace(string, Action, Action) Method
Checks if the string is not-null and is either empty or has non-whitespace characters.  
```csharp
public static bool IsNotWhitespace(string value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_IsNotWhitespace(string_System_Action_System_Action)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to check.
  
<a name='Jcd_Validations_Check_IsNotWhitespace(string_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is not empty.
  
<a name='Jcd_Validations_Check_IsNotWhitespace(string_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is null, empty, or has nonwhitespace characters.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the string is non-null, and non-whitespace, false otherwise.
