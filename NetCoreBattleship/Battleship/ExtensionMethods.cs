using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public static class ExtensionMethods
    {
        public static string ToPlayerLabel(this PlayerType playerType)
        {
            return playerType switch
            {
                PlayerType.PlayerOne => "Player One",
                PlayerType.PlayerTwo => "Player Two",
                _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(playerType))
            };
        }
    }
}
