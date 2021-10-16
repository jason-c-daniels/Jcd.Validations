using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace Jcd.Validations
{
   /// <summary>
   ///    An argument "guard code" helper class.
   /// </summary>
   /// <remarks>
   ///    Use these methods to help ensure arguments meet various pre-conditions, and to generate
   ///    consistent and standard exceptions on failure. The names of these methods are to be
   ///    interpreted literally. For example this code will fail:
   /// <code>
   /// Argument.IsWhitespace(string.Empty);
   /// </code>
   ///    This is because an empty string has no characters, which means none of the characters are whitespace.
   ///    Furthermore, if you wish to customize the kinds of validations available, create your own public static partial
   ///    class Argument class, and add your own validation methods.
   ///    It's highly recommended, that for consistency you use the existing Passes.. or Fails... methods. Or alternately you
   ///    can use the underlying "Check." class.
   ///    Craft your calls based on uses within this implementation.
   /// </remarks>
   // ReSharper disable once PartialTypeWithSinglePart
   public static partial class Argument
   {
      #region exception helpers

      /// <summary>
      ///    The default name for any parameter whose name was not provided at the point of invocation.
      /// </summary>
      // ReSharper disable once MemberCanBePrivate.Global
      public const string UnspecifiedParamName = "[unspecified]";

      /// <summary>
      ///    An helper method to raise an ArgumentException, setting defaults if not provided.
      /// </summary>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      // ReSharper disable once MemberCanBePrivate.Global
      public static void RaiseArgumentException(string name = null, string message = null)
      {
         if (Check.IsNull(name) ||
             Check.IsWhitespace(name) ||
             Check.IsEmpty(name)) name = UnspecifiedParamName;

         throw new ArgumentException(message ?? $"{name} contains an invalid value.", name);
      }

      /// <summary>
      ///    A helper method to raise an ArgumentNullException
      /// </summary>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      // ReSharper disable once MemberCanBePrivate.Global
      public static void RaiseArgumentNullException(string name = null, string message = null)
      {
         if (Check.IsNull(name) ||
             Check.IsWhitespace(name) ||
             Check.IsEmpty(name)) name = UnspecifiedParamName;

         throw new ArgumentNullException(name, message ?? $"{name} was null, expected non-null");
      }

      /// <summary>
      ///    A helper method to raise an ArgumentOutOfRange exception.
      /// </summary>
      /// <param name="value">the offending value</param>
      /// <param name="min">the minimum, inclusive, value for the range</param>
      /// <param name="max">the maximum, inclusive, value for the range</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <typeparam name="T">
      ///    The data type for <paramref name="value" />, <paramref name="min" /> and <paramref name="max" />
      /// </typeparam>
      // ReSharper disable once MemberCanBePrivate.Global
      public static void RaiseArgumentOutOfRangeException<T>(T value,
                                                             T min,
                                                             T max,
                                                             string name = null,
                                                             string message = null)
      {
         if (Check.IsNull(name) ||
             Check.IsWhitespace(name) ||
             Check.IsEmpty(name)) name = UnspecifiedParamName;

         throw new ArgumentOutOfRangeException(name,
                                               value,
                                               message ??
                                               $"Argument {name} ({value}) had an invalid value. Expected value within range of {min} to {max}.");
      }

      /// <summary>
      ///    A helper method to raise an ArgumentException with a message that shows the values.
      /// </summary>
      /// <param name="expected">the expected value</param>
      /// <param name="actual">the actual value</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <typeparam name="T">The data type for <paramref name="expected" /> and <paramref name="actual" /></typeparam>
      // ReSharper disable once MemberCanBePrivate.Global
      public static void RaiseExpectationViolation<T>(T expected, T actual, string name = null, string message = null)
      {
         RaiseArgumentException(name, message ?? $"Expected {name} to be {expected}, but it was {actual}.");
      }

      #endregion exception helpers

      #region Boolean and Null checks

      /// <summary>
      ///    Ensures the argument value is false.
      /// </summary>
      /// <param name="value">The value of the argument.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When <paramref name="value" /> is true</exception>
      public static bool IsFalse(bool value, string name = null, string message = null)
      {
         Check.IsFalse(value, onFailure: () => RaiseExpectationViolation(false, true, name, message));
         return value;
      }

      /// <summary>
      ///    Ensure the argument is not null.
      /// </summary>
      /// <typeparam name="T">The type of the argument.</typeparam>
      /// <param name="value">The value of the argument.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">When <paramref name="value" /> is null</exception>
      // ReSharper disable once MemberCanBePrivate.Global
      public static T IsNotNull<T>(T value, string name = null, string message = null)
         where T : class
      {
         Check.IsNotNull(value, onFailure: () => RaiseArgumentNullException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensure the argument is null
      /// </summary>
      /// <typeparam name="T">The type of the argument.</typeparam>
      /// <param name="value">The value of the argument.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When <paramref name="value" /> is not null</exception>
      public static T IsNull<T>(T value, string name = null, string message = null)
         where T : class
      {
         Check.IsNull(value, onFailure: () => RaiseExpectationViolation("null", "non-null", name, message));
         return value;
      }

      /// <summary>
      ///    Ensure the argument is true.
      /// </summary>
      /// <param name="value">The value of the argument.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When <paramref name="value" /> is false.</exception>
      public static bool IsTrue(bool value, string name = null, string message = null)
      {
         Check.IsTrue(value, onFailure: () => RaiseExpectationViolation(true, false, name, message));
         return value;
      }

      #endregion Boolean and Null checks

      #region collection operations

      /// <summary>
      ///    Ensure a value exists within an enumerable.
      /// </summary>
      /// <typeparam name="T">The type of the target value.</typeparam>
      /// <typeparam name="TL">The type of the enumerable, must be derived from IEnumerable of T</typeparam>
      /// <param name="list">The enumerable</param>
      /// <param name="target">The value being sought.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the container that was checked</returns>
      /// <exception cref="ArgumentNullException">When <paramref name="list" /> is null.</exception>
      /// <exception cref="ArgumentException">When <paramref name="target" /> can't be found.</exception>
      public static TL Contains<T,TL>(TL list, T target, string name = null, string message = null)
         where TL : IEnumerable<T>
      {
         var enumerable = list as T[] ?? list?.ToArray();
         IsNotNull(enumerable, name, message);

         Check.Contains(enumerable,
                        target,
                        onFailure: () => RaiseArgumentException(name, message ?? $"{target} was not found in {name}."));
         return list;
      }

      /// <summary>
      ///    Ensure a value doesn't exist within an enumerable.
      /// </summary>
      /// <typeparam name="T">The type of the target value.</typeparam>
      /// <typeparam name="TL">The containing enumerable</typeparam>
      /// <param name="list">The enumerable</param>
      /// <param name="target">The value being sought.</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the container that was checked</returns>
      /// <exception cref="ArgumentNullException">When <paramref name="list" /> is null.</exception>
      /// <exception cref="ArgumentException">When <paramref name="target" /> was found.</exception>
      public static TL DoesNotContain<T,TL>(TL list, T target, string name = null, string message = null)
         where TL : class, IEnumerable<T>
      {
         // ReSharper disable once PossibleMultipleEnumeration
         IsNotNull(list, name, message);

         // ReSharper disable once PossibleMultipleEnumeration
         Check.DoesNotContain(list,
                              target,
                              onFailure: () => RaiseArgumentException(name,
                                                                      message ??
                                                                      $"{target} was expected to not be in {name}, but was found."));
         return list;
      }

      /// <summary>
      ///    Ensure an enumerable has at least one item.
      /// </summary>
      /// <typeparam name="T">The type of the enumerated values.</typeparam>
      /// <param name="list">The enumerable</param>
      /// <param name="name">the argument name.</param>
      /// <param name="message">the error message.</param>
      /// <returns>the container</returns>
      /// <exception cref="ArgumentNullException">When <paramref name="list" /> is null.</exception>
      /// <exception cref="ArgumentException">
      ///    When <paramref name="list" /> no items were found.
      /// </exception>
      public static T HasItems<T>(T list, string name = null, string message = null)
         where T : class, IEnumerable
      {
         // ReSharper disable once PossibleMultipleEnumeration
         IsNotNull(list, name, message);

         // ReSharper disable once PossibleMultipleEnumeration
         Check.HasItems(list,
                        onFailure: () => RaiseArgumentException(name,
                                                                message ??
                                                                $"Expected {name} to contain at least one item, but it was empty."));
         return list;
      }

      /// <summary>
      ///    Ensure an enumerable has zero items.
      /// </summary>
      /// <typeparam name="T">The type of the enumerated values.</typeparam>
      /// <param name="list">The enumerable to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the container</returns>
      /// <exception cref="ArgumentNullException">When <paramref name="list" /> is null.</exception>
      /// <exception cref="ArgumentException">
      ///    When <paramref name="list" /> at least one item was found.
      /// </exception>
      public static T IsEmpty<T>(T list, string name = null, string message = null)
         where T : class, IEnumerable
      {
         // ReSharper disable once PossibleMultipleEnumeration
         IsNotNull(list, name, message);

         // ReSharper disable once PossibleMultipleEnumeration
         Check.IsEmpty(list,
                       onFailure: () => RaiseArgumentException(name,
                                                               message ??
                                                               $"Expected {name} to be an empty collection, but it contained values."));
         return list;
      }

      #endregion collection operations

      #region string operations

      /// <summary>
      ///    Ensures that a string is not empty
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">If the value is <see cref="String.Empty" />.</exception>
      public static string IsNotEmpty(string value, string name = null, string message = null)
      {
         Check.IsNotEmpty(value,
                          onFailure: () => RaiseArgumentException(name,
                                                                  message ??
                                                                  $"Expected {name} to be a non-empty string, but it was empty."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is <see cref="String.Empty" />
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">If the value is null.</exception>
      /// <exception cref="ArgumentException">If the value is not <see cref="String.Empty" />.</exception>
      public static string IsEmpty(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.IsEmpty(value,
                       onFailure: () => RaiseArgumentException(name,
                                                               message ??
                                                               $"Expected {name} to be an empty string, but it contains text."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is not null or empty.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">If the value is <see cref="String.Empty" />.</exception>
      /// <exception cref="ArgumentNullException">If the value is null.</exception>
      public static string IsNotNullOrEmpty(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.IsNotEmpty(value,
                          onFailure: () => RaiseArgumentException(name,
                                                                  message ??
                                                                  $"Expected {name} to be non-null and non-empty."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is not null or whitespace.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">If the value is null
      ///    or <see cref="String.Empty">String.Empty</see>.
      /// </exception>
      /// <exception cref="ArgumentNullException">If the value is null.</exception>
      public static string IsNotNullOrWhitespace(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.IsNotWhitespace(value,
                               onFailure: () => RaiseArgumentException(name,
                                                                       message ??
                                                                       $"Expected {name} to be non-null and non-whitespace."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is not null, empty, or whitespace.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is null
      ///    , only whitespace, or <see cref="String.Empty">String.Empty</see>
      ///    .
      /// </exception>
      /// <exception cref="ArgumentNullException">If the value is null.</exception>
      public static string IsNotNullWhitespaceOrEmpty(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.FailsAll(new Check.Signature<string>[] {Check.IsEmpty, Check.IsWhitespace},
                        value,
                        onFailure: () => RaiseArgumentException(name,
                                                                message ??
                                                                $"Expected {name} to be non-null, non-empty, and non-whitespace."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is not whitespace. This is a pedantic check. String.Empty passes it,
      ///    as well as null.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is only whitespace and a string length of at least 1.
      /// </exception>
      public static string IsNotWhitespace(string value, string name = null, string message = null)
      {
         Check.PassesAny(new Check.Signature<string>[] {Check.IsNull, Check.IsNotWhitespace},
                         value,
                         onFailure: () =>
                                       RaiseArgumentException(name,
                                                              message ??
                                                              $"Invalid argument: {name} is all whitespace."));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is not whitespace. It may be null, or non-whitespace
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">If the value is only whitespace or <see cref="String.Empty" />.</exception>
      public static string IsNotWhitespaceOrEmpty(string value, string name = null, string message = null)
      {
         Check.Passes(() => value == null || value.Trim().Length > 1,
                      onFailure: () =>
                                    RaiseArgumentException(name,
                                                           message ??
                                                           $"Expected {name} to be non-empty and non-whitespace."));

         return value;
      }

      /// <summary>
      ///    Ensures that a string is null or <see cref="String.Empty" />
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is <see cref="String.Empty" /> or null.
      /// </exception>
      public static string IsNullOrEmpty(string value, string name = null, string message = null)
      {
         Check.PassesAny(new Check.Signature<string>[] {Check.IsNull, Check.IsEmpty},
                         value,
                         onFailure: () => RaiseArgumentException(name,
                                                                 message ?? $"Expected {name} to be null or empty"));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is null or <see cref="String.Empty" />. This is a pedantic check as
      ///    String.Empty will fail it.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is not null, or whitespace of at least one character.
      /// </exception>
      public static string IsNullOrWhitespace(string value, string name = null, string message = null)
      {
         Check.PassesAny(new Check.Signature<string>[] {Check.IsNull, Check.IsWhitespace},
                         value,
                         onFailure: () => RaiseArgumentException(name,
                                                                 message ??
                                                                 $"Expected {name} to be null or whitespace"));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is null, whitespace or <see cref="String.Empty" />.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is not null, <see cref="String.Empty" /> ,or whitespace of at least one character.
      /// </exception>
      public static string IsNullWhitespaceOrEmpty(string value, string name = null, string message = null)
      {
         Check.PassesAny(new Check.Signature<string>[] {Check.IsNull, Check.IsWhitespace, Check.IsEmpty},
                         value,
                         onFailure: () =>
                                       RaiseArgumentException(name,
                                                              message ??
                                                              $"Expected {name} to be null, whitespace, or empty"));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is contains 1 or more whitespace characters.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is not whitespace of at least one character.
      /// </exception>
      /// <exception cref="ArgumentNullException">If the value is null.</exception>
      public static string IsWhitespace(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.IsWhitespace(value,
                            onFailure: () => RaiseExpectationViolation("all whitespace",
                                                                       "non-whitespace",
                                                                       name,
                                                                       message));
         return value;
      }

      /// <summary>
      ///    Ensures that a string is contains 1 or is <see cref="String.Empty" />
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    If the value is null, or non-whitespace of 1 or more characters.
      /// </exception>
      /// <exception cref="ArgumentNullException">When value is null</exception>
      public static string IsWhitespaceOrEmpty(string value, string name = null, string message = null)
      {
         IsNotNull(value, name, message);

         Check.PassesAny(new Check.Signature<string>[] {Check.IsWhitespace, Check.IsEmpty},
                         value,
                         onFailure: () =>
                                       RaiseArgumentException(name,
                                                              message ??
                                                              $"Expected {name} to be whitespace or empty."));
         return value;
      }

      /// <summary>
      ///    Ensure that the search string (param) contains the target value somewhere within.
      /// </summary>
      /// <param name="searchString">The string to search within</param>
      /// <param name="target">the substring to search for</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the searchString</returns>
      public static string Contains(string searchString, string target, string name = null, string message = null)
      {
         IsNotNull(searchString, name, message);
         IsNotNull(target, name, "Incorrect validation configuration. The value to check for must be non-null.");

         Check.Passes(() => searchString.Contains(target),
                      onFailure: () => RaiseArgumentException(name, message ?? $"{target} was not found in {name}."));

         return searchString;
      }

      #endregion string operations

      #region range and relational operations

      /// <summary>
      ///    Ensure two IComparable instances are equivalent, or both are null.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">The expected value.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the values are not equivalent.</exception>
      public static T AreEqual<T>(T value, T comparison, string name = null, string message = null)
         where T : IComparable<T>
      {
         Check.AreEqual(value,
                        comparison,
                        onFailure: () =>
                                      RaiseArgumentException(name,
                                                             message ??
                                                             $"Value for {name} ({value}) is not equal to {comparison}"));
         return value;
      }

      /// <summary>
      ///    Ensure two objects refer to the same instance, or both are null.
      /// </summary>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">The expected value.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">
      ///    When the objects are not the same, or only one is null.
      /// </exception>
      public static T AreSameObject<T>(T value, T comparison, string name = null, string message = null)
         where T : class
      {
         Check.AreSameObject(value,
                             comparison,
                             onFailure: () => RaiseArgumentException(name,
                                                                     message ??
                                                                     $"Object for {name} was not the expected instance."));
         return value;
      }

      /// <summary>
      ///    Ensure a value is within the bounds of a defined minimum and maximum.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="min">The minimum value for the range (inclusive)</param>
      /// <param name="max">The maximum value for the range (inclusive)</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When <paramref name="value" />, <paramref name="min" /> or <paramref name="max" /> are null.
      /// </exception>
      /// <exception cref="ArgumentException">When the value is outside of the specified range.</exception>
      public static T InRange<T>(T value, T min, T max, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(min as object,
                      nameof(min),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");

            IsNotNull(max as object,
                      nameof(max),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.InRange(value,
                       min,
                       max,
                       onFailure: () => RaiseArgumentOutOfRangeException(value, min, max, name, message));
         return value;
      }

      /// <summary>
      ///    Ensure a value is greater than another specified value.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">What <paramref name="value" /> must be greater than.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When either <paramref name="value" /> or <paramref name="comparison" /> are null.
      /// </exception>
      /// <exception cref="ArgumentException">
      ///    When the <paramref name="value" /> is less than or equal to <paramref name="comparison" />.
      /// </exception>
      public static T IsGreaterThan<T>(T value, T comparison, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(comparison as object,
                      nameof(comparison),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.IsGreaterThan(value,
                             comparison,
                             onFailure: () => RaiseArgumentException(name,
                                                                     message ??
                                                                     $"Value for {name} ({value}) was expected to be greater than {comparison}"));
         return value;
      }

      /// <summary>
      ///    Ensure a value is greater than or equal to another specified value.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">
      ///    What <paramref name="value" /> must be greater than or equivalent to.
      /// </param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When either <paramref name="value" /> or <paramref name="comparison" /> are null.
      /// </exception>
      /// <exception cref="ArgumentException">
      ///    When the <paramref name="value" /> is less than <paramref name="comparison" />.
      /// </exception>
      public static T IsGreaterThanOrEqual<T>(T value, T comparison, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(comparison as object,
                      nameof(comparison),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.Passes(() => value.CompareTo(comparison) >= 0,
                      onFailure: () => RaiseArgumentException(name,
                                                              message ??
                                                              $"Value for {name} ({value}) was expected to be greater than or equal to {comparison}"));
         return value;
      }

      /// <summary>
      ///    Ensure a value is less than another specified value.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">What <paramref name="value" /> must be less than.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When either <paramref name="value" /> or <paramref name="comparison" /> are null.
      /// </exception>
      /// <exception cref="ArgumentException">
      ///    When the <paramref name="value" /> is greater than or equal to <paramref name="comparison" />.
      /// </exception>
      public static T IsLessThan<T>(T value, T comparison, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(comparison as object,
                      nameof(comparison),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.IsLessThan(value,
                          comparison,
                          onFailure: () => RaiseArgumentException(name,
                                                                  message ??
                                                                  $"Value for {name} ({value}) was expected to be less than {comparison}"));
         return value;
      }

      /// <summary>
      ///    Ensure a value is less than or equal to another specified value.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="comparison">
      ///    What <paramref name="value" /> must be less than or equivalent to.
      /// </param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When either <paramref name="value" /> or <paramref name="comparison" /> are null.
      /// </exception>
      /// <exception cref="ArgumentException">
      ///    When the <paramref name="value" /> is greater than <paramref name="comparison" />.
      /// </exception>
      public static T IsLessThanOrEqual<T>(T value, T comparison, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(comparison as object,
                      nameof(comparison),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.Passes(() => value.CompareTo(comparison) <= 0,
                      onFailure: () => RaiseArgumentException(name,
                                                              message ??
                                                              $"Value for {name} ({value}) was expected to be less than or equal to {comparison}"));
         return value;
      }

      /// <summary>
      ///    Ensure a value is not within the bounds of a specified range.
      /// </summary>
      /// <typeparam name="T">The type of the compared values.</typeparam>
      /// <param name="value">The value being tested.</param>
      /// <param name="min">The minimum value for the range (inclusive)</param>
      /// <param name="max">The maximum value for the range (inclusive)</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentNullException">
      ///    When <paramref name="value" />, <paramref name="min" /> or <paramref name="max" /> are null.
      /// </exception>
      /// <exception cref="ArgumentOutOfRangeException">When the value is within the specified range.</exception>
      public static T NotInRange<T>(T value, T min, T max, string name = null, string message = null)
         where T : IComparable<T>
      {
         if (typeof(T).IsByRef)
         {
            IsNotNull(value as object, name, message);

            IsNotNull(min as object,
                      nameof(min),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");

            IsNotNull(max as object,
                      nameof(max),
                      "You must setup your guard code correctly if this is going to work. Sadly, you did not.");
         }

         Check.NotInRange(value,
                          min,
                          max,
                          onFailure: () => RaiseArgumentOutOfRangeException(value,
                                                                            min,
                                                                            max,
                                                                            name,
                                                                            message ??
                                                                            $"Argument {name} ({value}) had an invalid value. Expected value outside of the range of {min} to {max}."));
         return value;
      }

      #endregion range and relational operations

      #region custom and multi-condition operations

      /// <summary>
      ///    Ensures a custom check fails.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="condition">The custom check.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value passes the custom check.</exception>
      public static T Fails<T>(Check.Signature<T> condition, T value, string name = null, string message = null)
      {
         Check.Fails(condition, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensures a series of custom checks all fail.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="conditions">The set of custom checks.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value passes any of the custom checks.</exception>
      public static T FailsAll<T>(IEnumerable<Check.Signature<T>> conditions,
                                     T value,
                                     string name = null,
                                     string message = null)
      {
         Check.FailsAll(conditions, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensures at least one of a set of custom checks fails.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="conditions">The set of custom checks.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value passes any of the custom checks.</exception>
      public static T FailsAny<T>(IEnumerable<Check.Signature<T>> conditions,
                                     T value,
                                     string name = null,
                                     string message = null)
      {
         Check.FailsAny(conditions, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensures a custom check passes.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="condition">The custom check.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value fails the custom check.</exception>
      public static T Passes<T>(Check.Signature<T> condition, T value, string name = null, string message = null)
      {
         Check.Passes(condition, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensures a series of custom checks all pass.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="conditions">The set of custom checks.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value fails any of the custom checks.</exception>
      public static T PassesAll<T>(IEnumerable<Check.Signature<T>> conditions,
                                      T value,
                                      string name = null,
                                      string message = null)
      {
         Check.PassesAll(conditions, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      /// <summary>
      ///    Ensures at least one check in series of custom checks passes.
      /// </summary>
      /// <typeparam name="T">The type of the value.</typeparam>
      /// <param name="conditions">The set of custom checks.</param>
      /// <param name="value">The value to check.</param>
      /// <param name="name">The argument name.</param>
      /// <param name="message">The error message.</param>
      /// <returns>the value</returns>
      /// <exception cref="ArgumentException">When the value fails any of the custom checks.</exception>
      public static T PassesAny<T>(IEnumerable<Check.Signature<T>> conditions,
                                      T value,
                                      string name = null,
                                      string message = null)
      {
         Check.PassesAny(conditions, value, onFailure: () => RaiseArgumentException(name, message));
         return value;
      }

      #endregion custom and multi-condition operations
   }
}
