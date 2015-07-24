using System;
namespace UI
{
    class Core
        {
            public static int k;
            //static void gameCore()
            //{
            //    gameProgress();                
            //}
            static public void gameProgress(string tag)
            {
                var pole = new int[3, 3];
                cleanPole(pole);
                int movePlayer = 1;                
                int[] k1 = new int[2]
                {
                    Convert.ToInt16(tag[0].ToString()),
                    Convert.ToInt16(tag[2].ToString())
                };
                pole[k1[0], k1[1]] = movePlayer;
                //    if (k % 2 == 0)
                //        movePlayer = 1;
                //    else
                //        movePlayer = 2;

                //    pole[k1[0], k1[1]] = movePlayer;                    
                //    switch (proverkaWin(pole, movePlayer))
                //    {
                //        case 1:
                //            Console.WriteLine("WIN-1");
                //            return;
                //        case 2:
                //            Console.WriteLine("WIN-2");
                //            return;
                //        case 3:
                //            Console.WriteLine("Ничья");
                //            return;
                //    }
                //}
            }
            static public int proverkaWin(int[,] pole2, int numberPlayer) //проверяет массив на выйгрыш
            {
                for (int i = 0; i < 3; i++)
                {
                    if (pole2[i, 0] == numberPlayer && pole2[i, 1] == numberPlayer && pole2[i, 2] == numberPlayer)
                        return numberPlayer;
                    if (pole2[0, i] == numberPlayer && pole2[1, i] == numberPlayer && pole2[2, i] == numberPlayer)
                        return numberPlayer;
                    if (pole2[0, 0] == numberPlayer && pole2[1, 1] == numberPlayer && pole2[2, 2] == numberPlayer)
                        return numberPlayer;
                    if (pole2[0, 2] == numberPlayer && pole2[1, 1] == numberPlayer && pole2[2, 0] == numberPlayer)
                        return numberPlayer;
                }
                if (k == 8)
                {
                    return 3;
                }
                return 0;
            }
            static public void cleanPole(int[,] pole2)  // отчиска массива
            {
                Array.Clear(pole2, 0, pole2.Length);
            }
    }
}


