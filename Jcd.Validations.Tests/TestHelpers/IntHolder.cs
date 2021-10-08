using System;

namespace Jcd.Validations.Tests.TestHelpers
{
   /// <summary>
   ///    A helper class that implements IComparable
   /// </summary>
   public class IntHolder : IComparable<IntHolder>
   {
      #region Public Fields

      public int Value;

      #endregion Public Fields

      #region Public Methods

      public int CompareTo(IntHolder other) { return Value.CompareTo(other.Value); }

      #endregion Public Methods

      #region Public Constructors

      public IntHolder() { }

      public IntHolder(int v) { Value = v; }

      #endregion Public Constructors
   }
}
