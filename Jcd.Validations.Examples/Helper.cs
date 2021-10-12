using System;
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
}