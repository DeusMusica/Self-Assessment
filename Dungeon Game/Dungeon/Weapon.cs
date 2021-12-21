using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public class Weapon
    {
        int _minDamage;
        public string Name { get; set; }
        public bool IsTwoHanded { get; set; }
        public int BonusHitChance { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public Weapon(string name, int minDamage, int maxDamage, bool isTwoHanded, int bonusHitChance)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            IsTwoHanded = isTwoHanded;
            BonusHitChance = bonusHitChance;
        }

        

    }
}
