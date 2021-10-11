### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.DoesNotContain&lt;T&gt;(IEnumerable&lt;T&gt;, T, Action, Action) Method
Checks if a collection of type [T](Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action).md#Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_T 'Jcd.Validations.Check.DoesNotContain&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Action, System.Action).T') does not contain a specific item.  
```csharp
public static bool DoesNotContain<T>(System.Collections.Generic.IEnumerable<T> list, T target, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Type parameters
<a name='Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_T'></a>
`T`  
The type of the data stored in T
  
#### Parameters
<a name='Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_list'></a>
`list` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action).md#Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_T 'Jcd.Validations.Check.DoesNotContain&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Action, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The collection to check
  
<a name='Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_target'></a>
`target` [T](Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action).md#Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_T 'Jcd.Validations.Check.DoesNotContain&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, System.Action, System.Action).T')  
The item to look for.
  
<a name='Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the item is found.
  
<a name='Jcd_Validations_Check_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take, if any, when the item is not found.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the item is not found, false otherwise.
