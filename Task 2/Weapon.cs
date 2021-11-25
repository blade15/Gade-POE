using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
   abstract class Weapon:Item
    {
        protected int Damage;
        protected int Range;
        protected int Durability;
        protected int Cost;
        protected string weapon_type;

        public int getDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public virtual int getRange
        {
            get { return Range;}
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

        public Weapon(int x, int y , TileType tile_type, char symbol) : base(x = 0,y = 0,tile_type,symbol)
        {

        }


       

    }
}
