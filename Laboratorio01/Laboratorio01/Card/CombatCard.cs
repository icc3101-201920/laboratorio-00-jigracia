﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    public class CombatCard
    {
        private string name;
        private int attackPoints;
        private bool hero;
        private string type;
        private string effect;

        public string Name { get => name; set => name = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public bool Hero { get => hero; set => hero = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
    }
}
