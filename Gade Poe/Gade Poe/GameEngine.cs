using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class GameEngine
    {
        //private map variable
        private Map game_map;
        //Q2.5 private shop object
        private Shop shop;
        public Shop GetShop
        {
        get { return shop; }
        set { shop = value; }
        }
        //public get accessor
        public Map GetMap
        {
            //constructor that creates a map object with sensible values
            get { return game_map; }
            set { game_map = value; }
        }

        public GameEngine()
        {
            game_map = new Map(10, 10, 15, 15, 6, 2, 2);
            shop = new Shop(game_map.GetPlayer);
        }

        //Allows player to move a space if the move is valid
        //Players move one unit on the grid
        public void MovePlayer(movementEnum movement)
        {
            switch (movement)
            {
                //move up
                case movementEnum.Up:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Up));
                    break;

                //move down
                case movementEnum.Down:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Down));
                    break;

                //move left
                case movementEnum.Left:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Left));
                    break;

                //move right
                case movementEnum.Right:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Right));
                    break;
            }

        }

        //All enemies move only when the player moves
        public void MoveEnemies(movementEnum movement)
        {
            for (int i = 0; i < game_map.GetEnemies.Length; i++)
            {
                game_map.GetEnemies[i].Move(game_map.GetEnemies[i].ReturnMove(movement));
            }
        }

        
        public string PlayerAttack(int Enemy)
        {
            bool EnemyInRange = false;

            for (int x = 0; x < game_map.GetPlayer.tilevision.Length; x++)
            {
                if (game_map.GetPlayer.tilevision[x].getX == game_map.GetEnemies[Enemy].getX && (game_map.GetPlayer.tilevision[x].getY == game_map.GetEnemies[Enemy].getY))
                {
                    EnemyInRange = true;

                }
            }
            if (EnemyInRange)
            {
                //enemy stats update after every attack or movement
                game_map.GetPlayer.attack(game_map.GetEnemies[Enemy]);
                game_map.GetPlayer.Loot(game_map.GetEnemies[Enemy]);

                return "You did attack " + game_map.GetPlayer.getdamage + " damage to a " + game_map.GetEnemies[Enemy].GetType().Name
                + " they now have " + game_map.GetEnemies[Enemy].gethp + " HP";
            }

            else
            {
                return "Target was not in range";
            }
        }

        
        //Enemies attack after player moves
        //Enemies attack when player attacks
        public void EnemyAttack()
        {
            for (int i = 0; i < game_map.GetEnemies.Length; i++)
            {

                switch (game_map.GetEnemies[i].getsymbol)
                {


                    case 'M':
                        if (game_map.GetEnemies[i].checkrange(game_map.GetPlayer) == true)
                        {
                            game_map.GetEnemies[i].attack(game_map.GetPlayer);
                        }

                        for (int z = 0; z < game_map.GetEnemies.Length; z++)
                        {
                            if (game_map.GetEnemies[i].checkrange(game_map.GetEnemies[z]) == true)
                            {
                                game_map.GetEnemies[i].attack(game_map.GetEnemies[z]);
                            }
                        }
                        
                        break;
                    default:
                        for (int w = 0; w < game_map.GetEnemies[i].tilevision.Length; w++)
                        {
                            if (game_map.GetEnemies[i].tilevision[w].getX == game_map.GetPlayer.getX && game_map.GetEnemies[i].tilevision[w].getY == game_map.GetPlayer.getY)
                            {
                                game_map.GetEnemies[i].attack(game_map.GetPlayer);
                            }
                        }
                        break;
                }
            }

        }

        //method used for the save function
        public static void Save(string maps, string hero)
        {
            var savemap = Directory.GetCurrentDirectory();
            var filemap = Path.Combine(savemap, "saved_map_game.dat");
            try
            {
                FileStream fileStream = new FileStream(filemap, FileMode.Create, FileAccess.Write);
                if (fileStream.CanWrite)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(maps);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            var savehero = Directory.GetCurrentDirectory();
            var filehero = Path.Combine(savehero, "saved_hero_game.dat");
            try
            {
                FileStream fileStream = new FileStream(filemap, FileMode.Create, FileAccess.Write);
                if (fileStream.CanWrite)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(hero);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //method used for load funcrion
        public static string Load(string strFile)
        {

            var dirload = Directory.GetCurrentDirectory();
            var fileload = Path.Combine(dirload, strFile);
            string Text = String.Empty;

            try
            {
                FileStream fileStream = new FileStream(fileload, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[1024];
                int bytesread = fileStream.Read(buffer, 0, buffer.Length);

                Text = Encoding.ASCII.GetString(buffer, 0, bytesread);

                fileStream.Flush();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return Text;

        }
        public override string ToString()
        {
            return game_map.DrawMap();
        }
    }
}


