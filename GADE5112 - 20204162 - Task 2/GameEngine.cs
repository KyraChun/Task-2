using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class GameEngine
    {
        public GameEngine(Map map)
        {
            this.map = map;
        }

        //Qu 3.3 : Create the GameEngine class.

        private Map map
        { public get; set; }


    public bool MovePlayer(Character.Movement direction)
        {
            return true;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
