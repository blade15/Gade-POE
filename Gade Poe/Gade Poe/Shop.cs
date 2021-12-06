using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Shop class
    class Shop
    {
        //private member variables with no accessors
        //3 by 3
        private Weapon[] weapons;
        //randomise numbers
        private Random rnd;
        //denote the buyer
        private Character buyer;

        //int x, int y, TileType tile_type, char symbol, int hp,int maxhp, int damage,int purse
        public Shop(Character character)
        {
            buyer = character;
            rnd = new Random();
            weapons = new Weapon[3];
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i] = RandomWeapon();
            }
        }

        //private method that randomises and returns weapon of choice
        private Weapon RandomWeapon()
        {
            int num = rnd.Next(4);
            switch (num)
            {
                case 0:
                    return new MeleeWeapon(Types.Dagger);
                case 1:
                    return new MeleeWeapon(Types.Long_Sword);
                case 2:
                    return new RangedWeapon(Types.Rifle);
                case 3:
                    return new RangedWeapon(Types.Longbow);
                default:
                    return null;
            }
        }

        //public bool that returns true if buyer can afford
        public bool CanBuy(int num, int slot)
        {
            if (num >= weapons[slot].getCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void hat removes gold by cost subtraction
        public void Buy(int num, int slot)
        {
            num = num - weapons[slot].getCost;
            PickUp(slot);
        }

        private void PickUp(int slot)
        {
            buyer.getweapon = weapons[slot];
            weapons[slot] = RandomWeapon();
        }

        //public string that reads what leader buys
        public string DisplayWeapon(int num)
        {
            return "Buy " + weapons[num].ToString();
        }


    }
}
