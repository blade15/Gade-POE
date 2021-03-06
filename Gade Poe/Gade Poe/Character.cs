using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Creating abstract base class called "Character"
    //Inherits from "Tile"
    abstract class Character : Tile
    {
        //Protected member variables
        protected int HP;
        protected int MaxHP;
        protected int Damage;
        protected int Purse;
        //Q3.2 protected weapon object
        protected Weapon weapon;

        public Tile[] tilevision = new Tile[4];

        //public accessor that gets the health
        public int gethp
        {
            get { return HP; }
            set { HP = value; }
        }

        //public accessor that gets the maximum health
        public int getmaxHp
        {
            get { return MaxHP; }
            set { MaxHP = value; }
        }

        //public accessor that gets the damage amount
        public int getdamage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        //public accessor that gets the purse for the gold
        public int getpurse
        {
            get { return Purse; }
            set { Purse = value; }
        }

        public Weapon getweapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Character(int x, int y, TileType tile_type, char symbol, int hp, int maxhp, int damage, int purse) : base(x, y, tile_type, symbol)
        {
            Symbol = symbol;
            HP = hp;
            MaxHP = maxhp;
            Damage = damage;
            Purse = purse;
        }

        //Adding in methods to define generic implementations for the character to use
        //Public virtual void called "Attack"
        public virtual void attack(Character Target)
        {
            //Decreases health of attacking character's damage
            if (checkrange(Target))
            {
                Target.HP = Target.HP - Damage;
            }
        }

        //Public bool called "IsDead"
        public bool isdead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else return false;
        }

        //Q3.4 character can now loot enemies they kill
        public void Loot(Character target)
        {
            if (target.isdead())
            {
                //equip dead enemy's weapon (if new)
                if ((weapon.getWeapon_type == "Bare Hands") && GetTileType !=TileType.mage )
                {
                    weapon = target.weapon;
                    //Purse = Purse + target.Purse;
                }
                //add dead characters gold to gold total
                Purse = Purse + target.Purse;
            }
        }

        //Public virtual bool
        public virtual bool checkrange(Character Target)
        {
            if (DistanceTo(Target) > 1 || DistanceTo(Target) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Private integer method called "DistanceTo"
        //Determines absolute distance. Number of spaces to move
        public int DistanceTo(Character character)
        {
            int num = X + Y;
            int num2 = character.X + character.Y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        //Public void method called "Move"
        public void Move(movementEnum move)
        {
            switch (move)
            {
                case movementEnum.Up:
                    Y = Y - 1;
                    break;
                case movementEnum.Down:
                    Y = Y + 1;
                    break;
                case movementEnum.Left:
                    X = X - 1;
                    break;
                case movementEnum.Right:
                    X = X + 1;
                    break;
                case movementEnum.NoMovement:
                    break;
            }
        }

        //check item passed and if gold, add to character's treasure collection
        public void Pickup(Item i)
        {
            if (i.GetType() == typeof(Gold))
            {
                Gold gold = (Gold)i;
                Purse = Purse + gold.Getamount;
            }
            else
            {
                Equip((Weapon)i);
            }

        }

        //Q3.1 pick up weapons
        private void Equip(Weapon w)
        {
            if (w.GetType() == typeof(MeleeWeapon))
            {
                if (w.getWeapon_type == "dagger")
                {
                    weapon = new MeleeWeapon(Types.Dagger);
                    Damage = weapon.getDamage;
                }
                else
                {
                    weapon = new MeleeWeapon(Types.Long_Sword);
                    Damage = weapon.getDamage;
                }

            }

            if (w.GetType() == typeof(RangedWeapon))
            {
                if (w.getWeapon_type == "Rifle")
                {
                    weapon = new RangedWeapon(Types.Rifle);
                    Damage = weapon.getDamage;
                }
                else
                {
                    weapon = new RangedWeapon(Types.Longbow);
                    Damage = weapon.getDamage;
                }
            }
        }

        public abstract movementEnum ReturnMove(movementEnum m);
        public abstract override string ToString();
    }
}
