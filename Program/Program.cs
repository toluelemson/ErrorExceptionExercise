using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new D();
            }

            catch (B obj)
            {
                Console.WriteLine(obj);
            };
        }
    }

    class B : Exception
    {}

    class D : B
    {}
}


