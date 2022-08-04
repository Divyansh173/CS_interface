using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Operations
{
    public class digittoword
    {
        public string digit_word(int number ) 
        {
            string[] a = { "Zero", "One", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] b = { "ten", "eleven", "twelvw", "thirteen", "fourteen", "fifteen", "sixteen", "eighteen", "nineteen" };
            string[] c = { "Zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };
            //int number = Convert.ToInt32(Console.ReadLine());
            int temp;
            string str = "";
            if (number <= 99999)
            {
                if (number == 0)
                {
                    //Console.Write(" " + a[number]);
                    str += " " + a[number];

                }

                if (number >= 1000)
                {

                    temp = number / 1000;
                    if (number % 10000 == 0)
                    {
                        temp = temp / 10;
                        //Console.Write();
                        str += " " + b[temp - 1] + "thousand";

                    }

                    if (number % 1000 == 0)
                    {
                        //Console.Write(" " + a[temp] + "thousand");
                        str += " " + a[temp] + "thousand";
                    }
                    if (temp >= 10 && temp <= 19)
                    {
                        temp = temp % 10;
                        //Console.Write(" " + b[temp] + " ");
                        str += " " + b[temp] + " ";
                        temp = -1;
                    }
                    if (temp >= 20 && temp <= 99)
                    {
                        int i = temp / 10;
                        temp = temp % 10;
                        //Console.Write(" " + c[i]);
                        str += " " + c[i];
                    }
                    if (temp > 0 && temp <= 9)
                    {
                        //Console.Write(" " + a[temp] + " ");
                        str += " " + a[temp] + " ";
                    }

                    // Console.Write("thousand");
                    str += "thousand";

                    number = number % 1000;

                }
                if (number >= 100)
                {
                    temp = number / 100;
                    if (number % 100 == 0)
                    {
                        // Console.Write(" " + a[temp] + "hundred");
                        str += " " + a[temp] + "hundred";
                    }

                    number = number % 100;

                    //Console.Write(" " + a[temp] + "hundred");
                    str += " " + a[temp] + "hundred";

                }

                if (number >= 10 && number < 20)
                {

                    temp = number % 10;

                    //Console.Write(" " + b[temp] + " ");
                    str += " " + b[temp] + " ";

                }

                if (number > 19 && number <= 100)
                {

                    temp = number / 10;

                    if (number == 100)
                    {
                       // Console.Write(" " + c[temp - 1]);
                        str += " " + c[temp - 1];
                    }

                    number = number % 10;

                    //Console.Write(" " + c[temp] + " ");
                    str += " " + c[temp] + " ";

                }
                if (number < 10)
                {
                    if (number != 0)
                        //Console.Write(" " + a[number]);
                    str += " " + a[number];

                }

            }
            return str;
        }
    }
}
