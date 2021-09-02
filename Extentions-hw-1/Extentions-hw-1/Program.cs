using System;
using System.Text.RegularExpressions;

namespace Extentions_hw_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1234566aaS123";
            string s2 = "123VGHJ12 =-)(";
            bool b1 = s1.HasLowerChars();
            bool b2 = s2.HasLowerChars();
            s1 = s1.ReverseCase();

            int[] tstnums = { 7, 37, 102, 40 };
            for (int i = 0; i < 4; i++)
            {
                string s = tstnums[i].Print();
                Console.WriteLine(tstnums[i]+"  " + s);
            }
            
            
            Console.WriteLine("enter id : ");
             string idst= Console.ReadLine();
            bool b = idst.IsValidIsraeliIdNumber();
        }
    }
    static class Extentions
    {
        //######## task1  ###############################
        public static bool HasLowerChars(this string st)
        {
            bool res;
            foreach (var ch in st)
            {
                if (ch >= 'a' && ch <= 'z') return true;
                else continue;
            }
            return false;
        }
        //#####  task 2  ####################
        public static string ReverseCase(this string st)
        {
            string newst = "";
            int chval;
            for (int i = 0; i < st.Length; i++)

            {

                if (st[i] >= 'a' && st[i] <= 'z')
                {
                    chval = st[i] - ('a' - 'A');
                    newst = newst + (char)chval;
                }
                else if (st[i] >= 'A' && st[i] <= 'Z')
                {
                    chval = st[i] + ('a' - 'A');
                    newst = newst + (char)chval;
                }
                else newst = newst + st[i];
            }
            return newst;
        }

        //######### task 3   ##################
        public static string Print(this int val)
        {
            if ((val > 100) || (val < 0))
            {
                return "Ad Kan!";
            }
            else return NumToWords(val);
        }
        public static string NumToWords(int value)
        {
            string[] nums0to19 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen" };
            string[] nums21to99 = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "eighty", "ninety" };
            string num100 = "hundred";
            if (value == 100) return num100;
            else if ((value >= 0) && (value < 20))
            {
                return nums0to19[value];
            }
            else if (value % 10 == 0) return nums21to99[value / 10];
            else return nums21to99[value / 10] + " " + nums0to19[value % 10];
        }

//  #####  task 6 ###########################
        public static bool IsValidIsraeliIdNumber (this string id)
        {
           
            var regex = new Regex(@"\d{9}") ;
            if (!regex.IsMatch(id)) return false;
            else
            {
                
                int mas1 = int.Parse("" + id[1])*2;
                if (mas1>9) { mas1 = mas1 / 10 + mas1 % 10; }
                int mas2 = int.Parse("" + id[2]);
                int mas3 = int.Parse("" + id[3]) * 2;
                if (mas3 > 9) { mas3 = mas3 / 10 + mas1 % 10; }
                int mas4 = int.Parse("" + id[4]);
                int mas5 = int.Parse("" + id[5]) * 2;
                if (mas5 > 9) { mas5 = mas5 / 10 + mas5 % 10; }
                int mas6 = int.Parse("" + id[6]);
                int mas7 = int.Parse("" + id[7] )* 2;
                if (mas7 > 9) { mas7 = mas7 / 10 + mas7 % 10; }
                int mas8 = int.Parse("" +id[8]);
                int sum = mas1 + mas3 + mas5 + mas7 + mas2 + mas4 + mas6 + mas8;
                int checknum = 10 - sum % 10;
                if (int.Parse("" + id[0]) == checknum) return true;
                else return false;
                
            }
        }
    }
}

