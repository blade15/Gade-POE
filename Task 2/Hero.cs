using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.6 concrete hero subclass that inherits from Character
    class Hero: Character
    {
        public Hero(int x, int y,TileType tile_type) :base(x, y, tile_type, 'H', 100, 100, 2,0)
        {

            getweapon = new MeleeWeapon(Types.Barehands);
            getdamage = getdamage;
        }

        bool checkvalidmove(movementEnum charactermove)
        {
            bool valid = false;

            switch (charactermove)
            {
                case movementEnum.Right:
                        if(tilevision[2].GetType() == typeof(EmptyTile) || tilevision[2].GetType() == typeof(Item) ||  tilevision[2].GetType() == typeof(Gold) || tilevision[2].GetType() == typeof(MeleeWeapon) || tilevision[2].GetType() == typeof(RangedWeapon))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Left:
                    if (tilevision[3].GetType() == typeof(EmptyTile) || tilevision[3].GetType() == typeof(Item) || tilevision[3].GetType() == typeof(Gold) || tilevision[3].GetType() == typeof(MeleeWeapon) || tilevision[3].GetType() == typeof(RangedWeapon))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Down:
                    if (tilevision[1].GetType() == typeof(EmptyTile) || tilevision[1].GetType() == typeof(Item) || tilevision[1].GetType() == typeof(Gold) || tilevision[1].GetType() == typeof(MeleeWeapon) || tilevision[1].GetType() == typeof(RangedWeapon))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Up:
                    if (tilevision[0].GetType() == typeof(EmptyTile) || tilevision[0].GetType() == typeof(Item) || tilevision[0].GetType() == typeof(Gold) || tilevision[0].GetType() == typeof(MeleeWeapon) || tilevision[0].GetType() == typeof(RangedWeapon))
                    {
                        valid = true;
                        break;
                    }
                    break;
            }

            return valid;
        }
        
        //Overridden ReturnMove() method
        public override movementEnum ReturnMove( movementEnum move = movementEnum.NoMovement)
        {
            //receives movement indicator based on directional button press
            if (checkvalidmove(move))
            {
                return move;
            }
            else return movementEnum.NoMovement;
        }

        //overridden to string to display stats
        public override string ToString()
        {
            //Q3.2 Display the gold amount in the Stats display section
            return "Player Stats:" + '\n' + "HP: " + HP + "/ "+ MaxHP+ '\n'+ "Current Weapon: "+ getweapon.getWeapon_type+'\n'+ "Weapon Range: "+getweapon.getRange+'\n' + "Weapon Damage: " + Damage +'\n'+"Weapon Durability: "+getweapon.getDurability +'\n' + "[" + X + "," + Y + "] "+ getpurse +" Gold";
        }
    }
}

//Player Stats:
//HP: 75 / 100
//Current Weapon: Bare Hands
//Weapon Range: 1
//Weapon Damage: 2
//Gold: 5