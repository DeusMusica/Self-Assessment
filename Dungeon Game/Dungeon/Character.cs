﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    class Character
    {
        public int _health;
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int MaxLife { get; set; }
        public int Health 
        { 
            get
            {
                return _health;
            }
            set
            {
                if (value <= _health)
                {
                    _health = value;
                }
                else
                {
                    _health = 1;
                }
            }

        }
        public int Block { get; set; }
        Weapon EquippedWeapon { get; set; }
        public Character( string name, int maxlife, int hitChance, int block, Weapon equippedWeapon)
        {
            Name = name;
            MaxLife = maxlife;
            Health = maxlife;
            HitChance = hitChance;
            Block = block;
            EquippedWeapon = equippedWeapon;
        }

        public virtual int CalculateDamage()
        {
            Random rand = new Random();
            return rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

        }

        public virtual int CalcuateHitChance()
        {
            return EquippedWeapon.BonusHitChance + HitChance;
        }
    }
}
