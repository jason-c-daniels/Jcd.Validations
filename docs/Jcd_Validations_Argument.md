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
| [RaiseArgumentException(string, string)](Jcd_Validations_Argument_RaiseArgumentException(string_string).md 'Jcd.Validations.Argument.RaiseArgumentException(string, string)') | An helper method to raise an ArgumentException, setting defaults if not provided.<br/> |
| [RaiseArgumentNullException(string, string)](Jcd_Validations_Argument_RaiseArgumentNullException(string_string).md 'Jcd.Validations.Argument.RaiseArgumentNullException(string, string)') | A helper method to raise an ArgumentNullException<br/> |
| [RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string)](Jcd_Validations_Argument_RaiseArgumentOutOfRangeException_T_(T_T_T_string_string).md 'Jcd.Validations.Argument.RaiseArgumentOutOfRangeException&lt;T&gt;(T, T, T, string, string)') | A helper method to raise an ArgumentOutOfRange exception.<br/> |
