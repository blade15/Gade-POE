using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.4 subclass from Enemy called 'Leader'
    class Leader : Enemy
    {
        //private tile that denotes the leader's target through get and set accessors
        private Tile Target;

        public Tile getTarget
        {
            get { return Target; }
            set { Target = value; }
        }

        public Leader(int x, int y, TileType tile_type) : base(x, y, tile_type, 'L', 20, 20, 2, 2)
        {
            getweapon = new MeleeWeapon(Types.Long_Sword);
            getdamage = getweapon.getDamage;
        }

        //overridden method ReturnMove()
        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            int random_tile = rnd.Next(0, tilevision.Length);
            while (tilevision[random_tile].GetType() != typeof(EmptyTile))
            {
                random_tile = rnd.Next(0, tilevision.Length);
            }
            switch (random_tile)
            {
                //does not use optional movement parameter
                //returns number related to character's movement enum
                case 0:
                    return movementEnum.Up;
                case 1:
                    return movementEnum.Down;
                case 2:
                    return movementEnum.Right;
                case 3:
                    return movementEnum.Left;
                default:
                    return movementEnum.NoMovement;
            }
        }


    }
}
