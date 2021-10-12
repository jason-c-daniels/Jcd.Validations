using System;
// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable FieldCanBeMadeReadOnly.Local

namespace Jcd.Validations.Examples
{
    internal static class Program
    {
        private static void Main()
        {
            // This will fail due to the null helper.
            TryIt(()=>new Conductor(null,-1,-10,"").DoIt());
            // This will fail due to Helper's name being empty.
            TryIt(()=>new Conductor(new Helper(""),-1,-10,"").DoIt());
            // This will fail due to min
            TryIt(()=>new Conductor(new Helper("Helper"),-1,-10,"").DoIt());
            // This will fail due to max being less than min
            TryIt(()=>new Conductor(new Helper("Helper"),1,-10,"").DoIt());
            // This will fail due to max also being less than min
            TryIt(()=>new Conductor(new Helper("Helper"),5,1,"").DoIt());
            // This will fail due to an empty boss name.
            TryIt(()=>new Conductor(new Helper("Helper"),3,7,"").DoIt());
            // This will succeed and output both messages.
            TryIt(()=>new Conductor(new Helper("The Helper"),3,7,"Lucia").DoIt());
        }

        private static void TryIt(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}