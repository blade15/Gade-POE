using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class RangedWeapon: Weapon
    {
         public override int getRange
        {
            get { return Range;}
        }

        public RangedWeapon(Types types, int x = 0, int y = 0) : base('W', x, y)
        {
            if (types == Types.Rifle)
            {
                getWeapon_type = "Rifle";
                getDurability = 10;
                getRange = 3;
                getDamage = 5;
                getCost = 7;
            }

            if (types == Types.Longbow)
            {
                getWeapon_type = "Longbow";
                getDurability = 4;
                getRange = 2;
                getDamage = 4;
                getCost = 6;
            }
        }
        public override string ToString()
        {
            return getWeapon_type;
        }
    }
}
