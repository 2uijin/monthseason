using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string num = Regex.Replace(input, @"\D", ""); 
            int month = int.Parse(num);

            
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨겨울울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여여름름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가가을을");
                    break;
                default:
                    Console.WriteLine("잘잘못못된된입입력력");
                    break;
            }
        }
    }
}
