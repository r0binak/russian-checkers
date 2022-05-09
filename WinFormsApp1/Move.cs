using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WinFormsApp1
{
    public class Move : ICloneable
    {
        public Move() { }

        public Move(string moveFrom, string moveTo, string color)
        {
            MoveFrom = moveFrom;
            MoveTo = moveTo;
            ColorOfMovedChecker = color;
        }

        //public string endLocations = null;
        public List<Move> lstOfAttackMoves = new List<Move>();

        public string MoveFrom
        {
            get { return _moveFrom; }
            set { _moveFrom = value; }
        }

        public string MoveTo
        {
            get { return _moveTo; }
            set { _moveTo = value; }
        }

        public double EstimateOfProfit
        {
            get { return _estimateOfProfit; }
            set { _estimateOfProfit = value; }
        }

        public string ColorOfMovedChecker
        {
            get { return _colorOfMovedChecker; }
            set { _colorOfMovedChecker = value; }
        }

        public bool IsAttack
        {
            get { return _isAttack; }
            set { _isAttack = value; }
        }

        public string LocationOfdeletedChecker
        {
            get
            {
                _locationOfdeletedChecker = GetLocation(new Point((ParseStringToCoord(MoveFrom).X + ParseStringToCoord(MoveTo).X) / 2,
                (ParseStringToCoord(MoveFrom).Y + ParseStringToCoord(MoveTo).Y) / 2));
                return _locationOfdeletedChecker;
            }
            set { _locationOfdeletedChecker = value; }
        }

        //public string[] ParseMove()
        //{
        // string[] stringOfMoves = new string[10];
        // stringOfMoves = this.endLocations.Split('-');
        // return stringOfMoves;
        //}

        public object Clone()
        {
            Move cloneMove = new Move();
            cloneMove.ColorOfMovedChecker =
            this.ColorOfMovedChecker;
            cloneMove.EstimateOfProfit = this.EstimateOfProfit;
            cloneMove.IsAttack = this.IsAttack;
            cloneMove.LocationOfdeletedChecker = this.LocationOfdeletedChecker;
            cloneMove.MoveFrom = this.MoveFrom;
            cloneMove.MoveTo = this.MoveTo;
            //cloneMove.endLocations = this.endLocations;
            cloneMove.EstimateOfProfit = this.EstimateOfProfit;
            return cloneMove;
        }

        public void AddMoveToListOfAttack(string locationFrom, string locationTo)
        {
            Move tmpMove = new Move(locationFrom, locationTo, this.ColorOfMovedChecker);
            tmpMove.EstimateOfProfit = this.EstimateOfProfit;
            tmpMove.IsAttack = true;
            lstOfAttackMoves.Add(tmpMove);
        }

        private Point ParseStringToCoord(string location)
        {
            Point tempPoint = new Point();
            tempPoint.X = (int)location[0] - 64;
            tempPoint.Y = (int)location[1] - 48;
            return tempPoint;
        }

        private string GetLocation(Point curPoint)
        {
            string resLocation;
            char tempCharX = (char)(curPoint.X + 64);
            char tempCharY = (char)(curPoint.Y + 48);
            resLocation = tempCharX.ToString() + tempCharY.ToString();
            return resLocation;
        }

        private string _locationOfdeletedChecker;
        private bool _isAttack = false;
        private string _moveFrom;
        private string _moveTo;
        private double _estimateOfProfit;
        private string _colorOfMovedChecker;

    }
}