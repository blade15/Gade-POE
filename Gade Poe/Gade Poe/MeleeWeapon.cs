using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.2 subclass of weapon class called MeleeWeapon
    class MeleeWeapon : Weapon
    {
        //Range accessor to get the range
        public override int getRange
        {
            get { return 1; }
        }
        
        //public enum called 'Types' which defines two types of weapons
        public MeleeWeapon(Types types, int x = 0, int y = 0) : base('W', x, y)
        {
            //Dagger type selection
            if (types == Types.Dagger)
            {
                getWeapon_type = "dagger";
                getDurability = 10;
                getDamage = 3;
                getCost = 3;
            }

            //Longsword type selection
            if (types == Types.Long_Sword)
            {
                getWeapon_type = "Long sword";
                getDurability = 6;
                getDamage = 4;
                getCost = 5;
            }

            if (types == Types.Barehands)
            {
                getWeapon_type = "Bare Hands";
                getDurability = 100;
                getDamage = 0;
                getCost = 0;
            }
        }

        
        public override string ToString()
        {
            return getWeapon_type + " cost: " + getCost;
        }
    }
}

