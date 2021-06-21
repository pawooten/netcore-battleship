using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public static class ArgumentValidator
    {
        /// <summary>
        /// Throws an exception if the playerName argument is null or an empty string
        /// </summary>
        /// <param name="playerName"></param>
        public static void ValidatePlayerName(string playerName)
        {
            if (string.IsNullOrEmpty(playerName))
            {
                throw new ArgumentException( $"Invalid player name specified: {playerName}" );
            }
        }

        /// <summary>
        /// Throws an exception if the specified playerType enumeration value is not defined within the enumeration.
        /// </summary>
        /// <param name="playerType"></param>
        public static void ValidatePlayerType(PlayerType playerType)
        {
            if (!Enum.IsDefined(typeof(PlayerType), playerType))
            {
                throw new ArgumentException( $"Unrecognized PlayerType {playerType}" );
            }
        }

        /// <summary>
        /// An 8x8 board is the smallest permitted board size.
        /// </summary>
        public static readonly int MINIMUM_BOARD_SIZE = 8;
        /// <summary>
        /// A 16x16 board is the largest permitted bord size.
        /// </summary>
        public static readonly int MAXIMUM_BOARD_SIZE = 16;
        public static void ValidateGameBoardSize(int boardSize)
        {
            if (boardSize < MINIMUM_BOARD_SIZE || boardSize > MAXIMUM_BOARD_SIZE)
            {
                throw new ArgumentException( $"Invalid board size specified: {boardSize}" );
            }
        }
    }
}
