### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.HasItems&lt;T&gt;(T, Action, Action) Method
Checks if a collection of type [T](Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.HasItems&lt;T&gt;(T, System.Action, System.Action).T') has entries.  
```csharp
public static bool HasItems<T>(T list, System.Action onSuccess=null, System.Action onFailure=null)
    where T : System.Collections.IEnumerable;
```
#### Type parameters
<a name='Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_T'></a>
`T`  
The type of the data stored in T
  
#### Parameters
<a name='Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_list'></a>
`list` [T](Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action).md#Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_T 'Jcd.Validations.Check.HasItems&lt;T&gt;(T, System.Action, System.Action).T')  
The collection to check
  
<a name='Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the collection has entries.
  
<a name='Jcd_Validations_Check_HasItems_T_(T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the collection is empty.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
False if list is empty, true otherwise
