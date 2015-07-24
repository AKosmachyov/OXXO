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
		
		private goMove(int x, int y){
			//осуществляет ход - заполняет массим 1 или 2 в зависимотсти о того, кто ходит
		}
		private int checkGameStatus(){
			//проверяет статус игры 0-игра в процессе 1-выиграли крестики 2-выиграли нолики 3-ничья
		}
	}
}