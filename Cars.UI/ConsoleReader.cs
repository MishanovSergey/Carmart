using System;

namespace Cars.UI
{
    internal class ConsoleReader
    {
        internal static string GetBrandName()
        {
            
            return Console.ReadLine().ToLower();
        }
    }
}
