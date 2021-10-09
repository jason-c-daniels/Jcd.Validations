### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.InRange&lt;T&gt;(T, T, T, Action, Action) Method
Checks if [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value') is within the range defined by [ [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min')  
, [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max') ]. Or in other words: [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value') ∈ [ [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min'), [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max')]  
```csharp
public static bool InRange<T>(T value, T min, T max, System.Action onSuccess=null, System.Action onFailure=null)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_T'></a>
`T`  
The type of data being compared. It must implement IComparable< [T](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).T')>  
  
#### Parameters
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value'></a>
`value` [T](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).T')  
The value to compare
  
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min'></a>
`min` [T](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).T')  
The lower, inclusive, extent of the range.
  
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max'></a>
`max` [T](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_T 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).T')  
The upper, inclusive extent of the range.
  
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value') ∈ [ [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min'), [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max') ]  
  
<a name='Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to take if [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value') ∉ [ [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min'), [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max') ]  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value') ∈ [ [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min'), [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max') ]  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [value](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_value 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).value'), [min](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_min 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).min'), or [max](Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action).md#Jcd_Validations_Check_InRange_T_(T_T_T_System_Action_System_Action)_max 'Jcd.Validations.Check.InRange&lt;T&gt;(T, T, T, System.Action, System.Action).max') are null.  
