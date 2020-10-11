using GADE5112___20104162___Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Item : Tile
    {
        public  Item(int positionX, int positionY, char symbol) : base()
        {
        }

        public abstract override string ToString();
    }
}
