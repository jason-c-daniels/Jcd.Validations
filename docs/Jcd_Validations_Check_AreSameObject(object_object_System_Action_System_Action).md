### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.AreSameObject(object, object, Action, Action) Method
Checks if [left](Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action).md#Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_left 'Jcd.Validations.Check.AreSameObject(object, object, System.Action, System.Action).left') and [right](Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action).md#Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_right 'Jcd.Validations.Check.AreSameObject(object, object, System.Action, System.Action).right') are the same instance of an object.  
```csharp
public static bool AreSameObject(object left, object right, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Parameters
<a name='Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_left'></a>
`left` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The left hand side of the comparison
  
<a name='Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_right'></a>
`right` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The right hand side of the comparison
  
<a name='Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if they're the same instance.
  
<a name='Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if they're not the same instance.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if left and right are the same instance.
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If only one of [left](Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action).md#Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_left 'Jcd.Validations.Check.AreSameObject(object, object, System.Action, System.Action).left') or [right](Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action).md#Jcd_Validations_Check_AreSameObject(object_object_System_Action_System_Action)_right 'Jcd.Validations.Check.AreSameObject(object, object, System.Action, System.Action).right') are null.  
