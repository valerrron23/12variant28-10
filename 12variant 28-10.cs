using System;
namespace ConsoleApplication9;
internal class Program
{
    private static void Main(string[] args)
    {
        string myStr; //���������� ���������� ����
        Console.WriteLine("������� ������: "); //����� ������


        /*
        myStr.Length - ����� ������
        myStr.IndexOf("test") - ����� ������� ��������� � ��������� ������

        myStr.Concat("test").Concat("12") - ����������� �������� � ������
 
        myStr.Equals("text") - ��������� ���� �����

        myStr.ToArray<Char>().ToList().ForEach(x => Console.WriteLine(x)); -//�������������� ������ � ������� � ����� � ������ � ����������� ��������� �������� � ������� �� �� �����
        */

        myStr = Console.ReadLine(); //�������� ������� ����������

        myStr.ToArray<Char>().ToList().ForEach(x => Console.WriteLine(x)); //�������������� ������ � ������� � ����� � ������ � ����������� ��������� �������� � ������� �� �� �����

        for (int i = 0; i < myStr.Length; i++) //����������� ����, ���� ����� �������
            Console.WriteLine(myStr[i]); //����� ������

        if (myStr.Length < 5) //����
            Console.WriteLine("\n� ������ ������ ������ 5 ��������"+"������ 2");
        else if ((myStr.Length >= 5) && (myStr.Length <= 12)) //������ �����, ������� �������
            Console.WriteLine("\n� ������ ������ {0} ��������", myStr.Length); //����� ������
        else Console.WriteLine("\n� ������ ������ ������ 12 ��������"); //�����

        Console.ReadLine(); //��������� ������� ������� ����� ������� ��� �������� 
    }
}