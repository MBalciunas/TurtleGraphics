using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGraphics
{
    public class Game
    {
        private Pen _pen;
        private Turtle _turle;
        private GameBoard _gameBoard;
        private bool _quit;
        private int _option;

        public Game()
        {
            _pen = new Pen();
            _turle = new Turtle();
            _gameBoard = new GameBoard();
            _quit = false;
        }

        public void GameLoop()
        {
            _gameBoard.InitGameBoard();
            do
            {
                Console.Clear();
                Console.WriteLine(Messages.ErrorMessage);
                Messages.ErrorMessage = "";
                _gameBoard.DrawGameBoard(_turle.PositionX, _turle.PositionY, _turle.TurtleSymbol);
                Messages.Instructions();
                Console.WriteLine(_pen);
                Console.WriteLine("Select your option: ");
                if (int.TryParse(Console.ReadLine(), out _option))
                {
                    if (_option > 0 && _option < 3)
                    {
                        _pen.PenAction = (Pen.PenActions)_option;
                    }
                    else if (_option > 2 && _option < 7)
                    {
                        Directions.TurtleDirections direction = (Directions.TurtleDirections)_option;
                        Console.WriteLine($"Turtle is moving {direction}");
                        Console.WriteLine("Enter number of spaces to move: ");
                        int spaces;
                        if (int.TryParse(Console.ReadLine(), out spaces))
                        {
                            _turle.Walk(direction, spaces, _pen.PenAction);
                        }
                        else
                            Messages.InvalidInput();
                    }
                    else if (_option == 7)
                        _quit = true;
                    else Messages.InvalidInput();
                }
                else
                    Messages.InvalidInput();

            } while (!_quit);
        }

    }
}
