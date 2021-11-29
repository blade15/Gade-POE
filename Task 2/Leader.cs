using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Leader:Enemy
    {
        private Tile Target;

        public Tile getTarget
        {
            get { return Target; }
            set { Target = value; }
        }

        public Leader(int x,int y): base(x, y, TileType.Enemy, 'L', 2, 20, 20)
        {

        }

        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {

            //Randomises a direction for goblin to move to
            int random_tile = rnd.Next(0, tilevision.Length);
            while (tilevision[random_tile].GetType() != typeof(EmptyTile))
            {
                random_tile = rnd.Next(0, tilevision.Length);
            }
            switch (random_tile)
            {
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

        public override string ToString()
        {
            return "";
        }
    }
}
