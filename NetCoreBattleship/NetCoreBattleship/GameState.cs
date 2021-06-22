using Battleship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBattleship
{
    public sealed class GameState
    {
        /// <summary>
        /// The name of the player
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Label each player's board as either Player One or Player Two
        /// </summary>
        public string Label
        {
            get;
            private set;
        }

        public int BoardSize
        {
            get;
            private set;
        }

        public CellStateType[,] Board
        {
            get;
            private set;
        }

        public static GameState FromPlayerGameBoard(PlayerGameBoard gameBoard )
        {
            GameState gameState = new GameState();
            gameState.Name = gameBoard.PlayerName;
            gameState.Label = gameBoard.PlayerType.ToPlayerLabel();
            var board = new CellStateType[gameBoard.BoardSize, gameBoard.BoardSize];
            for (int row = 0; row < gameBoard.BoardSize; row++)
            {
                for (int column = 0; column < gameBoard.BoardSize; column++ )
                {
                    board[row, column] = gameBoard[row, column];
                }
            }
            gameState.BoardSize = gameBoard.BoardSize;
            gameState.Board = board;
            return gameState;
        }
    }
}
