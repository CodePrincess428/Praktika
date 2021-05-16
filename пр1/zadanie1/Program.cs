using System;

namespace zadanie1
{
    using static lib1;
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(lib1.stpow("ha", 4));
            Console.WriteLine(lib1.rev("xev"));
            Console.WriteLine(lib1.remov("xeveer", "e"));
            Console.WriteLine(lib1.leng("xeveer"));
        }
    }
}
