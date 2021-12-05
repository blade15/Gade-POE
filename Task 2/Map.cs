using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1
{
    class Map
    {
        //Q4.1 2D map arrays
        private Tile[,] map;
        public Tile[,] GetMaps
        {
            get { return map; }
            set { map = value; }
        }
        private Hero Player;
        public Hero GetPlayer
        {
            get { return Player; }
            set { Player = value; }
        }

        //enemy array
        private Enemy []  enemies;
        public Enemy[] GetEnemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        //Q3.1 items array that stores items that exist on map
        public Item [] items;
        public  Item [] GetItems
        {
            get { return items; }
            set { items = value; }
        }
        private int mapwidth;

        public int getmapwidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        //private variable of map height
        private int mapheight;

        public int getmapheight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }
        
        private Random rnd = new Random();

        //Deciding the map size through random rolls
        public Map(int min_width,int max_width, int min_height, int max_height,int num_enemies,int num_gold,int num_weapons)
        {
            mapwidth = rnd.Next(min_width, max_width+1);
            mapheight = rnd.Next(min_height, max_height+1);

            map = new Tile[mapwidth, mapheight];

            enemies = new Enemy[num_enemies];
            items = new Item[num_gold+num_weapons];

            generate_map();

            Player = (Hero)Create(TileType.Hero);
            map[Player.getX, Player.getY] = Player;

            //Q3.1
            for (int i = 0; i < enemies.Length; i++)
            {
                int rndenemies = rnd.Next(0,3);
                if(rndenemies == 0)
                {
                enemies[i] = (Enemy)Create(TileType.leader);
                map[enemies[i].getX, enemies[i].getY] = enemies[i];
                }

               else if (rndenemies == 1)
                {
                    enemies[i] = (Enemy)Create(TileType.goblin);
                    map[enemies[i].getX, enemies[i].getY] = enemies[i];
                }
                else if (rndenemies == 2)
                {
                    enemies[i] = (Enemy)Create(TileType.mage);
                    map[enemies[i].getX, enemies[i].getY] = enemies[i];
                }
            }

            for (int z = 0; z < num_gold+num_weapons; z++)
            {
                if(z < num_gold)
                {
                    items[z] = (Item)Create(TileType.Gold);
                    map[items[z].getX, items[z].getY] = items[z];
                }
                else 
                {
                    int rndweapon = rnd.Next(4);
                    if(rndweapon == 0)
                    {
                        items[z] = (Item)Create(TileType.Dagger);
                        map[items[z].getX, items[z].getY] = items[z];
                    }
                    if (rndweapon == 1)
                    {
                        items[z] = (Item)Create(TileType.Long_Sword);
                        map[items[z].getX, items[z].getY] = items[z];
                    }
                    if (rndweapon == 2)
                    {
                        items[z] = (Item)Create(TileType.Longbow);
                        map[items[z].getX, items[z].getY] = items[z];
                    }
                    if (rndweapon == 3)
                    {
                        items[z] = (Item)Create(TileType.Rifle);
                        map[items[z].getX, items[z].getY] = items[z];
                    }

                }
                
            }
            
            UpdateVision();
        }

        public void PlaceHero()
        {
            map[Player.getX, Player.getY] = Player;
        }
        public void UpdateGame()
        {
            generate_map();
            map[Player.getX, Player.getY] = Player;
            for (int i = 0; i < enemies.Length; i++)
            {
                map[enemies[i].getX, enemies[i].getY] = enemies[i];
            }
            Addgold();
            for (int i = 0; i < items.Length; i++)
            {
                map[items[i].getX, items[i].getY] = items[i];
            }
            UpdateVision();
        }
         void generate_map()
        {
            //creates the empty tiles "."
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    map[x, y] = new EmptyTile(x, y, TileType.Empty);
                }
            }

            // creates the borders "X"
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if ((y == 0 || y == map.GetLength(1) - 1) || x == 0 || (x == map.GetLength(0) - 1))
                    {
                        map[x, y] = new Obstacle(x, y, TileType.Barrier);
                    }
                }
            }
        }

        private void Addgold()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if(map[Player.getX, Player.getY] == map[items[i].getX, items[i].getY])
                {
                    Player.Pickup(GetItemAtPosition(Player.getX, Player.getY));
                }
            }
            
        }

        //private void Addweapon()
        //{
        //    for(int )
        //} 
        
        //Q3.2 method looks in Items array if something exists at the given coordinates
        public Item GetItemAtPosition(int x, int y)
        {
            //set item to null in array
            Item output = null;
            for (int i = 0; i < items.Length; i++)
            {
                if(x == items[i].getX && y == items[i].getY && items[i].GetTileType == TileType.Gold)
                {
                    output = items[i];
                    items[i] = null;
                    items = items.Where(i => i != null).ToArray();
                    
                }
            }
            //returns item if it exists else if item doesnt exist, returns null
            return output;
        }

        private Tile Create(TileType tileType, int x = 0, int y = 0)
        {

            switch (tileType)
            {
                case TileType.Hero:
                    int HeroX = rnd.Next(0, mapwidth);
                    int HeroY = rnd.Next(0, mapheight);
                    while (map[HeroX, HeroY].GetType() != typeof(EmptyTile))
                    {
                        HeroX = rnd.Next(0, mapwidth);
                        HeroY = rnd.Next(0, mapheight);
                    }
                    return new Hero(HeroX, HeroY, tileType);

                case TileType.leader:
                    int LeaderX = rnd.Next(0, mapwidth);
                    int LeaderY = rnd.Next(0, mapheight);

                    while (map[LeaderX, LeaderY].GetType() != typeof(EmptyTile))
                    {
                        LeaderX = rnd.Next(0, mapwidth);
                        LeaderY = rnd.Next(0, mapheight);
                    }
                    return new Leader(LeaderX, LeaderY, tileType);

                case TileType.goblin:
                    int GoblinX = rnd.Next(0, mapwidth);
                    int GoblinY = rnd.Next(0, mapheight);

                    while (map[GoblinX, GoblinY].GetType() != typeof(EmptyTile))
                    {
                        GoblinX = rnd.Next(0, mapwidth);
                        GoblinY = rnd.Next(0, mapheight);
                    }
                    return new Goblin(GoblinX, GoblinY, tileType);

                case TileType.mage:
                    int MageX = rnd.Next(0, mapwidth);
                    int MageY = rnd.Next(0, mapheight);

                    while (map[MageX, MageY].GetType() != typeof(EmptyTile))
                    {
                        MageX = rnd.Next(0, mapwidth);
                        MageY = rnd.Next(0, mapheight);
                    }
                    return new Mage(MageX, MageY, tileType);



                case TileType.Gold:
                    int ItemX = rnd.Next(0, mapwidth);
                    int ItemY = rnd.Next(0, mapheight);

                    while (map[ItemX, ItemY].GetType() != typeof(EmptyTile))
                    {
                        ItemX = rnd.Next(0, mapwidth);
                        ItemY = rnd.Next(0, mapheight);
                    }
                    return new Gold(ItemX, ItemY, tileType);

                case TileType.Dagger:
                    
                    
                    int DaggerX = rnd.Next(0, mapwidth);
                    int DaggerY = rnd.Next(0, mapheight);

                    while (map[DaggerX, DaggerY].GetType() != typeof(EmptyTile))
                    {
                        DaggerX = rnd.Next(0, mapwidth);
                        DaggerY = rnd.Next(0, mapheight);
                    }
                     return new MeleeWeapon(Types.Dagger,DaggerX,DaggerY);

                case TileType.Long_Sword:

                   
                    int Long_swordX = rnd.Next(0, mapwidth);
                    int Long_swordY = rnd.Next(0, mapheight);

                    while (map[Long_swordX, Long_swordY].GetType() != typeof(EmptyTile))
                    {
                        Long_swordX = rnd.Next(0, mapwidth);
                        Long_swordY = rnd.Next(0, mapheight);
                    }
                    return new MeleeWeapon(Types.Long_Sword, Long_swordX, Long_swordY);

                case TileType.Longbow:

                    
                    int LongbowX = rnd.Next(0, mapwidth);
                    int LongbowY = rnd.Next(0, mapheight);

                    while (map[LongbowX, LongbowY].GetType() != typeof(EmptyTile))
                    {
                        LongbowX = rnd.Next(0, mapwidth);
                        LongbowY = rnd.Next(0, mapheight);
                    }
                    return new RangedWeapon(Types.Longbow, LongbowX, LongbowY);

                case TileType.Rifle:

                    //int weapontype = rnd.Next(0, 2);
                    int RifleX = rnd.Next(0, mapwidth);
                    int RifleY = rnd.Next(0, mapheight);

                    while (map[RifleX, RifleY].GetType() != typeof(EmptyTile))
                    {
                        RifleX = rnd.Next(0, mapwidth);
                        RifleY = rnd.Next(0, mapheight);
                    }
                    return new RangedWeapon(Types.Rifle, RifleX, RifleY);

                default:
                    return null;
            }
        }

        public void UpdateVision()
        {
            foreach(Enemy E in enemies)
            {
              //  E.Vision.Clear();
                E.tilevision[0] = map[E.getX, E.getY - 1];
                E.tilevision[1] = map[E.getX, E.getY + 1];
                E.tilevision[2] = map[E.getX + 1, E.getY];
                E.tilevision[3] = map[E.getX - 1, E.getY];
            }
            //Player.Vision.Clear();
            Player.tilevision[0] = map[Player.getX, Player.getY - 1];
            Player.tilevision[1] = map[Player.getX, Player.getY + 1];
            Player.tilevision[2] = map[Player.getX + 1, Player.getY];
            Player.tilevision[3] = map[Player.getX - 1, Player.getY];
        }

        public string DrawMap()
        {
            string output = "";
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    output += map[x, y].getsymbol; 
                }
                output += '\n';
            }
            return output;
        }
        
    }
}
