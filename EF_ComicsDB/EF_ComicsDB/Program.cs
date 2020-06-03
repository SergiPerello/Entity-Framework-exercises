using System;

namespace EF_ComicsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                exit = Logic.Start();
            }
        }
    }
}
