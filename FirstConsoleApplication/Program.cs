using System;

namespace FirstConsoleApplication
{
    class Program
    {
        public static void UseSampleProject()
        {
            Console.WriteLine("Hello UseSampleProject!!!");
        }

        public static void UseSampleProjectUpdateFromGit()
        {
            Console.WriteLine("Hello UseSampleProjectUpdateFromGit!!!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello first console Application!!!");

            UseSampleProject();
            UseSampleProjectUpdateFromGit();

            Console.ReadKey();
        }
    }
}
