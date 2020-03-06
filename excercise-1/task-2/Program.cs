using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var longValue = long.MaxValue;

            try
            {
                var integerValue = checked((int)longValue);
            }
            catch (OverflowException err)
            {
                Console.WriteLine($"Checked: {err}");
            }
        }
    }
}
