using System;
using System.Windows;
namespace UI
{   
    class Game
    {
        public Game()
        {
            Random rnd = new Random();
            whoIsNow = (rnd.Next() % 2) + 1;
            firstMove = whoIsNow;
            gameField = new int[3, 3];
        }
        public Game(int nowPlayed)
        {
            whoIsNow = nowPlayed;
            changePlayerMove();
            firstMove = whoIsNow;
            gameField = new int[3, 3];
        }

        private int whoIsNow;
        private int[,] gameField;
        private int numberMoves = 0;
        private int firstMove;

        public int goMove(string tag)
        {

            var koordinata = new CreatPoint.Point() { X = Convert.ToInt16(tag[0].ToString()), Y = Convert.ToInt16(tag[2].ToString()) };
            int returnValue = -1;
            if (possibleMove(koordinata))
            {
                returnValue = 0;
                gameField[koordinata.X, koordinata.Y] = whoIsNow;
                numberMoves++;
                if (numberMoves > 4)
                    returnValue = checkGameStatus();
                changePlayerMove();
            }
            return returnValue;
            //осуществляет ход - заполняет массим 1 или 2 в зависимотсти о того, кто ходит
        }
        public int checkGameStatus()
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameField[i, 0] == whoIsNow && gameField[i, 1] == whoIsNow && gameField[i, 2] == whoIsNow)
                    return whoIsNow;
                if (gameField[0, i] == whoIsNow && gameField[1, i] == whoIsNow && gameField[2, i] == whoIsNow)
                    return whoIsNow;
                if (gameField[0, 0] == whoIsNow && gameField[1, 1] == whoIsNow && gameField[2, 2] == whoIsNow)
                    return whoIsNow;
                if (gameField[0, 2] == whoIsNow && gameField[1, 1] == whoIsNow && gameField[2, 0] == whoIsNow)
                    return whoIsNow;
            }
            if (numberMoves == 9)
                return 3;
            //проверяет статус игры 0-игра в процессе 1-выиграли крестики 2-выиграли нолики 3-ничья
            return 0;
        }
        public string getUri()
        {
            if (whoIsNow == 1)
            {
                return "/Resource/X.png";
            }
            else
                return "/Resource/O.png";
        }
        public int getWhoIsNow()
        {
            return whoIsNow;
        }
        private bool possibleMove(CreatPoint.Point point)
        {
            return gameField[point.X, point.Y] == 0;
        }
        private int changePlayerMove()
        {
            if (whoIsNow == 1)
                whoIsNow++;
            else
                whoIsNow--;
            return whoIsNow;
        }
        public int getFirstMove()
        {
            return firstMove;
        }
    }
}
//TODO Ничья+
//TODO Cчетчик+
//TODO Reset во время  игры и начать заново
//TODO Проверка хода +
//TODO время на игру
//TODO Сделать поле