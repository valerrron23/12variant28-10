using System;
namespace ConsoleApplication9;
internal class Program
{
    private static void Main(string[] args)
    {
        string myStr; //переменныя строкового типа
        Console.WriteLine("Введите строку: "); //вывод данных

        /*
        myStr.Length - длина строки
        myStr.IndexOf("test") - поиск позиции подстроки в указанной строке
        myStr.Concat("test").Concat("12") - объединение подстрок в строку
        myStr.Equals("text") - сравнение двух строк
        myStr.ToArray<Char>().ToList().ForEach(x => Console.WriteLine(x)); -//преобразование строки к массиву и затем к списку с последующим перебором символов и выводом их на экран
        */

        myStr = Console.ReadLine(); //вводится задание переменной
        myStr.ToArray<Char>().ToList().ForEach(x => Console.WriteLine(x)); //преобразование строки к массиву и затем к списку с последующим перебором символов и выводом их на экран

        for (int i = 0; i < myStr.Length; i++) //выполняется цикл, пока верно условие
            Console.WriteLine(myStr[i]); //вывод данных
        if (myStr.Length < 5) //если
            Console.WriteLine("\nВ данной строке меньше 5 символов"+"строка 2");
        else if ((myStr.Length >= 5) && (myStr.Length <= 12)) //другой исход, проврка условия
            Console.WriteLine("\nВ данной строке {0} символов", myStr.Length); //вывод данных
        else Console.WriteLine("\nВ данной строке больше 12 символов"); //иначе

        Console.ReadLine(); //программа ожидает нажатия любой клавиши для закрытия 
    }
}
