using System;

class Decoding
    {
        static void Main()
        {
            int salt =int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int counterEven = 0;
          
            double symbol = 0;
            foreach (char c in text)
            
            {
                
                if (c == '@')
                {
                    break;
                }
                else if ((c >= 'A' && c <= 'Z') || (c >= 'a'&& c <= 'z') )
                {
                     symbol = (int)Convert.ToChar(c);
                     symbol *= salt;
                        symbol+=1000;
                }
                else if (c >= '0' && c <= '9')
                {
                     symbol = (int)Convert.ToChar(c);
                    symbol += salt + 500;
                   
                }
                else
                {
                    symbol = (int)Convert.ToChar(c);
                    symbol -= salt;
                    
                }
               
                if (counterEven % 2 == 0)
                {
                    
                    symbol /= 100;
                    Console.WriteLine("{0:F2}",symbol);
                    
                }
                else 
                {
                    
                    
                    symbol *= 100;
                    Console.WriteLine(symbol);
                }
                counterEven++;
              
                

            }
        }
    }

