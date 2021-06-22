using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    /// <summary>
    /// Represents each player's game board, in which they position their ships, and their opponent selects coordinates
    /// to attack.
    /// </summary>
    public sealed class PlayerGameBoard
    {
        public string PlayerName
        {
            get;
            private set;
        }
        public PlayerType PlayerType
        {
            get;
            private set;
        }
        public int BoardSize
        {
            get;
            private set;
        }

        private CellStateType[,] _gameBoardCells;

        public CellStateType this[int row, int column] => _gameBoardCells[row, column];

        /// <summary>
        /// Instantiates a new game board 
        /// </summary>
        /// <param name="playerName">The name of the player who owns this board</param>
        /// <param name="playerType">A description of the player who owns this board</param>
        /// <param name="boardSize">The size of the game board. Game boards are always square. This parameter describes the number of rows and number of columns
        /// of the game board</param>
        public PlayerGameBoard(string playerName, PlayerType playerType, int boardSize)
        {
            try
            {
                ArgumentValidator.ValidatePlayerType( playerType );
                PlayerType = playerType;
            }
            catch ( ArgumentException innerException )
            {
                throw new ApplicationException( "Invalid PlayerType specified", innerException );
            }
            try
            {
                ArgumentValidator.ValidateGameBoardSize( boardSize );
                BoardSize = boardSize;
            }
            catch (ArgumentException)
            {
                BoardSize = DefaultSettings.DEFAULT_BOARD_SIZE;
            }
            try
            {
                ArgumentValidator.ValidatePlayerName( playerName );
                PlayerName = playerName;
            }
            catch (ArgumentException)
            {
                PlayerName = DefaultSettings.GetDefaultNameForPlayerType( playerType );
            }

            _gameBoardCells = initializeEmptyGameBoardCells();
        }

        private CellStateType[,] initializeEmptyGameBoardCells()
        {
            var cells = new CellStateType[BoardSize, BoardSize];
            for (int row = 0; row < BoardSize; row++)
            {
                for (int column = 0; column < BoardSize; column++)
                {
                    cells[row, column] = CellStateType.Empty;
                }
            }
            return cells;
        }
    }
}
