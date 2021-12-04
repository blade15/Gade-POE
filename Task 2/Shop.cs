using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Shop
    {
        private Weapon[] weapons;
        private Random rnd;
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

        public bool CanBuy(int num,int slot)
        {
            if(num >= weapons[slot].getCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Buy(int num,int slot)
        {
            num = num - weapons[slot].getCost;
            PickUp(slot);
        }

        private void PickUp(int slot)
        {
            weapons[slot] = RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            return "Buy WeaponType(X Gold)";
        }


    }
}
