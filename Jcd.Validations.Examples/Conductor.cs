using System;
// ReSharper disable FieldCanBeMadeReadOnly.Local

namespace Jcd.Validations.Examples
{
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
}