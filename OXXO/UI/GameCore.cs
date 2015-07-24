using System;
namespace UI
{
	class Game
	{
		public Game(){
			Random rnd = new Random();
			whoIsNow = rnd.Next() % 2;
			gameField = new int [3,3];
		}
		private int whoIsNow;
		private int[,] gameField;

		private int startGame()
		{
			//очищает поле-генерирует случайную очерёдность (кто сечас крестик или нолик) и возвращает кто ходит 1 если первым ходит крестик 2- если нолик ну или как хочешь на самом деле (моджно 0 и 1)
		}

		private int goMove(int x, int y)
		{
			//осуществляет ход - заполняет массим 1 или 2 в зависимотсти о того, кто ходит
			//и возвращает 0-если игра продолжается или 1 2 3 если кончилась
		}
		private int checkGameStatus()
		{
			//проверяет статус игры 0-игра в процессе 1-выиграли крестики 2-выиграли нолики 3-ничья
		}
	}
}