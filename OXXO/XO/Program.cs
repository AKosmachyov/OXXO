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
                    if (proverka(pole,1) == 1)
                    {Console.WriteLine("WIN-1");
                    break;
                    }
                }
                else
                {
                    pole[k1[0], k1[1]] = 2;                    
                    if (proverka(pole, 2) == 2)
                    {
                        Console.WriteLine("WIN-2");
                        break;
                    }
                }
                for (int i = 0; i < 3; i++)             //    
                {
                    Console.WriteLine();
                    for (int g = 0; g < 3; g++)             //Вывод таблицы в консоль
                        Console.Write(pole[i, g]);
                }                                       //
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        static public int proverka(int[,] pole2,int ab)
        {
            int n=ab;
            for (int i = 0; i < 3;i++ )
            {                
                    if (pole2[i, 0] == n && pole2[i, 1] == n && pole2[i, 2] ==n )
                        return n;
                    if (pole2[0, i] == n && pole2[1, i] == n && pole2[2, i] == n)
                        return n;
                    if (pole2[0,0]==n && pole2[1,1]==n && pole2[2,2]==n )
                        return n;
                    if (pole2[0,2]==n && pole2[1,1]==n && pole2[2,0]==n  )
                        return n;
            }
                return 0;
        }
    }
}
