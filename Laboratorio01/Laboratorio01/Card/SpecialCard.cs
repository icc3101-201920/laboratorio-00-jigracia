using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01.Card
{
    public class SpecialCard
    {
        private string name;
        private string type;
        private string buffType;
        private string effect;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string BuffType { get => buffType; set => buffType = value; }
        public string Effect { get => effect; set => effect = value; }
    }
}
