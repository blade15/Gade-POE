using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.5 concrete Goblin class that inherits from Enemy
    class Goblin : Enemy
    {

        public Goblin(int x, int y, TileType tile_type) : base(x, y, tile_type, 'G', 10, 10, 1, 1)
        {
            getweapon = new MeleeWeapon(Types.Long_Sword);
            getdamage = getweapon.getDamage;
        }

        //overridden ReturnMove() method that does not use optional movement parameter
        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            return movementEnum.NoMovement;
            //Randomises a direction for goblin to move to
            //int random_tile = rnd.Next(0, tilevision.Length);
            //while (tilevision[random_tile].GetType() != typeof(EmptyTile))
            //{
            //    random_tile = rnd.Next(0, tilevision.Length);
            //}
            //switch (random_tile)
            //{
            //    case 0:
            //        return movementEnum.Up;
            //    case 1:
            //        return movementEnum.Down;
            //    case 2:
            //        return movementEnum.Right;
            //    case 3:
            //        return movementEnum.Left;
            //    default:
            //        return movementEnum.NoMovement;
            //}

        }
    }
}
