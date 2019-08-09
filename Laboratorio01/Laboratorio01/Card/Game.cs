using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01.Card
{
    public class Game
    {
        private Player players;
        private Board boardGame;
        private Player activePlayer;
        private bool endGame;

        public Player Players { get => players; set => players = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool EndGame { get => endGame; set => endGame = value; }

        public bool CheckIfEndGame() {
            return endGame;
        }

        public int GetWinner() {
            return players.PlayerID;
        }

        public void Play() {

        }
    }
}
