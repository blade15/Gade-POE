using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //concrete Mage subclass
    //A new type of enemy
    class Mage : Enemy
    {
        public Mage(int x, int y, TileType tile_type) : base(x, y, tile_type, 'M', 5, 5, 5, 3)
        {
            getweapon = new MeleeWeapon(Types.Barehands);
            getdamage = getdamage;
        }

        //overridden method called "checkrange"
        public override bool checkrange(Character Target)
        {
            //Mages attack all characters within a one block radius all around them
            //checking all ranges until it's own overridden CheckRange()
            if (Target.getX == X - 1 && Target.getY == Y - 1)
            {
                //returns true if enemy is in a one block radius from the Mage's x and y position
                return true;
            }

            else if (Target.getX == X - 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y - 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X - 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X && Target.getY == Y + 1)
            {
                return true;
            }
            else if (Target.getX == X && Target.getY == Y - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //overridden ReturnMove() method
        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            //Always returns 0
            //Mages never move
            return movementEnum.NoMovement;
        }
    }
}
