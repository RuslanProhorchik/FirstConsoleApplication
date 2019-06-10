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

        public static void UseSampleProjectUpdateFromGit22()
        {
            Console.WriteLine("Hello UseSampleProjectUpdateFromGit22!!!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello first console Application!!!");

            UseSampleProject();
            
            UseSampleProjectUpdateFromGit();
            
            UseSampleProjectUpdateFromGit22();

            Console.ReadKey();
        }
    }
}
