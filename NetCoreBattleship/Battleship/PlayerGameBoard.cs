using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    /// <summary>
    /// Represents each player's game board, in which they position their ships, and their opponent selects coordinates
    /// to attack.
    /// </summary>
    public class PlayerGameBoard
    {
        private string _playerName;
        private PlayerType _playerType;
        private int _boardSize;

        private CellStateType[,] _gameBoardCells;

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
                _playerType = playerType;
            }
            catch ( ArgumentException innerException )
            {
                throw new ApplicationException( "Invalid PlayerType specified", innerException );
            }
            try
            {
                ArgumentValidator.ValidateGameBoardSize( boardSize );
                _boardSize = boardSize;
            }
            catch (ArgumentException)
            {
                _boardSize = DefaultSettings.DEFAULT_BOARD_SIZE;
            }
            try
            {
                ArgumentValidator.ValidatePlayerName( playerName );
                _playerName = playerName;
            }
            catch (ArgumentException)
            {
                _playerName = DefaultSettings.GetDefaultNameForPlayerType( playerType );
            }

            _gameBoardCells = initializeEmptyGameBoardCells();
        }

        private CellStateType[,] initializeEmptyGameBoardCells()
        {
            var cells = new CellStateType[_boardSize, _boardSize];
            for (int row = 0; row < _boardSize; row++)
            {
                for (int column = 0; column < _boardSize; column++)
                {
                    cells[row, column] = CellStateType.Empty;
                }
            }
            return cells;
        }
    }
}
