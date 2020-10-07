using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    abstract class Character : Tile
    {
        //Qu 2.2 : This abstract base class is called Character and it inherits from Tile.
        //This is the true base class for your Hero and Goblin classes.

        protected int[,] characterVisionArray;
        public int characterHP
        { get; set; }
        protected int characterMaxHP
        { get; set; }
        public int characterDamage
        { get; set; }

        public Character(int positionX, int positionY, char symbol) : base()
        {
            //A constructor that receives X and Y positions and a symbol and delegates the setting of those variables to the Tile class via a constructor initializer.

            base.Y = positionY;
            base.X = positionX;
        }

        public enum Movement
        {
            NoMovement = 0,
            Up = 1, //ConsoleKey.UpArrow,
            Down = 2, //ConsoleKey.DownArrow
            Left = 3, //ConsoleKey.LeftArrow
            Right = 4, //ConsoleKey.RightArrow
        }

        //Qu 2.3 :  The Character class contains the following methods, most of which define generic implementations for all characters to use.
        public virtual void Attack(Character target)
        {
            //Attacks a target and decreases its health by the attacking character’s damage.

            target.characterHP -= characterDamage;
        }
        public bool IsDead()
        {
            //Checks if the character is dead.

            if (characterHP < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            //Checks if a target is in range of a character.

            int distanceToTarget = DistanceTo(target);
            return true;
        }

        private int DistanceTo(Character target)
        {
            //Determines the absolute distance.

            int distanceX = target.X - X;
            int distanceY = target.Y - Y;
            return Math.Abs(distanceX + distanceY);
        }

        public void Move(Movement move)
        {
            //The Move method edits a unit’s X and Y values to move it up / down / left / right based on the identifier from the enum.
            switch (move)
            {
                case Movement.Up:
                    Y -= 1;
                    break;

                case Movement.Down:
                    Y += 1;
                    break;

                case Movement.Left:
                    X -= 1;
                    break;

                case Movement.Right:
                    X += 1;
                    break;

                default:
                    X = X;
                    Y = Y;
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);
        public abstract override string ToString();
    }
}
