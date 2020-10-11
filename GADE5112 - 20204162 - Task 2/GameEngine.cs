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

        //Create the GameEngine class.

        protected Map Map;

        public Map map
        {
            get
            {
                return Map;
            }
            set
            {
                map = value;
            }
        }


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
