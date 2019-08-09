using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01.Card
{
    public class Hand
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        public void AddCombatCard(CombatCard combatCard) {

        }
        public void AddSpecialCards(SpecialCard specialCard) {

        }
        public void DestroyCombatCard(int cardID) {

        }
        public void SpecialCard(int cardID) {

        }
    }
}
