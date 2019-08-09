using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01.Card
{
    public class Player
    {
        private int lifPoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public int LifPoints { get => lifPoints; set => lifPoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }
        public Board Board { get => board; set => board = value; }
        public SpecialCard Captain { get => captain; set => captain = value; }

        public void DrawCard() {

        }
        public void PlayCard(int cardID) {

        }
        public void ChangeCard(int cardID) {

        }
        public void FirstHand() {

        }
        public void ChooseCaptainCard(SpecialCard captainCard) {

        }

    }
}
