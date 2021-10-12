using System;
// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable FieldCanBeMadeReadOnly.Local

namespace Jcd.Validations.Examples
{
    public class Helper
    {
        private string _name;

        public Helper(string name)
        {
            _name = Argument.IsNotNullWhitespaceOrEmpty(name, nameof(name));
        }
        
        public void GetHelp()
        {
            Console.WriteLine($"{_name}: I'm helping!");
        }
    }
    
    public class Conductor
    {
        private Helper _helper;
        private int _min;
        private int _max;
        private string _bossName;

        public Conductor(Helper helper, int min, int max, string bossName)
        {
            _helper = Argument.IsNotNull(helper, nameof(helper));
            _min = Argument.InRange(min, 1, 10,nameof(min));
            _max = Argument.InRange(max, _min, 10,nameof(max));
            _bossName = Argument.IsNotEmpty(bossName, nameof(bossName));
        }

        public void DoIt()
        {
            Console.WriteLine($"Conductor: I'm doing something useful between {_min} and {_max} times for {_bossName}, my boss.");
            _helper.GetHelp();
        }
    }
    
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