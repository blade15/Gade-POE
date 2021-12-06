using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.1 Weapon abstract class inheriting from Item
    abstract class Weapon : Item
    {
        //protected member variables
        protected int Damage;
        protected int Range;
        protected int Durability;
        protected int Cost;
        protected string weapon_type;

        //public accessors
        public int getDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public virtual int getRange
        {
            get { return Range; }
            set { Range = value; }
        }
        public int getDurability
        {
            get { return Durability; }
            set { Durability = value; }
        }
        public int getCost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public string getWeapon_type
        {
            get { return weapon_type; }
            set { weapon_type = value; }
        }

        public Weapon(char symbol, int x = 0, int y = 0) : base(x, y, TileType.Weapon, symbol)
        {

        }




    }
}

