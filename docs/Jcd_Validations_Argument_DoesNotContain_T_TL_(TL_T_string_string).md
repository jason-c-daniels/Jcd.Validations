### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string) Method
Ensure a value doesn't exist within an enumerable.  
```csharp
public static TL DoesNotContain<T,TL>(TL list, T target, string name=null, string message=null)
    where TL : class, System.Collections.Generic.IEnumerable<T>;
```
#### Type parameters
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_T'></a>
`T`  
The type of the target value.
  
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_TL'></a>
`TL`  
The containing enumerable
  
#### Parameters
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_list'></a>
`list` [TL](Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string).md#Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_TL 'Jcd.Validations.Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string).TL')  
The enumerable
  
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_target'></a>
`target` [T](Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string).md#Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_T 'Jcd.Validations.Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string).T')  
The value being sought.
  
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the argument name.
  
<a name='Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the error message.
  
#### Returns
[TL](Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string).md#Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_TL 'Jcd.Validations.Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string).TL')  
the container that was checked
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When [list](Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string).md#Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_list 'Jcd.Validations.Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string).list') is null.
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When [target](Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string).md#Jcd_Validations_Argument_DoesNotContain_T_TL_(TL_T_string_string)_target 'Jcd.Validations.Argument.DoesNotContain&lt;T,TL&gt;(TL, T, string, string).target') was found.
