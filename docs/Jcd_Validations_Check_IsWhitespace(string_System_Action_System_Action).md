### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.IsWhitespace(string, Action, Action) Method
Checks if the string has only whitespace and is not empty nor null.  
```csharp
public static bool IsWhitespace(string value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_IsWhitespace(string_System_Action_System_Action)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string to check.
  
<a name='Jcd_Validations_Check_IsWhitespace(string_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is not empty.
  
<a name='Jcd_Validations_Check_IsWhitespace(string_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if the string is null, empty, or has nonwhitespace characters.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the string is non-zero length and only contains whitespace.
