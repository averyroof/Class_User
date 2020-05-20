using System;

namespace Class_User
{
    class Program
    {
        static void Main()
        {
            var employee = Provider.LoadFromFile();
            new Provider(employee).SaveToFile();
        }
    }
}