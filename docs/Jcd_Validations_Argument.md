### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations')
## Argument Class
An argument "guard code" helper class.  
```csharp
public static class Argument
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Argument  
### Remarks
Use these methods to help ensure arguments meet various pre-conditions, and to generate  
consistent and standard exceptions on failure. The names of these methods are to be  
interpreted literally. For example this code will fail:  
```csharp

ument.IsWhitespace(string.Empty);
```
  
This is because an empty string has no characters, which means none of the characters are whitespace.  
Furthermore, if you wish to customize the kinds of validations available, create your own public static partial  
class Argument class, and add your own validation methods.  
It's highly recommended, that for consistency you use the existing Passes.. or Fails... methods. Or alternately you  
can use the underlying "Check." class.  
Craft your calls based on uses within this implementation.  

| Fields | |
| :--- | :--- |
| [UnspecifiedParamName](Jcd_Validations_Argument_UnspecifiedParamName.md 'Jcd.Validations.Argument.UnspecifiedParamName') | The default name for any parameter whose name was not provided at the point of invocation.<br/> |

| Methods | |
| :--- | :--- |
| [AreEqual&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_AreEqual_T_(T_T_string_string).md 'Jcd.Validations.Argument.AreEqual&lt;T&gt;(T, T, string, string)') | Ensure two IComparable instances are equivalent, or both are null.<br/> |
| [AreSameObject(object, object, string, string)](Jcd_Validations_Argument_AreSameObject(object_object_string_string).md 'Jcd.Validations.Argument.AreSameObject(object, object, string, string)') | Ensure two objects refer to the same instance, or both are null.<br/> |
| [Contains(string, string, string, string)](Jcd_Validations_Argument_Contains(string_string_string_string).md 'Jcd.Validations.Argument.Contains(string, string, string, string)') | Ensure that the search string (param) contains the target value somewhere within.<br/> |
| [Contains&lt;T&gt;(IEnumerable&lt;T&gt;, T, string, string)](Jcd_Validations_Argument_Contains_T_(System_Collections_Generic_IEnumerable_T__T_string_string).md 'Jcd.Validations.Argument.Contains&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, string, string)') | Ensure a value exists within an enumerable.<br/> |
| [DoesNotContain&lt;T&gt;(IEnumerable&lt;T&gt;, T, string, string)](Jcd_Validations_Argument_DoesNotContain_T_(System_Collections_Generic_IEnumerable_T__T_string_string).md 'Jcd.Validations.Argument.DoesNotContain&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, T, string, string)') | Ensure a value doesn't exist within an enumerable.<br/> |
| [Fails&lt;T&gt;(Signature&lt;T&gt;, T, string, string)](Jcd_Validations_Argument_Fails_T_(Jcd_Validations_Check_Signature_T__T_string_string).md 'Jcd.Validations.Argument.Fails&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, string, string)') | Ensures a custom check fails.<br/> |
| [FailsAll&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, string, string)](Jcd_Validations_Argument_FailsAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md 'Jcd.Validations.Argument.FailsAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string)') | Ensures a series of custom checks all fail.<br/> |
| [FailsAny&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, string, string)](Jcd_Validations_Argument_FailsAny_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md 'Jcd.Validations.Argument.FailsAny&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string)') | Ensures at least one of a set of custom checks fails.<br/> |
| [HasItems&lt;T&gt;(IEnumerable&lt;T&gt;, string, string)](Jcd_Validations_Argument_HasItems_T_(System_Collections_Generic_IEnumerable_T__string_string).md 'Jcd.Validations.Argument.HasItems&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string)') | Ensure an enumerable has at least one item.<br/> |
| [InRange&lt;T&gt;(T, T, T, string, string)](Jcd_Validations_Argument_InRange_T_(T_T_T_string_string).md 'Jcd.Validations.Argument.InRange&lt;T&gt;(T, T, T, string, string)') | Ensure a value is within the bounds of a defined minimum and maximum.<br/> |
| [IsEmpty(string, string, string)](Jcd_Validations_Argument_IsEmpty(string_string_string).md 'Jcd.Validations.Argument.IsEmpty(string, string, string)') | Ensures that a string is [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty') |
| [IsEmpty&lt;T&gt;(IEnumerable&lt;T&gt;, string, string)](Jcd_Validations_Argument_IsEmpty_T_(System_Collections_Generic_IEnumerable_T__string_string).md 'Jcd.Validations.Argument.IsEmpty&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, string, string)') | Ensure an enumerable has zero items.<br/> |
| [IsFalse(bool, string, string)](Jcd_Validations_Argument_IsFalse(bool_string_string).md 'Jcd.Validations.Argument.IsFalse(bool, string, string)') | Ensures the argument value is false.<br/> |
| [IsGreaterThan&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_IsGreaterThan_T_(T_T_string_string).md 'Jcd.Validations.Argument.IsGreaterThan&lt;T&gt;(T, T, string, string)') | Ensure a value is greater than another specified value.<br/> |
| [IsGreaterThanOrEqual&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_IsGreaterThanOrEqual_T_(T_T_string_string).md 'Jcd.Validations.Argument.IsGreaterThanOrEqual&lt;T&gt;(T, T, string, string)') | Ensure a value is greater than or equal to another specified value.<br/> |
| [IsLessThan&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_IsLessThan_T_(T_T_string_string).md 'Jcd.Validations.Argument.IsLessThan&lt;T&gt;(T, T, string, string)') | Ensure a value is less than another specified value.<br/> |
| [IsLessThanOrEqual&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_IsLessThanOrEqual_T_(T_T_string_string).md 'Jcd.Validations.Argument.IsLessThanOrEqual&lt;T&gt;(T, T, string, string)') | Ensure a value is less than or equal to another specified value.<br/> |
| [IsNotEmpty(string, string, string)](Jcd_Validations_Argument_IsNotEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNotEmpty(string, string, string)') | Ensures that a string is not empty<br/> |
| [IsNotNull&lt;T&gt;(T, string, string)](Jcd_Validations_Argument_IsNotNull_T_(T_string_string).md 'Jcd.Validations.Argument.IsNotNull&lt;T&gt;(T, string, string)') | Ensure the argument is not null.<br/> |
| [IsNotNullOrEmpty(string, string, string)](Jcd_Validations_Argument_IsNotNullOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNotNullOrEmpty(string, string, string)') | Ensures that a string is not null or empty.<br/> |
| [IsNotNullOrWhitespace(string, string, string)](Jcd_Validations_Argument_IsNotNullOrWhitespace(string_string_string).md 'Jcd.Validations.Argument.IsNotNullOrWhitespace(string, string, string)') | Ensures that a string is not null or whitespace.<br/> |
| [IsNotNullWhitespaceOrEmpty(string, string, string)](Jcd_Validations_Argument_IsNotNullWhitespaceOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNotNullWhitespaceOrEmpty(string, string, string)') | Ensures that a string is not null, empty, or whitespace.<br/> |
| [IsNotWhitespace(string, string, string)](Jcd_Validations_Argument_IsNotWhitespace(string_string_string).md 'Jcd.Validations.Argument.IsNotWhitespace(string, string, string)') | Ensures that a string is not whitespace. This is a pedantic check. String.Empty passes it,<br/>as well as null.<br/> |
| [IsNotWhitespaceOrEmpty(string, string, string)](Jcd_Validations_Argument_IsNotWhitespaceOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNotWhitespaceOrEmpty(string, string, string)') | Ensures that a string is not whitespace. It may be null, or non-whitespace<br/> |
| [IsNull&lt;T&gt;(T, string, string)](Jcd_Validations_Argument_IsNull_T_(T_string_string).md 'Jcd.Validations.Argument.IsNull&lt;T&gt;(T, string, string)') | Ensure the argument is null<br/> |
| [IsNullOrEmpty(string, string, string)](Jcd_Validations_Argument_IsNullOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNullOrEmpty(string, string, string)') | Ensures that a string is null or [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty') |
| [IsNullOrWhitespace(string, string, string)](Jcd_Validations_Argument_IsNullOrWhitespace(string_string_string).md 'Jcd.Validations.Argument.IsNullOrWhitespace(string, string, string)') | Ensures that a string is null or [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty'). This is a pedantic check as<br/>String.Empty will fail it.<br/> |
| [IsNullWhitespaceOrEmpty(string, string, string)](Jcd_Validations_Argument_IsNullWhitespaceOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsNullWhitespaceOrEmpty(string, string, string)') | Ensures that a string is null, whitespace or [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty').<br/> |
| [IsTrue(bool, string, string)](Jcd_Validations_Argument_IsTrue(bool_string_string).md 'Jcd.Validations.Argument.IsTrue(bool, string, string)') | Ensure the argument is true.<br/> |
| [IsWhitespace(string, string, string)](Jcd_Validations_Argument_IsWhitespace(string_string_string).md 'Jcd.Validations.Argument.IsWhitespace(string, string, string)') | Ensures that a string is contains 1 or more whitespace characters.<br/> |
| [IsWhitespaceOrEmpty(string, string, string)](Jcd_Validations_Argument_IsWhitespaceOrEmpty(string_string_string).md 'Jcd.Validations.Argument.IsWhitespaceOrEmpty(string, string, string)') | Ensures that a string is contains 1 or is [System.String.Empty](https://docs.microsoft.com/en-us/dotnet/api/System.String.Empty 'System.String.Empty') |
| [NotInRange&lt;T&gt;(T, T, T, string, string)](Jcd_Validations_Argument_NotInRange_T_(T_T_T_string_string).md 'Jcd.Validations.Argument.NotInRange&lt;T&gt;(T, T, T, string, string)') | Ensure a value is not within the bounds of a specified range.<br/> |
| [Passes&lt;T&gt;(Signature&lt;T&gt;, T, string, string)](Jcd_Validations_Argument_Passes_T_(Jcd_Validations_Check_Signature_T__T_string_string).md 'Jcd.Validations.Argument.Passes&lt;T&gt;(Jcd.Validations.Check.Signature&lt;T&gt;, T, string, string)') | Ensures a custom check passes.<br/> |
| [PassesAll&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, string, string)](Jcd_Validations_Argument_PassesAll_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md 'Jcd.Validations.Argument.PassesAll&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string)') | Ensures a series of custom checks all pass.<br/> |
| [PassesAny&lt;T&gt;(IEnumerable&lt;Signature&lt;T&gt;&gt;, T, string, string)](Jcd_Validations_Argument_PassesAny_T_(System_Collections_Generic_IEnumerable_Jcd_Validations_Check_Signature_T___T_string_string).md 'Jcd.Validations.Argument.PassesAny&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;Jcd.Validations.Check.Signature&lt;T&gt;&gt;, T, string, string)') | Ensures at least one check in series of custom checks passes.<br/> |
| [RaiseArgumentException(string, string)](Jcd_Validations_Argument_RaiseArgumentException(string_string).md 'Jcd.Validations.Argument.RaiseArgumentException(string, string)') | An helper method to raise an ArgumentException, setting defaults if not provided.<br/> |
| [RaiseArgumentNullException(string, string)](Jcd_Validations_Argument_RaiseArgumentNullException(string_string).md 'Jcd.Validations.Argument.RaiseArgumentNullException(string, string)') | A helper method to raise an ArgumentNullException<br/> |
| [RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string)](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string)') | A helper method to raise an ArgumentOutOfRange exception.<br/> |
| [RaiseExpectationViolation&lt;T&gt;(T, T, string, string)](Jcd_Validations_Argument_RaiseExpectationViolation_T_(T_T_string_string).md 'Jcd.Validations.Argument.RaiseExpectationViolation&lt;T&gt;(T, T, string, string)') | A helper method to raise an ArgumentException with a message that shows the values.<br/> |
