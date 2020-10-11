using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    class Gold : Item
    {
        private Random randomGold = new Random();


        private int goldDrop;

        public int gold_Drop
        {
            get
            {
                return goldDrop;
            }
            set
            {
                gold_Drop = value;
            }
        }



        public Gold(int positionX, int positionY, char symbol) : base(positionX, positionY, symbol)
        {
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
