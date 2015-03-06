using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_Problem01
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int decimalNumber = 0;
            int count = 0;

            int temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
               var word = input[i];
               decimalNumber = 0;
               count = 0;
               for (int j = word.Length-1; j >= 0 ; j--)
               {
                  
                   
                   int number = word[j] - 'a';
                   int sum = number * (int)Math.Pow(23, count);
                   count++;
                   decimalNumber += sum;
                   
               }
               temp += decimalNumber;
               
            }
            int resultInDecimal = temp;
            var twentyThree = new List<char>();
            int length = temp.ToString().Length;
           
            for (int i = 0; i < length; i++)
            {
                int digit = temp % 23;
                temp /= 23;
               
                    int number = digit + 'a';
                    char symbol = Convert.ToChar(number);
                    twentyThree.Add(symbol);
                    if (temp == 0)
                    {
                        break;
                    }
                              
            }
            twentyThree.Reverse();
            string resultIn23 = string.Join("",twentyThree);
            Console.WriteLine("{0} = {1}",resultIn23,resultInDecimal);
        }
    }
}
