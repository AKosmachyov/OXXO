using System;
using Windows.UI.Popups;
namespace UI
{
    class Core
        {
            static int[,] pole = new int[3, 3];
            static int movePlayer = 1;
            
            static public void gameProgress(string tag)
            {
                int[] k1 = new int[2]
                {
                    Convert.ToInt16(tag[0].ToString()),
                    Convert.ToInt16(tag[2].ToString())
                };
                pole[k1[0], k1[1]] = movePlayer;
                proverkaWin(pole, movePlayer);
                 switch (proverkaWin(pole, movePlayer))
                 {
                     case 1:
                         var messageDialog1 = new MessageDialog("Win-1");
                         messageDialog1.ShowAsync();
                         return;
                     case 2:
                         var messageDialog2 = new MessageDialog("Win-2");
                         messageDialog2.ShowAsync();
                         return;                         
                     case 3:
                         var messageDialog3 = new MessageDialog("Ничья");
                         messageDialog3.ShowAsync();
                         return;
                 }
                if (movePlayer == 1)
                    movePlayer++;
                else
                    movePlayer--;
            }
        static public int proverkaWin(int[,] pole2, int numberPlayer)
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
                return 0;
        }
        static public void cleanPole()
        {
            Array.Clear(pole, 0, pole.Length);
        }
        static public string uri()
        {
            if (movePlayer == 1)
            {
                return "/Resource/firefox.png";
            }
            else
                return "/Resource/unnamed.png";
        }
    }
}


