using System;
namespace aip9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 101; i++) //����������� ����, ���� ����� �������
            {
                if (i % 2 != 0) //����������� �������� ������� ���������� �����
                {
                    Console.Write("{0} ", i); //����� ������
                }
            }
            Console.ReadKey(); //��������� ��� ����� ������������ ����� �������
            return; //������� �����
        }
    }
}
