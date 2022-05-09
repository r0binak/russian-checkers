using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WinFormsApp1
{
    public class Cell
    {
        public Cell()
        {
        }
        public Cell(string cellColor, string cellName)
        {
            CellName = cellName;
            CellColor = cellColor;
            ParseNameToCoord();
        }

        public Point coord = new Point();

        public string CellName
        {
            get { return _cellName; }
            set { _cellName = value; }
        }

        public string CellColor
        {
            get { return _cellColor; }
            set { _cellColor = value; }
        }

        public bool IsChecker
        {
            get { return _isChecker; }
            set { _isChecker = value; }
        }

        public string CheckColor
        {
            get { return _checkColor; }
            set { _checkColor = value; }
        }

        private const string WHITE = "white";
        private const string BLACK = "black";
        private string _cellName;
        private string _cellColor;
        private bool _isChecker = false;
        private string _checkColor;

        private void ParseNameToCoord()
        {
            coord.X = (int)CellName[0] - 64;
            coord.Y = (int)CellName[1] - 48;
        }
    }
}