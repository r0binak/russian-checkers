using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace WinFormsApp1
{
    public class Board
    {
        /*
        * Класс Board отвечает за действия на доске. Содержит клетки, информацию о фигурах на доске.
        * Присутствует расчет и выбор хода компьютера.
        */
        public Board()
        {
            #region Dict Of Cells
            Cell A1 = new Cell(BLACK, "A1");
            dictOfCells.Add(A1.CellName, A1);
            Cell B1 = new Cell(WHITE, "B1");
            dictOfCells.Add(B1.CellName, B1);
            Cell C1 = new Cell(BLACK, "C1");
            dictOfCells.Add(C1.CellName, C1);
            Cell D1 = new Cell(WHITE, "D1");
            dictOfCells.Add(D1.CellName, D1);
            Cell E1 = new Cell(BLACK, "E1");
            dictOfCells.Add(E1.CellName, E1);
            Cell F1 = new Cell(WHITE, "F1");
            dictOfCells.Add(F1.CellName, F1);
            Cell G1 = new Cell(BLACK, "G1");
            dictOfCells.Add(G1.CellName, G1);
            Cell H1 = new Cell(WHITE, "H1");
            dictOfCells.Add(H1.CellName, H1);

            Cell H2 = new Cell(BLACK, "H2");
            dictOfCells.Add(H2.CellName, H2);
            Cell G2 = new Cell(WHITE, "G2");
            dictOfCells.Add(G2.CellName, G2);
            Cell F2 = new Cell(BLACK, "F2");
            dictOfCells.Add(F2.CellName, F2);
            Cell E2 = new Cell(WHITE, "E2");
            dictOfCells.Add(E2.CellName, E2);
            Cell D2 = new Cell(BLACK, "D2");
            dictOfCells.Add(D2.CellName, D2);
            Cell C2 = new Cell(WHITE, "C2");
            dictOfCells.Add(C2.CellName, C2);
            Cell B2 = new Cell(BLACK, "B2");
            dictOfCells.Add(B2.CellName, B2);
            Cell A2 = new Cell(WHITE, "A2");
            dictOfCells.Add(A2.CellName, A2);

            Cell A3 = new Cell(BLACK, "A3");
            dictOfCells.Add(A3.CellName, A3);
            Cell B3 = new Cell(WHITE, "B3");
            dictOfCells.Add(B3.CellName, B3);
            Cell C3 = new Cell(BLACK, "C3");
            dictOfCells.Add(C3.CellName, C3);
            Cell D3 = new Cell(WHITE, "D3");
            dictOfCells.Add(D3.CellName, D3);
            Cell E3 = new Cell(BLACK, "E3");
            dictOfCells.Add(E3.CellName, E3);
            Cell F3 = new Cell(WHITE, "F3");
            dictOfCells.Add(F3.CellName, F3);
            Cell G3 = new Cell(BLACK, "G3");
            dictOfCells.Add(G3.CellName, G3);
            Cell H3 = new Cell(WHITE, "H3");
            dictOfCells.Add(H3.CellName, H3);

            Cell H4 = new Cell(BLACK, "H4");
            dictOfCells.Add(H4.CellName, H4);
            Cell G4 = new Cell(WHITE, "G4");
            dictOfCells.Add(G4.CellName, G4);
            Cell F4 = new Cell(BLACK, "F4");
            dictOfCells.Add(F4.CellName, F4);
            Cell E4 = new Cell(WHITE, "E4");
            dictOfCells.Add(E4.CellName, E4);
            Cell D4 = new Cell(BLACK, "D4");
            dictOfCells.Add(D4.CellName, D4);
            Cell C4 = new Cell(WHITE, "C4");
            dictOfCells.Add(C4.CellName, C4);
            Cell B4 = new Cell(BLACK, "B4");
            dictOfCells.Add(B4.CellName, B4);
            Cell A4 = new Cell(WHITE, "A4");
            dictOfCells.Add(A4.CellName, A4);

            Cell A5 = new Cell(BLACK, "A5");
            dictOfCells.Add(A5.CellName, A5);
            Cell B5 = new Cell(WHITE, "B5");
            dictOfCells.Add(B5.CellName, B5);
            Cell C5 = new Cell(BLACK, "C5");
            dictOfCells.Add(C5.CellName, C5);
            Cell D5 = new Cell(WHITE, "D5");
            dictOfCells.Add(D5.CellName, D5);
            Cell E5 = new Cell(BLACK, "E5");
            dictOfCells.Add(E5.CellName, E5);
            Cell F5 = new Cell(WHITE, "F5");
            dictOfCells.Add(F5.CellName, F5);
            Cell G5 = new Cell(BLACK, "G5");
            dictOfCells.Add(G5.CellName, G5);
            Cell H5 = new Cell(WHITE, "H5");
            dictOfCells.Add(H5.CellName, H5);

            Cell H6 = new Cell(BLACK, "H6");
            dictOfCells.Add(H6.CellName, H6);
            Cell G6 = new Cell(WHITE, "G6");
            dictOfCells.Add(G6.CellName, G6);
            Cell F6 = new Cell(BLACK, "F6");
            dictOfCells.Add(F6.CellName, F6);
            Cell E6 = new Cell(WHITE, "E6");
            dictOfCells.Add(E6.CellName, E6);
            Cell D6 = new Cell(BLACK, "D6");
            dictOfCells.Add(D6.CellName, D6);
            Cell C6 = new Cell(WHITE, "C6");
            dictOfCells.Add(C6.CellName, C6);
            Cell B6 = new Cell(BLACK, "B6");
            dictOfCells.Add(B6.CellName, B6);
            Cell A6 = new Cell(WHITE, "A6");
            dictOfCells.Add(A6.CellName, A6);

            Cell A7 = new Cell(BLACK, "A7");
            dictOfCells.Add(A7.CellName, A7);
            Cell B7 = new Cell(WHITE, "B7");
            dictOfCells.Add(B7.CellName, B7);
            Cell C7 = new Cell(BLACK, "C7");
            dictOfCells.Add(C7.CellName, C7);
            Cell D7 = new Cell(WHITE, "D7");
            dictOfCells.Add(D7.CellName, D7);
            Cell E7 = new Cell(BLACK, "E7");
            dictOfCells.Add(E7.CellName, E7);
            Cell F7 = new Cell(WHITE, "F7");
            dictOfCells.Add(F7.CellName, F7);
            Cell G7 = new Cell(BLACK, "G7");
            dictOfCells.Add(G7.CellName, G7);
            Cell H7 = new Cell(WHITE, "H7");
            dictOfCells.Add(H7.CellName, H7);

            Cell H8 = new Cell(BLACK, "H8");
            dictOfCells.Add(H8.CellName, H8);
            Cell G8 = new Cell(WHITE, "G8");
            dictOfCells.Add(G8.CellName, G8);
            Cell F8 = new Cell(BLACK, "F8");
            dictOfCells.Add(F8.CellName, F8);
            Cell E8 = new Cell(WHITE, "E8");
            dictOfCells.Add(E8.CellName, E8);
            Cell D8 = new Cell(BLACK, "D8");
            dictOfCells.Add(D8.CellName, D8);
            Cell C8 = new Cell(WHITE, "C8");
            dictOfCells.Add(C8.CellName, C8);
            Cell B8 = new Cell(BLACK, "B8");
            dictOfCells.Add(B8.CellName, B8);
            Cell A8 = new Cell(WHITE, "A8");
            dictOfCells.Add(A8.CellName, A8);

            #endregion
        }

        public List<Checker> lstOfWhiteChecker = new List<Checker>();
        public List<Checker> lstOfBlackChecker = new List<Checker>();
        public bool IsStartMove = false;
        public Move currentMove = new Move();
        public Dictionary<string, Cell> dictOfCells = new Dictionary<string, Cell>();

        public string MoveMarkedLocationFrom
        {
            get { return _moveMarkedLocationFrom; }
            set { _moveMarkedLocationFrom = value; }
        }

        public string MoveMarkedLocationTo
        {
            get { return _moveMarkedLocationTo; }
            set { _moveMarkedLocationTo = value; }
        }

        public Move ComputerMove() // Основной метод, содержащий распределение функциональности
        {
            Move currentMove = new Move();
            List<Move> listOfBlackMoves = new List<Move>();
            GetListOfMoves(listOfBlackMoves, lstOfBlackChecker, BLACK);
            if (listOfBlackMoves.Count > 0)
            {
                Estimate(listOfBlackMoves);
                currentMove = GetBestMove(listOfBlackMoves);
                currentMove.ColorOfMovedChecker = BLACK;
            }
            lstOfCombinations.Clear();
            return currentMove;
        }

        public void MoveImitation(Move curMove, List<Checker> lstOfCheckers)
        {
            ChangeCheckerLocation(curMove.MoveFrom, curMove.MoveTo, lstOfCheckers);
            ChangeDictOfCellsAfterMove(curMove.MoveFrom, curMove.MoveTo, curMove.ColorOfMovedChecker);
            if (curMove.IsAttack)
                DeleteChecker(curMove.LocationOfdeletedChecker, GetListOfCheckersByLocation(curMove.LocationOfdeletedChecker));
        }

        // Метод для пользовательской стороны (для белых)
        public bool IsAttackElse(Move curMove) // Метод проверяет есть ли второй удар, атака. Необходимо для реализации множественного "убийства"
        {
            bool flag = false;
            string beginLocation = curMove.MoveFrom;
            curMove.MoveFrom = curMove.MoveTo;
            Point moveFromPoint = new Point(dictOfCells[curMove.MoveFrom].coord.X, dictOfCells[curMove.MoveFrom].coord.Y);
            for (int x = moveFromPoint.X - 2; x <= moveFromPoint.X + 2; x += 4)
            {
                for (int y = moveFromPoint.Y - 2; y <= moveFromPoint.Y + 2; y += 4)
                {
                    Point tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        curMove.MoveTo = GetLocation(tempEndLocationPoint);
                        if (curMove.MoveTo != beginLocation)
                        {
                            IsAttack(curMove);
                            if (curMove.IsAttack)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                if (flag == true)
                    break;
            }
            return flag;
        }

        // Метод для пользовательской стороны (для белых)
        public void IsAttack(Move curMove) // Метод проверяет, является ли текущий ход атакующим
        {
            if ((dictOfCells[curMove.MoveFrom].coord.X - dictOfCells[curMove.MoveTo].coord.X == 2
            ||
            dictOfCells[curMove.MoveFrom].coord.X - dictOfCells[curMove.MoveTo].coord.X == -2)
            &&
            dictOfCells[curMove.LocationOfdeletedChecker].IsChecker == true
            &&
            dictOfCells[curMove.LocationOfdeletedChecker].CheckColor == BLACK
            &&
            IsEmptyLocation(curMove.MoveTo))
            {
                curMove.IsAttack = true;
            }
            else
            {
                curMove.IsAttack = false;
                curMove.LocationOfdeletedChecker = null;
            }

        }

        public List<Checker> GetListOfCheckersByLocation(string locationOfChecker)
        {
            List<Checker> tmpList = new List<Checker>();
            if (lstOfBlackChecker.Exists(checker => checker.Location == locationOfChecker))
            {
                tmpList = lstOfBlackChecker;
            }
            else if (lstOfWhiteChecker.Exists(checker => checker.Location == locationOfChecker))
            {
                tmpList = lstOfWhiteChecker;
            }
            return tmpList;
        }

        public List<Checker> GetListOfCheckersByColor(string color)
        {
            List<Checker> tmpList = new List<Checker>();
            if (color == WHITE)
                tmpList = lstOfWhiteChecker;
            if (color == BLACK)
                tmpList = lstOfBlackChecker;
            return tmpList;
        }

        public void GetListOfMoves(List<Move> lstOfMoves, List<Checker> lstOfCheckers, string colorOfMovedCheckers) // Получение списка ходов всех шашек
        {
            foreach (Checker item in lstOfCheckers)
            {
                GetMovesOfChecker(item.Location, colorOfMovedCheckers, lstOfMoves);
                Move curMove = new Move(item.Location, "", colorOfMovedCheckers);
                GetAttackMovesOfChecker(curMove);
                if (curMove.IsAttack)
                    lstOfMoves.Add(curMove);
            }
            DeleteGeneralMoves(lstOfMoves);
        }

        private string _moveMarkedLocationFrom;
        private string _moveMarkedLocationTo;

        private Move
        GetBestMove(List<Move> lstOfMoves) // Выдает ход с максимальной оценкой профита. По сути обычная сортировка, поиск максимума в списке
        {
            Move resMove = new Move();
            resMove.EstimateOfProfit = -100;
            foreach (Move item in lstOfMoves) // check IsAttackMove
            {
                if (item.EstimateOfProfit > resMove.EstimateOfProfit)
                {
                    resMove = item;
                }
            }
            Debug.Assert(resMove.MoveFrom != null, "Bad news. Computer move is null.");
            return resMove;
        }

        private void PrintMove(Move move, string description)
        {
            MessageBox.Show(description + move.MoveFrom + " - " + move.MoveTo);
        }

        private Combination GetBestCombination()
        { // Обязательно декомпозировать иетод в будущем, когда он устаканится
            Combination bestCombo = new Combination();
            Combination alternativeCombo = new Combination();
            double maxOfSumProfit = 0.0;
            double minDifferenceOfProfit = 3.0;
            foreach (Combination item in lstOfCombinations)
            {
                if (item.BlackProfit + item.WhiteProfit > maxOfSumProfit
                &&
                item.BlackProfit > item.WhiteProfit)
                {
                    maxOfSumProfit = item.WhiteProfit + item.BlackProfit;
                    bestCombo = item;
                }
                else if (item.WhiteProfit - item.BlackProfit < minDifferenceOfProfit /* Поиск комбинации с наименьшими потерями*/
                &&
                item.WhiteProfit > item.BlackProfit)
                {
                    alternativeCombo = item;
                    minDifferenceOfProfit = item.WhiteProfit - item.BlackProfit;
                }
            }
            if (bestCombo.combinationOfMoves.Count == 0) // Если выгодный с положительным профитом не найдем - берем ход с наименьшими потерями
            {
                bestCombo = alternativeCombo;
            }
            else
            {

            }
            return bestCombo;
        }

        private void Estimate(List<Move> lstOfMoves)
        {
            FindSafeMove(lstOfMoves); // Поиск ходов, после которых предотвратится убийство своих шашек (и увеличение пользы этих ходов)
            FindUnprotectedMove(lstOfMoves); // Поиск ходов, которые являются подставой своих шашек под удар (и уменьшение пользы этих ходов)
            TurkishGambit(lstOfMoves); // Поиск ходов, которые приведут к однозначной атаке противника,но в последствии появится возможность атаковать большее кол-во шашек соперника
            FindUnsafeMove(lstOfMoves); // Поиск ходов, которые приводят к атакующему ходу противника
            IncreaseEstimateMoveToEdge(lstOfMoves); // Увеличиваем пользу ходов к краю доски (безопасное место!)
            if (!lstOfMoves[0].IsAttack)
                PromoteFrontMove(lstOfMoves);
            PromoteMoveWhichDecreaseEnemySafellyMoves(lstOfMoves); // Увеличиваем пользу ходов вперед (тем самым уменьшаем безопасные ходы соперника)
            if (!lstOfMoves[0].IsAttack && IsAllMoveUnderAttack(lstOfMoves))
            {
                /*
                * Если больше нет безопасных ходов (безопасный ход - ход, который не приведет а атакующему удару соперника),
                * то найти ход с наименьшими потерями
                */
                FindMoveWithMinimalLoss(lstOfMoves);
            }
        }

        private void PromoteFrontMove(List<Move> lstOfMoves)
        {
            foreach (Move move in lstOfMoves)
            {
                move.EstimateOfProfit += 0.425 / ((double)move.MoveTo[1] - 48.0);
            }
        }

        private void PromoteMoveWhichDecreaseEnemySafellyMoves(List<Move> lstOfMoves)
        { /*
* Увеличиваем приоритет тем ходам, которые уменьшают кол-во безопасных ходов соперника
*/
            int countSafelyMovesAfter = 0;
            int countSafelyMovesBefore = 0;
            int maxCountDecreasedEnemyMoves = 0;
            foreach (Move move in lstOfMoves)
            {
                List<Move> listOfMovesBefore = new List<Move>();
                List<Move> listOfMovesAfter = new List<Move>();
                GetListOfMoves(listOfMovesBefore, GetListOfCheckersByColor(InverseColor(lstOfMoves[0].ColorOfMovedChecker)), InverseColor(lstOfMoves[0].ColorOfMovedChecker));
                countSafelyMovesBefore = GetCountSafelyMoves(listOfMovesBefore);
                GetNewListOfMoves(listOfMovesAfter, move);
                countSafelyMovesAfter = GetCountSafelyMoves(listOfMovesAfter);
                RevertMove(move);
                if (countSafelyMovesBefore - countSafelyMovesAfter > maxCountDecreasedEnemyMoves)
                {
                    maxCountDecreasedEnemyMoves = countSafelyMovesBefore - countSafelyMovesAfter;
                    move.EstimateOfProfit += 0.1;
                }
            }
        }

        private int GetCountSafelyMoves(List<Move> lstOfMoves)
        {// Находим кол-во безопасных ходов (которые не приведут к атакующему ходу соперника)
            int resCount = 0;
            FindUnprotectedMove(lstOfMoves);
            foreach (Move move in lstOfMoves)
            {
                resCount++;
                if (move.EstimateOfProfit == 0.25)
                    resCount--;
            }
            return resCount;
        }

        private void FindMoveWithMinimalLoss(List<Move> lstOfMoves)
        { /*
* Мы знаем, что после любого нашего хода последует атака противника
* Задача: Найти ход с минимальными потерями.
* Решение: Имитурем свой ход, находим список ходов соперника, находим средивсех ходов самый лучший для соперника
* Оцениваем ущерб как разница убитых нами и соперником шашек
*/
            CalculateCombinations(lstOfMoves, new List<Move>());
            Combination combinationWithMinLoss = GetCombinationWithMinLoss(lstOfMoves[0].ColorOfMovedChecker);
            if (combinationWithMinLoss.combinationOfMoves.Count != 0)
                foreach (Move move in lstOfMoves)
                {
                    if (move.MoveFrom == combinationWithMinLoss.combinationOfMoves[0].MoveFrom
                    &&
                    move.MoveTo == combinationWithMinLoss.combinationOfMoves[0].MoveTo)
                    {
                        move.EstimateOfProfit += 0.5;
                    }
                }
        }

        private Combination GetCombinationWithMinLoss(string color)
        {
            Combination resCombination = new Combination();
            double profitOfCombination = 0.0;
            double minProfit = -10.0;
            foreach (Combination curCombination in lstOfCombinations)
            {
                if (color == WHITE)
                    profitOfCombination = curCombination.WhiteProfit - curCombination.BlackProfit;
                else if (color == BLACK)
                    profitOfCombination = curCombination.BlackProfit - curCombination.WhiteProfit;
                if (profitOfCombination > minProfit)
                {
                    resCombination = curCombination;
                    minProfit = profitOfCombination;
                }
            }
            return resCombination;
        }

        private bool IsAllMoveUnderAttack(List<Move> lstOfMoves)
        { // Проверить - все ли ходы приведут к атаке соперника
            bool flagAllMoveUderAttack = false;
            foreach (Move move in lstOfMoves)
            {
                List<Move> tmpListOfMoves = new List<Move>();
                GetNewListOfMoves(tmpListOfMoves, move);
                RevertMove(move);
                if (!tmpListOfMoves[0].IsAttack)
                {
                    flagAllMoveUderAttack = false;
                    break;
                }
                else
                {
                    flagAllMoveUderAttack = true;
                }
            }
            return flagAllMoveUderAttack;
        }

        private void IncreaseEstimateMoveToEdge(List<Move> lstOfMoves)
        {
            foreach (Move move in lstOfMoves)
            {
                if (IsEdge(move.MoveTo))
                    move.EstimateOfProfit += 0.1;
            }
        }

        private bool IsEdge(string edge)
        {
            bool flagMoveToEdge = false;
            if (edge != null)
            {
                if (edge[0] == 'A' || edge[0] == 'H')
                    flagMoveToEdge = true;
            }
            else
            {
                Debug.Assert(edge != null, "MoveTo is null");
            }
            return flagMoveToEdge;
        }

        private void FindUnsafeMove(List<Move> lstOfMoves)
        {
            Debug.Assert(lstOfMoves.Count > 0, "Список ходов пустой в методе FindUnsafeMove");
            if (lstOfMoves.Count > 0)
            {
                int countOfCheckersIsUnderAttack = GetCountOfCheckersIsUnderAttack(GetListOfCheckersByColor(lstOfMoves[0].ColorOfMovedChecker));
                foreach (Move move in lstOfMoves)
                {
                    ApplyMove(move, GetListOfCheckersByColor(lstOfMoves[0].ColorOfMovedChecker));
                    int newCountOfCheckersIsUnderAttack = GetCountOfCheckersIsUnderAttack(GetListOfCheckersByColor(lstOfMoves[0].ColorOfMovedChecker));
                    if (countOfCheckersIsUnderAttack < newCountOfCheckersIsUnderAttack)
                        move.EstimateOfProfit -= newCountOfCheckersIsUnderAttack - countOfCheckersIsUnderAttack;
                    RevertMove(move);
                }
            }
        }

        private int GetCountOfCheckersIsUnderAttack(List<Checker> lstOfCheckers)
        {
            int resCount = 0;
            string emptyString = ""; // заглушка
            foreach (Checker checker in lstOfCheckers)
            {
                if (IsCheckerUnderAttack(checker, ref emptyString))
                {
                    resCount++;
                }
            }
            return resCount;
        }

        private void FindSafeMove(List<Move> lstOfMoves)
        {/*
* Находим поле в которое переместится вражеская шашка после удара нашей
* - Находим свой ход который это предотвратит - увеличиваем его пользу
*/
            string safeLocation = null;
            foreach (Checker item in GetListOfCheckersByColor(lstOfMoves[0].ColorOfMovedChecker))
            {
                if (IsCheckerUnderAttack(item, ref safeLocation))
                {
                    FindProtectedMove(lstOfMoves, item, safeLocation);
                }
            }
        }

        private void TurkishGambit(List<Move> lstOfMoves)
        {
            /*
            * 1. Поиск хода, который приведет к доднозначному удару противника
            * 2. После этого атакующего удара проверка на наличие множественного удара своего, превосходящего в кол-ве пораженных шашек соперника
            * 3. Присвоение этому удару ВЫСОКОГО приоритета
            *
            *
            * 4*. После можно применять такую оценку и атакующих ходов
            */
            double profit = 0.0;
            foreach (Move move in lstOfMoves)
            {
                if (IsThereProfit(move, ref profit))
                {
                    move.EstimateOfProfit += profit;
                }
                profit = 0.0;
            }
        }

        private bool IsThereProfit(Move curMove, ref double profit)
        {
            bool flagProfit = false;
            List<Move> newListOfMoves = new List<Move>();
            GetNewListOfMoves(newListOfMoves, curMove);
            profit += GetProfitOfMove(curMove);
            if (IsThereSingleEnemyAttack(newListOfMoves))
            {
                IsThereMultiKill(newListOfMoves[0], ref profit);
                if (profit > 0)
                {
                    flagProfit = true;
                }
            }
            RevertMove(curMove);
            return flagProfit;
        }

        private bool IsThereSingleEnemyAttack(List<Move> lstOfMoves)
        {
            bool flag = false;
            if (lstOfMoves.Count == 1)
            {
                if (lstOfMoves[0].IsAttack)
                    flag = true;
            }
            return flag;
        }

        private bool IsThereMultiKill(Move curMove, ref double profit)
        {
            bool flagMultiKill = false;
            List<Move> newListOfMoves = new List<Move>();
            GetNewListOfMoves(newListOfMoves, curMove);
            profit -= GetProfitOfMove(curMove);
            if (newListOfMoves.Count > 0)
                if (newListOfMoves[0].IsAttack)
                {
                    Move bestMove = GetBestMove(newListOfMoves);
                    if (IsThereEnemyAttack(bestMove, ref profit))
                    {

                    }
                }
            RevertMove(curMove);
            return flagMultiKill;
        }

        private bool IsThereEnemyAttack(Move curMove, ref double profit)
        {
            bool flagEnemyAttack = false;
            List<Move> newListOfMoves = new List<Move>();
            GetNewListOfMoves(newListOfMoves, curMove);
            profit +=
            GetProfitOfMove(curMove);
            if (newListOfMoves.Count > 0)
                if (newListOfMoves[0].IsAttack)
                {
                    flagEnemyAttack = true;
                    profit--;
                }
            RevertMove(curMove);
            return flagEnemyAttack;
        }

        private double GetProfitOfMove(Move curMove)
        {
            double curProfit = 0.0;
            if (curMove.IsAttack)
                curProfit += curMove.lstOfAttackMoves.Count;

            return curProfit;
        }

        private void CalculateCombinations(List<Move> lstOfMoves, List<Move> lstOfMovesForCombination)
        {/* lstOfMovesForCombination содержит список ходов с предыдущего уровня рекурсии listOfMoves содержит список ходов одной из сторон
* с учетом произведенных ходов в текущей комбинации */
            // Кстати, можно добавить метод, который будет сразу оценивать пользу/адекватность этого хода
            // Таким способом можно значительно сократить ветвление рекурсии
            depthOfRecursion++;
            foreach (Move item in lstOfMoves)
            {
                if (depthOfRecursion < limitOfRecursion) // Глубина рекурсии ограничена вручную
                {/*
* Здесь мы добавляем новый ход в комбинацию Получаем новый список ходов оппонента с учетом хода добавленного
* в комбинацию. И Углубляемся дальше в рекурсию */
                    lstOfMovesForCombination.Add(item);
                    List<Move> listOfPotentionalMoves = new List<Move>();
                    GetNewListOfMoves(listOfPotentionalMoves, item);
                    if (listOfPotentionalMoves.Count != 0)
                        Estimate(listOfPotentionalMoves);
                    CalculateCombinations(listOfPotentionalMoves, lstOfMovesForCombination);
                    RevertMove(item);
                    lstOfMovesForCombination.Remove(item);
                }
                else /*
* Только здесь в конце рекурсии создаем объект Комбинация Добавляем последний ход в комбинацию,
* переписываем весь список ходов в комбинацию Добавляем комбинацию в общий список комбинаций */
                {
                    Combination newCombination = new Combination();
                    List<Move> newListOfMovesForCombination = new List<Move>(lstOfMovesForCombination); // ATTENTION!!! Обратить сюда внимание, "копирование" не полное!
                    newListOfMovesForCombination.Add(item);
                    newCombination.combinationOfMoves = newListOfMovesForCombination;
                    lstOfCombinations.Add(newCombination);
                }
            }
            depthOfRecursion--; // так как мы возвращаемся на предыдущий уровень рекурсии
        }

        private void RevertMove(Move curMove) // Отменяет изменения внесенные текущим ходом
        {
            if (curMove.IsAttack)
            {
                for (int i = curMove.lstOfAttackMoves.Count - 1; i >= 0; i--)
                    RevertMoveImitation(curMove.lstOfAttackMoves[i]);
            }
            else
            {
                RevertMoveImitation(curMove);
            }
        }

        private void RevertMoveImitation(Move curMove)
        {
            List<Checker> lstOfCheckers = GetListOfCheckersByColor(curMove.ColorOfMovedChecker);
            ChangeCheckerLocation(curMove.MoveTo, curMove.MoveFrom, lstOfCheckers);
            ChangeDictOfCellsAfterMove(curMove.MoveTo, curMove.MoveFrom, curMove.ColorOfMovedChecker);
            if (curMove.IsAttack)
            {
                string inverseColor = InverseColor(curMove.ColorOfMovedChecker);
                AddCheckerToDictOfCells(curMove.LocationOfdeletedChecker, inverseColor);
                GetListOfCheckersByColor(inverseColor).Add(new Checker(curMove.LocationOfdeletedChecker, inverseColor));
            }
        }

        private void GetNewListOfMoves(List<Move> listOfMoves, Move curMove)
        {
            ApplyMove(curMove, GetListOfCheckersByColor(curMove.ColorOfMovedChecker));
            string inverseColor = InverseColor(curMove.ColorOfMovedChecker);
            GetListOfMoves(listOfMoves, GetListOfCheckersByColor(inverseColor), inverseColor);
        }

        private void ApplyMove(Move curMove, List<Checker> lstOfCheckers)
        {
            if (curMove.IsAttack)
            {
                foreach (Move item in curMove.lstOfAttackMoves) // На случай если удар множественный
                {
                    MoveImitation(item, lstOfCheckers);
                    // Debug.Assert(item.IsAttack, "Trouble with List of attack moves in CurMove");
                }
            }
            else
            {
                MoveImitation(curMove, lstOfCheckers);
            }
        }

        private void FindUnprotectedMove(List<Move> unprotectLstOfMoves)
        {
            string capString = null; // заглушка, пустая строка
            foreach (Move item in unprotectLstOfMoves)
            {
                Checker tmpChecker = new Checker(item.MoveTo, item.ColorOfMovedChecker);
                //dictOfCells[item.MoveFrom].IsChecker = false; // Имитируем отсутствие шашки которая ходит
                ApplyMove(item, GetListOfCheckersByColor(item.ColorOfMovedChecker));
                if
                (IsCheckerUnderAttack(tmpChecker, ref capString))
                    item.EstimateOfProfit -= 0.25;
                //dictOfCells[item.MoveFrom].IsChecker = true; // Возвращаем ее на место
                RevertMove(item);
            }
        }

        private void DeleteGeneralMoves(List<Move> lstOfMoves) // Соблюдаем правило шашек - Если есть возможность бить, надо бить!
                                                               // Соответственно, делаем проверку - Если есть атакующий ход, удаляем все обычные ходы, т.е. не даем возможности сделать обычный ход
        {
            if (lstOfMoves.Exists(move => move.IsAttack))
                lstOfMoves.RemoveAll(move => !move.IsAttack);
        }

        private void GetMovesOfChecker(string locationFrom, string checkerColor, List<Move> lstOfMoves) // Получение ходов конкретной шашки
        {
            Point moveFromPoint = new Point(dictOfCells[locationFrom].coord.X, dictOfCells[locationFrom].coord.Y);
            Point tempEndLocationPoint = new Point();
            for (int x = moveFromPoint.X - 1; x <= moveFromPoint.X + 1; x += 2)
            {
                for (int y = moveFromPoint.Y - 1; y <= moveFromPoint.Y + 1; y += 2)
                {
                    tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        Move curMove = new Move(locationFrom, GetLocation(tempEndLocationPoint), checkerColor);
                        if (IsValidMove(curMove)) // Обычный ход, удовлетворяющий правилам игры
                        {
                            curMove.EstimateOfProfit = 0.5; // Присвоение значение пользы
                            lstOfMoves.Add(curMove.Clone() as Move);
                        }
                    }
                }
            }
        }

        private void GetAttackMovesOfChecker(Move curMove) // Есть возможность и потребность разделить этот метод на более мелкие ( например можно вынести логику определения IsMultiKill, этот метод также потребуется для пользовательского хода)
        { // Метод выдает множественную атаку
            Point moveFromPoint = new Point(dictOfCells[curMove.MoveFrom].coord.X, dictOfCells[curMove.MoveFrom].coord.Y);
            Point tempEndLocationPoint = new Point();
            flagRevert = false;
            for (int x = moveFromPoint.X - 2; x <= moveFromPoint.X + 2; x += 4)
            {
                for (int y = moveFromPoint.Y - 2; y <= moveFromPoint.Y + 2; y += 4)
                {
                    tempEndLocationPoint = new Point(x, y);
                    if (IsOnBoard(tempEndLocationPoint))
                    {
                        curMove.MoveTo = GetLocation(tempEndLocationPoint);
                        if (IsNewLocationOfMultiAttack(curMove)) // Назад бить ту же самую шашку нельзя (она просто еще не удалена с поля, пока идет только расчет)
                            if (IsValidAttackMove(curMove)) // Обычный ход, удовлетворяющий правилам игры
                            {
                                curMove.IsAttack = true;
                                curMove.EstimateOfProfit += 1.0;
                                curMove.AddMoveToListOfAttack(curMove.MoveFrom, curMove.MoveTo);
                                curMove.MoveFrom = curMove.MoveTo; // ????
                                MoveImitation(curMove.lstOfAttackMoves[curMove.lstOfAttackMoves.Count - 1], GetListOfCheckersByColor(curMove.ColorOfMovedChecker));
                                GetAttackMovesOfChecker(curMove);
                                if (!flagRevert)
                                {
                                    RevertMove(curMove);
                                    flagRevert = true;
                                    curMove.MoveFrom = curMove.lstOfAttackMoves[curMove.lstOfAttackMoves.Count - 1].MoveFrom;
                                    curMove.MoveTo = curMove.lstOfAttackMoves[curMove.lstOfAttackMoves.Count - 1].MoveTo;
                                }
                                curMove.IsAttack = true; //----------------------------------<<< // Это реально нужно???
                                break;
                            }
                    }
                }
                if (flagRevert)
                    break;
            }
        }

        private bool IsValidMove(Move checkedMove) // Проверка хода на соответствие правилам игры
        {
            bool validFlag = false;
            bool checkerValidflag = IsCheckersMove(checkedMove);
            bool emptylocationTo = IsEmptyLocation(checkedMove.MoveTo);
            if (checkerValidflag && emptylocationTo)
            {
                validFlag = true;
            }
            else
            {

            }
            return validFlag;
        }

        private bool IsCheckerUnderAttack(Checker checker, ref string safeLocation) /*
* Метод проверяет является ли под атакой шашка
*/
        {
            bool flagUnderAttack = false;
            string enemyLocation;
            string emptyLocation;
            for (int x = -1; x < 2; x += 2)
            {
                for (int y = -1; y < 2; y += 2)
                {
                    Point enemyChecker = new Point(checker.Coord.X + x, checker.Coord.Y + y);
                    Point emptyCell = new Point(checker.Coord.X - x, checker.Coord.Y - y);
                    enemyLocation = GetLocation(enemyChecker);
                    emptyLocation = GetLocation(emptyCell);
                    if (IsOnBoard(enemyChecker) && IsOnBoard(emptyCell))
                    {
                        Move tmpMove = new Move(enemyLocation, emptyLocation, dictOfCells[enemyLocation].CheckColor); // tmpMove is created to check IsValidAttackMove
                        if (IsValidAttackMove(tmpMove))
                        {
                            // Мы нашли шашку, которую надо защищать
                            flagUnderAttack = false;
                            safeLocation = emptyLocation;
                        }
                    }
                }
            }

            return flagUnderAttack;
        }

        private void FindProtectedMove(List<Move> protectLstOfMoves, Checker checker, string safeLocation)
        { /* Метод ищет ходы, которые приведут к защите своих шашек. safeLocation - клетка, на которую нужно поместить свою шашку, чтобы защитить другую */
            foreach (Move item in protectLstOfMoves)
            {
                if (item.MoveFrom == checker.Location) // Стимуляция к тому, чтобы шашка ушла из под атаки
                    item.EstimateOfProfit += 0.25;
                if (item.MoveTo == safeLocation) // Стимуляция к тому, чтобы шашка прикрыла другую, которая под атакой
                    item.EstimateOfProfit += 0.25;
            }
        }

        private bool IsCheckersMove(Move checkedMove) // Проверка валидности хода по правилам для шашки
        {
            bool validFlag = true;
            int difCoordY = 1; // Переменная зависит от того какой цвет шагающей шашки (то есть в какую сторону она может ходить только вверх или вниз)
            if (checkedMove.ColorOfMovedChecker == WHITE)
                difCoordY = -1;
            if (dictOfCells[checkedMove.MoveFrom].coord.Y - dictOfCells[checkedMove.MoveTo].coord.Y == difCoordY
            &&
            (dictOfCells[checkedMove.MoveTo].coord.X - dictOfCells[checkedMove.MoveFrom].coord.X == 1
            ||
            dictOfCells[checkedMove.MoveFrom].coord.X - dictOfCells[checkedMove.MoveTo].coord.X == 1))
            {
                validFlag = true;
            }
            return validFlag;
        }

        private bool IsNewLocationOfMultiAttack(Move curMove)
        {
            bool flag = false;
            int countOfMoves = curMove.lstOfAttackMoves.Count;
            if (countOfMoves > 0)
            {
                if (curMove.lstOfAttackMoves[countOfMoves -
                1].MoveFrom != curMove.MoveTo)
                    flag = true;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private bool IsEmptyLocation(string location) // Проверка на пустоту клетки
        {
            bool validFlag = false;
            if (!dictOfCells[location].IsChecker)
            {
                validFlag = true;
            }

            return validFlag;
        }

        private bool IsValidAttackMove(Move checkedMove) // Проверка на атакующий ход
        {
            bool flag = false;
            bool isCheckerAttack = IsCheckerAttack(checkedMove); // удовлетворение правилам удара в шашках
            bool isCheckerThere = IsCheckerThere(checkedMove); // наличие атакующей, атакуемой шашек и отсутствие шашки в целевом положении атакующей шашки
            bool isColorDiff = IsColorDiff(checkedMove); // разность цветов между атакующей и атакуемой шашками
            flag = isCheckerAttack & isCheckerThere & isColorDiff;
            return flag;
        }

        private bool IsColorDiff(Move attackMove) // Проверка на разность цветов атакующей и атакуемой шашек
        {
            Debug.Assert(attackMove.ColorOfMovedChecker != "", "IsColorDiff has null arg");
            Debug.Assert(dictOfCells[attackMove.LocationOfdeletedChecker].CheckColor != "", "IsColorDiff has null arg");
            bool flag = false;
            if (attackMove.ColorOfMovedChecker != dictOfCells[attackMove.LocationOfdeletedChecker].CheckColor)
            {
                flag = true;
            }
            return flag;
        }

        private bool IsCheckerThere(Move checkedMove) // Метод только для метода IsValidAttackMove()
        {
            bool flag = false;
            if (IsEmptyLocation(checkedMove.MoveTo)
            &&
            !IsEmptyLocation(checkedMove.LocationOfdeletedChecker)
            &&
            !IsEmptyLocation(checkedMove.MoveFrom))
            {
                flag = true;
            }
            return flag;
        }

        private bool IsCheckerAttack(Move checkedMove)
        {
            bool flag = false;
            if ((dictOfCells[checkedMove.MoveFrom].coord.Y - dictOfCells[checkedMove.MoveTo].coord.Y == 2
            ||
            dictOfCells[checkedMove.MoveTo].coord.Y - dictOfCells[checkedMove.MoveFrom].coord.Y == 2)
            &&
            (dictOfCells[checkedMove.MoveTo].coord.X - dictOfCells[checkedMove.MoveFrom].coord.X == 2
            ||
            dictOfCells[checkedMove.MoveFrom].coord.X - dictOfCells[checkedMove.MoveTo].coord.X == 2))
            {
                flag =
                true;
            }
            return flag;
        }

        private bool IsOnBoard(Point curPoint) // Решить где использовать этот метод *_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*______????
        {
            bool flag = false;
            if (curPoint.X >= 1 && curPoint.X <= 8)
                if (curPoint.Y >= 1 && curPoint.Y <= 8)
                    flag = true;
            return flag;
        }

        private bool IsOnBoard(string location)// Если location is invalid, then dictOfCells is out of range!!!
        {
            bool flag = false;
            Point curPoint = new Point(dictOfCells[location].coord.X, dictOfCells[location].coord.Y);
            if (curPoint.X >= 1 && curPoint.X <= 8)
                if (curPoint.Y >= 1 && curPoint.Y <= 8)
                    flag = true;
            return flag;
        }

        private string InverseColor(string color)
        {
            string inverseColor = "";
            if (color == WHITE)
                inverseColor = BLACK;
            else if (color == BLACK)
                inverseColor = WHITE;
            return inverseColor;

        }

        private string GetLocation(Point curPoint)
        {
            string resLocation;
            char tempCharX = (char)(curPoint.X + 64);
            char tempCharY = (char)(curPoint.Y + 48);
            resLocation = tempCharX.ToString() + tempCharY.ToString();
            return resLocation;
        }

        private void DeleteChecker(string location, List<Checker> lstOfCheckers)
        {
            RemoveCheckerFromDictOfCells(location);
            lstOfCheckers.RemoveAll(checker => checker.Location == location);
        }

        private void AddChecker(string location, List<Checker> lstOfCheckers)
        {
            AddCheckerToDictOfCells(location, lstOfCheckers[0].Color);
            Checker tmpChecker = new Checker(location, lstOfCheckers[0].Color);
            lstOfCheckers.Add(tmpChecker);
        }

        private void ChangeDictOfCellsAfterMove(string locationFrom, string locationTo, string checkerColor)
        {
            RemoveCheckerFromDictOfCells(locationFrom);
            AddCheckerToDictOfCells(locationTo, checkerColor);
        }

        private void RemoveCheckerFromDictOfCells(string checkerLocation)
        {
            dictOfCells[checkerLocation].CheckColor = null;
            dictOfCells[checkerLocation].IsChecker = false;
        }

        private void AddCheckerToDictOfCells(string checkerLocation, string checkerColor)
        {
            dictOfCells[checkerLocation].CheckColor = checkerColor;
            dictOfCells[checkerLocation].IsChecker = true;
        }

        private void ChangeCheckerLocation(string locationFrom, string locationTo, List<Checker> lstOfCheckers)
        {
            lstOfCheckers.Find(checker => checker.Location == locationFrom).Location = locationTo;
        }

        private List<Combination> lstOfCombinations = new List<Combination>();
        private int limitOfRecursion = 4;
        private int depthOfRecursion = 0;
        private const string WHITE = "white";
        private const string BLACK = "black";
        //private Controller myContr = new Controller();
        private bool flagRevert = false; // Флаг для метода GetAttackMovesOfChecker(). Флаг определен глобально так как в этом методе есть рекурсионный вызов
                                         // Чтобы по окончанию метода не выполнять несколько раз метод RevertMove - используется этот флаг как условие единственного выполнения
    }
}
