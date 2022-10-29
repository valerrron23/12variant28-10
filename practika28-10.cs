using System;
namespace aip9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 101; i++) //выполняется цикл, пока верно условие
            {
                if (i % 2 != 0) //выполняется проверка условия нечетности чисел
                {
                    Console.Write("{0} ", i); //вывод данных
                }
            }
            Console.ReadKey(); //программа ждёт когда пользователь нажмёт клавишу
            return; //возврат цикла
        }
    }
}
