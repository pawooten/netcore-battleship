using Battleship;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBattleship.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class GameStateController
    {
        [HttpGet]
        public GameState Get()
        {
            PlayerGameBoard testGameBoard = new PlayerGameBoard( "Paul", PlayerType.PlayerOne, 10 );
            return GameState.FromPlayerGameBoard( testGameBoard );
        }
    }
}
