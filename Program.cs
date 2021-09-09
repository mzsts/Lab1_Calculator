using System;

namespace Lab1_Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Высота стен: ");

            double wallsHeight;
            while (Double.TryParse(Console.ReadLine(), out wallsHeight) is false || wallsHeight <= 0)
            {
                Console.WriteLine("Ошибка ввода, введите корректные данные.");
            }

            Console.Write("Введите длинну стен: ");

            double wallsWidth;
            while (Double.TryParse(Console.ReadLine(), out wallsWidth) is false || wallsWidth <= 0)
            {
                Console.WriteLine("Ошибка ввода, введите корректные данные.");
            }
            

            Console.WriteLine("Какой вид ремонта будет проводиться?\nОбои или краска?");
            string answer = Console.ReadLine().ToLower();

            while (answer != "обои" && answer != "краска")
            {
                Console.WriteLine("Ошибка ввода, введите \"Обои\" или \"Краска\"");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "обои")
            {
                Console.WriteLine("Сколько стоит один рулон?");

                double rollPrice;
                while (Double.TryParse(Console.ReadLine(), out rollPrice) is false || rollPrice <= 0)
                {
                    Console.WriteLine("Ошибка ввода, введите корректные данные.");
                }

                Console.WriteLine("Ширина рулона?");

                double rollWidth;
                while (Double.TryParse(Console.ReadLine(), out rollWidth) is false || rollWidth <= 0)
                {
                    Console.WriteLine("Ошибка ввода, введите корректные данные.");
                }

                Console.WriteLine($"Стоимость для материала {answer} равна {CalculateForWallpaper(wallsWidth, rollPrice, rollWidth)}");
            }
            else
            {
                Console.WriteLine("Сколько стоит один литр краски?");

                double paintPrice;
                while (Double.TryParse(Console.ReadLine(), out paintPrice) is false || paintPrice <= 0)
                {
                    Console.WriteLine("Ошибка ввода, введите корректные данные.");
                }

                Console.WriteLine("Сколько литров краски расходуется на 1м^2?");

                double paintConsumption;
                while (Double.TryParse(Console.ReadLine(), out paintConsumption) is false || paintConsumption <= 0)
                {
                    Console.WriteLine("Ошибка ввода, введите корректные данные.");
                }

                Console.WriteLine($"Стоимость для материала {answer} равна {CalculateForPaint(wallsWidth * wallsHeight, paintPrice, paintConsumption)}");
            }  
        }

        private static double CalculateForPaint(double wallsPerimeter, double paintPrice, double paintConsumption) =>
            paintPrice * (int)Math.Ceiling(wallsPerimeter / paintConsumption);

        private static double CalculateForWallpaper(double wallsWidth, double rollPrice, double rollWidth) => 
            rollPrice * (int)Math.Ceiling(wallsWidth / rollWidth);
    }
}
