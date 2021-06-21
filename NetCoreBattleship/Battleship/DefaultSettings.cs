using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public static class DefaultSettings
    {
        /// <summary>
        /// The default board 
        /// </summary>
        public static readonly int DEFAULT_BOARD_SIZE = 8;

        /// <summary>
        /// Returns a default name based on the specified enumeration value.
        /// </summary>
        /// <param name="playerType">Describes the player whose default name should be returned.</param>
        /// <returns></returns>
        public static string GetDefaultNameForPlayerType(PlayerType playerType)
        {
            return playerType.ToPlayerLabel();
        }
    }
}
