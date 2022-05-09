using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WinFormsApp1
{
    public class Checker
    {
        public Checker() { }

        public Checker(string location, string color)
        {
            Location = location;
            Color = color;
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Point Coord
        {
            get { return _coord = ParseStringToCoord(Location); }
            set { _coord = value; }
        }

        private string _color;
        private string _location;
        private Point _coord;

        private Point ParseStringToCoord(string location)
        {
            Point tempPoint = new Point();
            tempPoint.X = (int)location[0] - 64;
            tempPoint.Y = (int)location[1] - 48;
            return tempPoint;
        }
    }
}