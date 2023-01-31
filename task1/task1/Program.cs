using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod
            string word = FirstSpace("   Salam necesen");
            Console.WriteLine(word);
        }
        static string FirstSpace(string text)
        {
            string newword = "";
            for(int i=0;i<text.Length;i++)
            {
                if (text[i] != ' ')
                  newword+= text[i];

               
            }
            return newword;
        }
    }
}
