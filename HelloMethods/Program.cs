using System;

namespace HelloMethods
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string message = Message.GetMessage("sp");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
