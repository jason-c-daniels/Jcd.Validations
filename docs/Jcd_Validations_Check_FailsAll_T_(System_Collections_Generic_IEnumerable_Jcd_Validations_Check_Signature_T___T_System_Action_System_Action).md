### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Check](Jcd_Validations_Check.md 'Jcd.Validations.Check')
## Check.FailsAll&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, Action, Action) Method
Evaluates a set of predicates ( [conditions](Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action).md#Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_conditions 'Jcd.Validations.Check.FailsAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, System.Action, System.Action).conditions') ) on a value to determine if  
all predicates return false.  
```csharp
public static bool FailsAll<T>(System.Collections.Generic.IEnumerable<Jcd.Validations.Check.Signature<T>> conditions, T value, System.Action onSuccess=null, System.Action onFailure=null);
```
#### Type parameters
<a name='Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_T'></a>
`T`  
The type of data being evaluated
  
#### Parameters
<a name='Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_conditions'></a>
`conditions` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Jcd.Validations.Check.Signature&lt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[T](Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action).md#Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_T 'Jcd.Validations.Check.FailsAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, System.Action, System.Action).T')[&gt;](Jcd_Validations_Check_Signature_T_(T_System_Action_System_Action).md 'Jcd.Validations.Check.Signature&lt;T&gt;(T, System.Action, System.Action)')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The set of predicates to evaluate
  
<a name='Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_value'></a>
`value` [T](Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action).md#Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_T 'Jcd.Validations.Check.FailsAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, System.Action, System.Action).T')  
The value to evaluate the predicates on.
  
<a name='Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_onSuccess'></a>
`onSuccess` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if all predicates return false.
  
<a name='Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_onFailure'></a>
`onFailure` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action to perform if any predicate return true.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if all predicates return false
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
If [conditions](Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action).md#Jcd_Validations_Check_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_System_Action_System_Action)_conditions 'Jcd.Validations.Check.FailsAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, System.Action, System.Action).conditions') is null or any individual entry is null.  
