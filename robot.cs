using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace project_5
{ 
    public enum Direction
    {
        North = 233,
        West = 231,
        South = 234,
        East = 232
    }
    class Robot
    {
        public Direction direction;
        public Robot()
        {
            location = new Point();
            direction = Direction.North;
        }

        public Point location { get; set; }

        public void Move(int unitToMove)
        {
            Point P = new Point();

            switch (direction)
            {
                case Direction.North:
                    P.X = location.X;
                    P.Y = location.Y - unitToMove;
                    break;
                case Direction.West:
                    P.X = location.X - unitToMove;
                    P.Y = location.Y;
                    break;
                case Direction.South:
                    P.X = location.X;
                    P.Y = location.Y + unitToMove;
                    break;
                case Direction.East:
                    P.X = location.X + unitToMove;
                    P.Y = location.Y;
                    break;
                default:
                    break;
            }
            if (location.X < 100 && location.X > -100 && location.Y < 100 && location.Y > -100)
            {
                location = P;
            }
            else
            {
                MessageBox.Show("Can only move 100");
                location = new Point();
            }
        }


        public void Draw (Panel P)
        {
            Point L = new Point(location.X + P.Width / 2, location.Y + P.Height / 2);
            P.Controls[0].Location = L;
        }
        public override string ToString()
        {
            return ((Char)direction).ToString();
        }
    }
}
