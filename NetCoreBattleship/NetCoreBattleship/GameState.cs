using Battleship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBattleship
{
    public class GameState
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

        public static GameState FromPlayerGameBoard(PlayerGameBoard gameBoard )
        {
            GameState gameState = new GameState();
            gameState.Name = gameBoard.PlayerName;
            gameState.Label = gameBoard.PlayerType.ToPlayerLabel();

            return gameState;
        }
    }
}
