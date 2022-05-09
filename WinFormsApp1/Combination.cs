using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class Combination
    {
        /*
        * Класс содержит комбинацию ходов обеих сторон и пользу обеих сторон
        */
        public List<Move> combinationOfMoves = new List<Move>();

        public double WhiteProfit
        {
            get
            {
                return CalculateSumOfProfit("white");
            }
            set { _whiteProfit = value; }
        }

        public double BlackProfit
        {
            get
            {
                return CalculateSumOfProfit("black");
            }
            set { _blackProfit = value; }
        }

        private double CalculateSumOfProfit(string color)
        {
            double profit = 0.0;
            foreach (Move item in combinationOfMoves)
            {
                if (item.ColorOfMovedChecker == color)
                    profit += item.EstimateOfProfit;
            }
            return profit;
        }

        private double _whiteProfit = 0.0;
        private double _blackProfit = 0.0;

    }
}