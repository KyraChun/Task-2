﻿using GADE5112___20104162___Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Item : Tile
    {
        //Qu 2.1 : This abstract base class Item, which inherits from Tile.

        public Item(int positionX, int positionY) : base()
        {
            //A constructor that receives an X and Y position. 
            //This data is delegated to Tile through the constructor initialiser. 
            //Item’s constructor is otherwise empty.
        }

        //An abstract ToString method that is overridden by subclasses to return the type of item.
        public abstract override string ToString();
    }
}
