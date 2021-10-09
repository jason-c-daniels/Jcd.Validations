### [Jcd.Validations](Jcd_Validations.md 'Jcd.Validations').[Argument](Jcd_Validations_Argument.md 'Jcd.Validations.Argument')
## Argument.AreSameObject(object, object, string, string) Method
Ensure two objects refer to the same instance, or both are null.  
```csharp
public static void AreSameObject(object value, object comparison, string name=null, string message=null);
```
#### Parameters
<a name='Jcd_Validations_Argument_AreSameObject(object_object_string_string)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value being tested.
  
<a name='Jcd_Validations_Argument_AreSameObject(object_object_string_string)_comparison'></a>
`comparison` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The expected value.
  
<a name='Jcd_Validations_Argument_AreSameObject(object_object_string_string)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The argument name.
  
<a name='Jcd_Validations_Argument_AreSameObject(object_object_string_string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the objects are not the same, or only one is null.  
