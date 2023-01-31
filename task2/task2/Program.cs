using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis ededler siyahisindan yalniz musbet ededler qalan yeni bir siyahi duzelden metod
            int[] numbers = { 10, -5, 63, -96, 56 };
            int[] newnumbers = AncaqMusbet(numbers);
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(newnumbers[i]);
            }
               

        }
        static int[] AncaqMusbet(int[] num)
        {
            int[] newnumbers=new int[num.Length];

            for(int i=0;i<num.Length;i++)
            {
                if (num[i]>0)
                    newnumbers[i] = num[i];   
            }
            return newnumbers;
        }

    }
}
