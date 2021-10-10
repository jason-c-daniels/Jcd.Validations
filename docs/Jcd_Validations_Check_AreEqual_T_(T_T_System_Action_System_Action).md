### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.AreEqual&lt;T&gt;(T, T, Action, Action) Method
Checks if [left](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_left 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).left') is equivalent to [right](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_right 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).right').  
```csharp
public static bool AreEqual<T>(T left, T right, System.Action onSuccess=null, System.Action onFailure=null)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_T'></a>
`T`  
  
#### Parameters
<a name='Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_left'></a>
`left` [T](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).T')  
The left hand side of the comparison
  
<a name='Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_right'></a>
`right` [T](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).T')  
The right hand side of the comparison
  
<a name='Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if [left](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_left 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).left') is equivalent to [right](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_right 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).right')
  
<a name='Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if [left](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_left 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).left') is not equivalent to [right](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_right 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).right')
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if left is is equivalent to right.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [left](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_left 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).left') or [right](Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action).md#Jcd_Validations_Check_AreEqual_T_(T_T_System_Action_System_Action)_right 'Jcd.Validations.Check.AreEqual&lt;T&gt;(T, T, System.Action, System.Action).right') are null.  
