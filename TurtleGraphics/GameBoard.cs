using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGraphics
{
    public class GameBoard
    {
        public const int GameBoardSize = 20;
        public const char UsedSpace = 'O';
        public const char GameBoardSymbol = '.';

        public GameBoard()
        {
            GameBoardArray = new char[GameBoardSize, GameBoardSize];
        }

        public static char[,] GameBoardArray { get; set; }

        public static void UpdateGameBoardX(int start, int spacesToMove, int upOrDown, int constantY)
        {
            for (var i = 0; i < spacesToMove; i++)
            {
                GameBoardArray[start + (i * upOrDown), constantY] = UsedSpace;
            }
        }

        public static void UpdateGameBoardY(int start, int spacesToMove, int leftOrRight, int constantX)
        {
            for (var i = 0; i < spacesToMove; i++)
            {
                GameBoardArray[constantX, start + (i * leftOrRight)] = UsedSpace;
            }
        }


        public void DrawGameBoard(int posX, int posY, char turtle)
        {
            for (int i = 0; i < GameBoardSize; i++)
            {
                for (int j = 0; j < GameBoardSize; j++)
                {
                    if (i == posX && j == posY)
                        Console.Write(turtle);
                    else
                        Console.Write(GameBoardArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void InitGameBoard()
        {
            for (int i = 0; i < GameBoardSize; i++)
            {
                for (int j = 0; j < GameBoardSize; j++)
                {
                    GameBoardArray[i, j] = GameBoardSymbol;
                }
            }
        }
    }
}
