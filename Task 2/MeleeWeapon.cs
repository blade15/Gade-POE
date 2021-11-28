using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class MeleeWeapon:Weapon
    {
        public override int getRange 
        {
            get { return 1;}
        }

        public MeleeWeapon(Types types,int x = 0,int y = 0): base('^',x, y)
        {
        if(types == Types.Dagger)
            {
                getWeapon_type = "dagger";
                getDurability = 10;
                getDamage = 3;
                getCost = 3;

            }

            if(types == Types.Long_Sword)
            {
                getWeapon_type = "Longsword";
                getDurability = 6;
                getDamage = 4;
                getCost = 5;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
