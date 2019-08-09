using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01.Card
{
    public class Board
    {
        private List<CombatCard> meleeCards;
        private List<CombatCard> rangeCards;
        private List<CombatCard> longRangeCards;
        private SpecialCard specialMeleeCards;
        private SpecialCard specialRangeCards;
        private SpecialCard specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        public List<CombatCard> MeleeCards { get => meleeCards; }
        public List<CombatCard> RangeCards { get => rangeCards; }
        public List<CombatCard> LongRangeCards { get => longRangeCards; }
        public SpecialCard SpecialMeleeCards { get => specialMeleeCards; }
        public SpecialCard SpecialRangeCards { get => specialRangeCards; }
        public SpecialCard SpecialLongRangeCards { get => specialLongRangeCards; }
        public List<SpecialCard> CaptainCards { get => captainCards; }
        public List<SpecialCard> WeatherCards { get => weatherCards; }

        public void AddCombatCard(int playerID, CombatCard combatCard) {

        }
        public void AddSpecialCard(int playerID, SpecialCard specialCard) {

        }
        public void DestroyCombatCards() {

        }
        public void DestroySpecialCards() {

        }
        public int GetMeleeAttackPoints() {
            CombatCard combatCard = new CombatCard();
            return combatCard.AttackPoints;
        }
        public int RangeAttackPoints() {
            CombatCard combatCard = new CombatCard();
            return combatCard.AttackPoints;
        }

        public int LongRangeAttackPoints() {
            CombatCard combatCard = new CombatCard();
            return combatCard.AttackPoints;
        }




    }
}
