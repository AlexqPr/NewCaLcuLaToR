namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)    //я поменял условные конструкции if на конструкцию выбора, то есть  switch/case
            //также поменял циикл  while на цикл do/while
        {
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1.Сложить 2 числа");
            Console.WriteLine("2.Вычесть первое из второго");
            Console.WriteLine("3.Перемножить два числа");
            Console.WriteLine("4.Разделить первое на второе");
            Console.WriteLine("5.Возвести в степень N первое число");
            Console.WriteLine("6.Найти квадратный корень из числа");
            Console.WriteLine("7.Найти 1 процент от числа");
            Console.WriteLine("8.Найти факториал числа");
            Console.WriteLine("9.Выход из программы");


            int number = Convert.ToInt32(Console.ReadLine());
            do

            {

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Введите первое");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваш результат: " + (a + b));
                        break;

                    case 2:
                        Console.WriteLine("Введите первое");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваш результат: " + (a1 - b1));
                        break;

                    case 3:
                        Console.WriteLine("Введите первое");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваш результат: " + a2 * b2);
                        break;

                    case 4:
                        Console.WriteLine("Введите первое");
                        float a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе");
                        float b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваш результат: " + a3 / b3);
                        break;

                    case 5:
                        Console.WriteLine("Введите число");
                        int a4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите степень");
                        int b4 = Convert.ToInt32(Console.ReadLine());
                        int c = 1;
                        for (int i = 0; i < b4; i++)
                        {
                            c = c * a4;

                        }
                        Console.WriteLine("Ваш результат: " + c);
                        break;

                    case 6:
                        Console.WriteLine("Введите число");
                        int a5 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ваш результат: " + Math.Sqrt(a5));
                        break;

                    case 7:
                        Console.WriteLine("Введите число");
                        float a6 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ваш результат: " + a6 / 100);
                        break;

                    case 8:
                        Console.WriteLine("Введите число");


                        int c7 = 1;
                        int a7 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= a7; i++)
                        {
                            c7 = c7 * i;
                        }
                        Console.WriteLine("Ваш результат:" + c7);
                        break;
                }



                int jkf = Convert.ToInt32((Console.ReadLine()));
                number = jkf;
            }
            while (number != 9);
        }

    }
}