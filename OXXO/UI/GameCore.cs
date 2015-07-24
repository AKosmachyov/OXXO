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
		private void startGame(){

		}
		private goMove(int x, int y){

		}
		private int checkGameStatus(){

		}
	}
}