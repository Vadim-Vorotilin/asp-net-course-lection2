using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
