using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class Map        
    {
        //Qu 3.1 : This is my Map class that contains : 
        //          A 2D Tile array to represent the map.
        //          A Hero object to represent the player character.
        //          An Enemy array for the enemies.
        //          Variables for storing the map’s width and height.
        //          A Random object for randomising numbers.

        protected Tile[,] mapArray;
        protected Enemy[] numEnemies;
        protected Hero newHero;
        protected int mapWidth;
        protected int mapHeight;
        protected Random random = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberEnemies)
        {
            //Qu 3.2 : A constructor that receives a minimum and maximum width, minimum and maximum height and number of enemies.
            
            int mapWidth = random.Next(minWidth, maxWidth);
            int mapHeight = random.Next(minHeight, maxHeight);

            mapArray = new Tile[mapWidth, mapHeight];
            numEnemies = new Enemy[(mapWidth + mapHeight) / 3];

            for (int i = 0; i < numEnemies.Count(); i++)
            {
                numEnemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }

            UpdateVision();
            newHero = (Hero)Create(type: Tile.TileType.Hero);
        }

        public void UpdateVision()
        {
            //Qu 3.2 : Updates the vision array for each Character.

            Tile tempTile;
            foreach (Tile temp in numEnemies)
            {
                for (int i = -1; i < 2; i++)
                {

                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            //Qu 3.2 : This method is used to create objects and also place them on the map.

            Tile tempTile = null;
            int randomX = random.Next(1, mapWidth);
            int randomY = random.Next(1, mapHeight);
            int heroHP = 0;
            char heroSymbol = 'H';

            switch (type)
            {
                case Tile.TileType.Hero:
                    tempTile = new Hero(randomX, randomY, heroHP, heroSymbol);
                    break;
                case Tile.TileType.Enemy:
                    tempTile = new Goblin(randomX, randomY);
                    break;
                case Tile.TileType.Gold:
                    break;
                case Tile.TileType.Weapon:
                    break;
                default:
                    break;
            }
            mapArray[randomX, randomY] = tempTile;
            return tempTile;
        }
    }
}
