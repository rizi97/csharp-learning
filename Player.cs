using System;

namespace cSharp_Fundamentals
{
    public class Player
    {
        public string firstName = "";
        public string lastName = "";

        public void FullName()
        {
            Console.WriteLine($"FullName: {firstName} {lastName}");
        }
    }
}
