#undef TRIAL
#define PROFESSIONAL
using System;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
#if (TRIAL)
    Console.WriteLine("This is a trail version.");
#elif (PROFESSIONAL)
     Console.WriteLine("This is a professional version.");
#else
            Console.WriteLine("This is an enterprise version.");

#endif
            Console.WriteLine("Hello World!");
        }
    }
}

