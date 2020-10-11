﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    abstract class Tile
    {
        //This is an abstract Tile class that will contain all in-game object postions.
        protected int x;
        protected int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                X = value;
            }
        }


        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                Y = value;
            }
        }


        public enum TileType
        {
            //This enum will be used by other classes to determine what kind of tiles to create on the map.

            Hero,
            Enemy,
            Gold,
            Weapon,
        }

        public Tile()
        {
            //Constructor that receives and sets initial values for relevant variables.

            X = 0;
            Y = 0;
            char hero = 'H';
            char enemy = 'E';
            char gold = 'G';
            char weapon = 'W';
            hero = (char)TileType.Hero;
            enemy = (char)TileType.Enemy;
            gold = (char)TileType.Gold;
            weapon = (char)TileType.Weapon;
        }
    }

    class Obstacle : Tile
    {
        //Obstacle subclass contains nothing extra, and its constructor simply calls the base class’s constructor with X and Y parameters.
        //The obstacle class only exists currently to border our map with Obstacle tiles that the character can't move past.

        public Obstacle(int positionX, int positionY) : base()
        {
            base.Y = positionY;
            base.X = positionX;
        }
    }

    class EmptyTile : Tile
    {
        //EmptyTile is identical to Obstacle, however it merely exists to denote an empty tile.

        public EmptyTile(int positionX, int positionY) : base()
        {
            base.Y = positionY;
            base.X = positionX;
        }
    }
}
