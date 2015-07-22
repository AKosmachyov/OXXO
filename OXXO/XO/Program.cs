using System;
namespace OXXO
{
    class Program
    {
        public static int k;        
        static void Main(string[] args)
        {
            gameProgress();
            while (Console.ReadLine()!="0")
            {
                Console.WriteLine("Началось");
                gameProgress();
                Console.WriteLine("Хочешь сыграть в игру?");
            }
        }
        static public void gameProgress()
        {
            var pole = new int[3, 3];
            cleanPole(pole);
            int movePlayer = 0;
            for (k = 0; k < 9; k++)
            {
                string bbod = Console.ReadLine();
                int[] k1 = new int[2]
                {
                    Convert.ToInt16(bbod[0].ToString()),
                    Convert.ToInt16(bbod[2].ToString())
                };
                if (k % 2 == 0)
                    movePlayer = 1;
                else
                    movePlayer = 2;

                pole[k1[0], k1[1]] = movePlayer;
                showPole(pole);
                switch (proverkaWin(pole, movePlayer))
                {
                    case 1:
                        Console.WriteLine("WIN-1");
                        return;
                    case 2:
                        Console.WriteLine("WIN-2");
                        return;
                    case 3:
                        Console.WriteLine("Ничья");
                        return;
                }
            }
        }
        static public int proverkaWin(int[,] pole2,int numberPlayer)
        {            
            for (int i = 0; i < 3;i++ )
            {
                if (pole2[i, 0] == numberPlayer && pole2[i, 1] == numberPlayer && pole2[i, 2] ==numberPlayer )
                    return numberPlayer;
                if (pole2[0, i] == numberPlayer && pole2[1, i] == numberPlayer && pole2[2, i] == numberPlayer)
                    return numberPlayer;
                if (pole2[0,0]==numberPlayer && pole2[1,1]==numberPlayer && pole2[2,2]==numberPlayer)
                    return numberPlayer;
                if (pole2[0,2]==numberPlayer && pole2[1,1]==numberPlayer && pole2[2,0]==numberPlayer)
                    return numberPlayer;
            }
            if (k == 8)
            {
                return 3;
            }
            return 0;  
        }
        static public void cleanPole(int [,]pole2 )
        {    
            Array.Clear(pole2, 0, pole2.Length);
        }
        static public void showPole (int [,] pole2)
        {
            for (int i=0;i<3;i++)
            {
                for(int g=0;g<3;g++)
                {
                    Console.Write(pole2[i,g]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
