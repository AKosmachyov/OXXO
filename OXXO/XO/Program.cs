using System;
namespace OXXO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[3, 3];
            for (int k = 0; k < 9; k++)
            {
                string bbod = Console.ReadLine();   
                int[] k1 = new int[2]
                {
                    Convert.ToInt16(bbod[0].ToString()),
                    Convert.ToInt16(bbod[2].ToString())
                };
                if (k % 2 == 0)
                {
                    pole[k1[0], k1[1]] = 1;
                }
                else
                {
                    pole[k1[0], k1[1]] = 2;
                }
                for (int i = 0; i < 3; i++)             //
                {
                    Console.WriteLine();
                    for (int g = 0; g < 3; g++)             //Вывод таблицы
                        Console.Write(pole[i, g]);
                }                                       //
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        static public int proverka(int[,] pole2)
        {
            
            return 0;
        }
    }
}
