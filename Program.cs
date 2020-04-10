using System;
using System.Linq;

namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int h;
            int m;

            while (true)
            {

                Console.WriteLine("Напипшите время в 'чч-мм' формате");
                String input = Console.ReadLine();
                String[] hAndM = input.Split('-');

                if (hAndM.Length > 2)
                {
                    Console.WriteLine("Много четрточек - !");
                    continue;
                }

                if (hAndM.Length <= 1)
                {
                    Console.WriteLine("Мало черточек - !!!");
                    continue;
                }

                String hString = hAndM[0];
                String mString = hAndM[1];

                if (hString == "")
                {
                    Console.WriteLine("Напишите часы!");
                    continue;
                }

                if (mString == "")
                {
                    Console.WriteLine("Напишите минуты!");
                    continue;
                }

                if (Int32.TryParse(hString, out h))
                {
                    if (h < 0 || h >= 24)
                    {
                        Console.WriteLine("Ошибка в часах!");
                        continue;
                    }
                }

                if (Int32.TryParse(mString, out m))
                {
                    if (m < 0 || m >= 60)
                    {
                        Console.WriteLine("Ошибка в  минутах!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Вы ввели время в неверном формате!");
            }

            double degress = ((h % 12) + (Convert.ToDouble(m) / 60)) * 30 - m * 6;

            if (degress < 0)
            {
                degress = Math.Abs(degress);
            }

            if (degress >= 180)
            {
                degress = degress - 180;
            }

            Console.WriteLine("Угол между стрелками равен {0:0.00} градусов", degress);
            Console.ReadLine();
        }
    }
}