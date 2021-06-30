using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //an intance can not be created, because ctor is private, instead
            //get instance calling the static method of the class
            Source source_1 = Source.GetSourceInstance();
            Source source_2 = Source.GetSourceInstance();

            //Both objects are the same
            Console.WriteLine(source_1.GetHashCode());//58225482
            Console.WriteLine(source_2.GetHashCode());//58225482           
        }
    }
}
