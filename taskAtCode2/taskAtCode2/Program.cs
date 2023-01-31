using System;
using System.Globalization;

namespace taskAtCode2
{
    internal class Program
    {
        static void Main(string[] args)
        {// Verilmis ededler siyahisindaki musbet ededlerin cemini tapan metod
            int[] nums = { 10, 56, 5, 6 };
            Console.WriteLine(Sum(nums));


           
            //Verilmis ededi verilmis quvvete yukselden metod
            Console.WriteLine(Power(2,4));



            //Verilmis yazida a charinin sayini tapan metod
            Console.WriteLine(Char("qasim"));



            //Verilmis yazida a charinin olub olmadigini tapan metod
            Console.WriteLine(Aherfi("asus"));



            //Verilmis yazida verilmis charin sayini tapan metod
            Console.WriteLine(NumOfChar("nasah",'h'));



            //Verilmis ededler siyahisinda verilmis ededin yerlesdiyi ilk indexi qaytaran metod
            int[] numbers = { 10, 85, 96, 45 };
            var index=LookForIndex(numbers, 96);
            Console.WriteLine(index);


            //Verilmis yazidaki ilk sozu (lk bosluga qeder olan hisseni) qaytaran metod
            string word = FirstWord("Salam Kenan neterse");
            Console.WriteLine(word);



        }





        // Verilmis ededler siyahisindaki musbet ededlerin cemini tapan metod
        static int Sum(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    sum += nums[i];
            }
            return sum;
        }

        
        
        
        //Verilmis ededi verilmis quvvete yukselden metod
        static int Power(int num,int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;  
        }




        //Verilmis yazida a charinin sayini tapan metod
        static int Char(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                    count += 1;
            }
            return count;
                
        }


        //Verilmis yazida a charinin olub olmadigini tapan metod
        static bool Aherfi(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                    return true;
            }
            return false;
        }



        //Verilmis yazida verilmis charin sayini tapan metod
        static int NumOfChar(string text,char cr)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == cr)
                    count++;
            }
            return count;

        }


        //Verilmis ededler siyahisinda verilmis ededin yerlesdiyi ilk indexi qaytaran metod
        static int LookForIndex(int[] numbers, int num)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==num)
                    return i;
            }
            return-1;
        }



        //Verilmis yazidaki ilk sozu (lk bosluga qeder olan hisseni) qaytaran metod
        static string FirstWord(string text)
        {
            string newword = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    break;

                    newword += text[i];

            }
            return newword;
        }




    }
}
