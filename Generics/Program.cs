using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyList<string> isimler = new MyList<string>();
            isimler.Add("aziz");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine(isimler.Length);



        }
    }
}
