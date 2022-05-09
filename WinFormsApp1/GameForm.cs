using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class GameForm : Form
    {
        const string WHITE = "white";
        const string BLACK = "black";
        const string WHITE_CHECKER = "White_Checker1.png";
        const string BLACK_CHECKER = "Black_Checker1.png";
        Board myBoard;
        public Dictionary<string, Panel> dictOfPanels = new Dictionary<string, Panel>();

        public GameForm()
        {
            InitializeComponent();
            myBoard = new Board();
            #region DictOfCells.Add();
            dictOfPanels.Add("A1", A1);
            dictOfPanels.Add("A2", A2);
            dictOfPanels.Add("A3", A3);
            dictOfPanels.Add("A4", A4);
            dictOfPanels.Add("A5", A5);
            dictOfPanels.Add("A6", A6);
            dictOfPanels.Add("A7", A7);
            dictOfPanels.Add("A8", A8);
            dictOfPanels.Add("B1", B1);
            dictOfPanels.Add("B2", B2);
            dictOfPanels.Add("B3", B3);
            dictOfPanels.Add("B4", B4);
            dictOfPanels.Add("B5", B5);
            dictOfPanels.Add("B6", B6);
            dictOfPanels.Add("B7", B7);
            dictOfPanels.Add("B8", B8);
            dictOfPanels.Add("C1", C1);
            dictOfPanels.Add("C2", C2);
            dictOfPanels.Add("C3", C3);
            dictOfPanels.Add("C4", C4);
            dictOfPanels.Add("C5", C5);
            dictOfPanels.Add("C6", C6);
            dictOfPanels.Add("C7", C7);
            dictOfPanels.Add("C8", C8);
            dictOfPanels.Add("D1", D1);
            dictOfPanels.Add("D2", D2);
            dictOfPanels.Add("D3", D3);
            dictOfPanels.Add("D4", D4);
            dictOfPanels.Add("D5", D5);
            dictOfPanels.Add("D6", D6);
            dictOfPanels.Add("D7", D7);
            dictOfPanels.Add("D8", D8);
            dictOfPanels.Add("E1", E1);
            dictOfPanels.Add("E2", E2);
            dictOfPanels.Add("E3", E3);
            dictOfPanels.Add("E4", E4);
            dictOfPanels.Add("E5", E5);
            dictOfPanels.Add("E6", E6);
            dictOfPanels.Add("E7", E7);
            dictOfPanels.Add("E8", E8);
            dictOfPanels.Add("F1", F1);
            dictOfPanels.Add("F2", F2);
            dictOfPanels.Add("F3", F3);
            dictOfPanels.Add("F4", F4);
            dictOfPanels.Add("F5", F5);
            dictOfPanels.Add("F6", F6);
            dictOfPanels.Add("F7", F7);
            dictOfPanels.Add("F8", F8);
            dictOfPanels.Add("G1", G1);
            dictOfPanels.Add("G2", G2);
            dictOfPanels.Add("G3", G3);
            dictOfPanels.Add("G4", G4);
            dictOfPanels.Add("G5", G5);
            dictOfPanels.Add("G6", G6);
            dictOfPanels.Add("G7", G7);
            dictOfPanels.Add("G8", G8);
            dictOfPanels.Add("H1", H1);
            dictOfPanels.Add("H2", H2);
            dictOfPanels.Add("H3", H3);
            dictOfPanels.Add("H4", H4);
            dictOfPanels.Add("H5", H5);
            dictOfPanels.Add("H6", H6);
            dictOfPanels.Add("H7", H7);
            dictOfPanels.Add("H8", H8);
            #endregion
            DrawBoard(myBoard.dictOfCells);
        }

        public void DrawBoard(Dictionary<string, Cell> dictOfCells)
        {
            foreach (KeyValuePair<string, Cell> item in dictOfCells)
            {
                dictOfPanels[item.Value.CellName].BackgroundImage = null;
                if (item.Value.CellColor == WHITE) dictOfPanels[item.Value.CellName].BackColor = Color.LightYellow;
                else dictOfPanels[item.Value.CellName].BackColor = Color.SaddleBrown;
                dictOfPanels[item.Value.CellName].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public void DrawChecker(string panelName, string color)
        {
            string image;
            if (color == WHITE) image = WHITE_CHECKER;
            else image = BLACK_CHECKER;
            dictOfPanels[panelName].BackgroundImage = Image.FromFile(image);
            myBoard.dictOfCells[panelName].IsChecker = true;
            myBoard.dictOfCells[panelName].CheckColor = color;
        }
        public void DrawCheckers(Dictionary<string, Cell> dictOfCells) // наносим шашки на доску
        {
            foreach (KeyValuePair<string, Cell> item in dictOfCells)
            {
                if (item.Value.coord.Y < 4 && item.Value.CellColor == BLACK) DrawChecker(item.Value.CellName, WHITE);
                if (item.Value.coord.Y > 5 && item.Value.CellColor == BLACK) DrawChecker(item.Value.CellName, BLACK);
            }
            textBox1.Text = "";
        }

        public void NewGame()
        {
            // открытие файла и запись результата
            using (StreamWriter sw = new StreamWriter("Result.txt", true))
            {
                sw.WriteLine();
                sw.WriteLine("Новая игра!");
                sw.Close();
            }
            B8.Visible = true;
            myBoard = null;
            myBoard = new Board();
            DrawBoard(myBoard.dictOfCells);
            DrawCheckers(myBoard.dictOfCells);
            foreach (KeyValuePair<string, Cell> item in myBoard.dictOfCells) // перепись всех шашек
            {
                Checker curChecker = new Checker();
                if (item.Value.IsChecker)
                {
                    curChecker.Color = item.Value.CheckColor;
                    curChecker.Location = item.Key;
                    if (curChecker.Color == WHITE)
                    {
                        myBoard.lstOfWhiteChecker.Add(curChecker);
                    }
                    else
                    {
                        myBoard.lstOfBlackChecker.Add(curChecker);
                    }
                }
            }
            textBox1.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Новая игра")
            {
                NewGame();
            }
            if (e.ClickedItem.Text == "Выход")
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();

                }
            }
        }

        private bool IsValidCheckMove(string locationFrom, string locationTo)
        {
            bool flagValidCheckMove = false;
            List<Move> tmpListOfMoves = new List<Move>();
            myBoard.GetListOfMoves(tmpListOfMoves, myBoard.lstOfWhiteChecker, WHITE);
            foreach (Move move in tmpListOfMoves)
            {
                if (move.MoveFrom == locationFrom
                &&
                move.MoveTo == locationTo)
                {
                    flagValidCheckMove = true;
                    break;
                }
                if (move.IsAttack)
                    foreach (Move attackMove in move.lstOfAttackMoves)
                    {
                        if (attackMove.MoveFrom == locationFrom
                        &&
                        attackMove.MoveTo == locationTo)
                        {
                            flagValidCheckMove = true;
                            break;
                        }
                    }
            }
            return flagValidCheckMove;
        }

        private bool IsValidClick(string location)
        {
            bool flagValidClick = false;
            if (myBoard.dictOfCells[location].CheckColor == WHITE)
            {
                flagValidClick = true;
            }
            return flagValidClick;
        }

        private void ComputerMove()
        {
            Move compMove = myBoard.ComputerMove();
            if (compMove.MoveFrom == null)
            {
                MessageBox.Show("Конец партии. Шашки компьютера не имеют возможности хода.");
                DialogResult result = MessageBox.Show("Начать новую партию?", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    EndGame();

                }
                else
                {
                    NewGame();
                }
            }
            else
            {
                if (compMove.IsAttack)
                {
                    foreach (Move item in compMove.lstOfAttackMoves)
                    {
                        Move(item);
                    }
                }
                else
                {
                    Move(compMove);
                }
            }
        }

        private void Move(Move curMove)
        {
            myBoard.MoveImitation(curMove, myBoard.GetListOfCheckersByColor(curMove.ColorOfMovedChecker));
            DrawChecker(curMove.MoveTo, curMove.ColorOfMovedChecker);
            dictOfPanels[curMove.MoveFrom].BackgroundImage = null;
            dictOfPanels[curMove.MoveFrom].BorderStyle = BorderStyle.FixedSingle;
            dictOfPanels[curMove.MoveFrom].BackColor = Color.SaddleBrown;
            if (curMove.IsAttack)
            {
                KillChecker(curMove.LocationOfdeletedChecker);
            }
            MarkMovedCells(curMove);
        }

        private void MarkMovedCells(Move curMove)
        {
            if (myBoard.MoveMarkedLocationFrom != null)
            {
                dictOfPanels[myBoard.MoveMarkedLocationFrom].BorderStyle = BorderStyle.None;
                dictOfPanels[myBoard.MoveMarkedLocationTo].BorderStyle = BorderStyle.None;
            }
            dictOfPanels[curMove.MoveFrom].BorderStyle = BorderStyle.Fixed3D;
            dictOfPanels[curMove.MoveTo].BorderStyle = BorderStyle.Fixed3D;
            dictOfPanels[curMove.MoveFrom].BackColor = Color.SaddleBrown;
            dictOfPanels[curMove.MoveTo].BackColor = Color.SaddleBrown;

            myBoard.MoveMarkedLocationFrom = curMove.MoveFrom;
            myBoard.MoveMarkedLocationTo = curMove.MoveTo;
            textBox1.Text += curMove.MoveFrom + ":" + curMove.MoveTo + ", ";
            // открытие файла и запись результата
            using (StreamWriter sw = new StreamWriter("Result.txt", true))
            {
                if (curMove.ColorOfMovedChecker == "white")
                {
                    sw.WriteLine("Человек - " + curMove.MoveFrom + ":" + curMove.MoveTo + ", ");
                }
                else
                {
                    sw.WriteLine("Компьютер - " + curMove.MoveFrom + ":" + curMove.MoveTo + ", ");
                }
                sw.Close();
            }
        }

        private void KillChecker(string location)
        {
            dictOfPanels[location].BackgroundImage = null;
            myBoard.dictOfCells[location].IsChecker = false;
            myBoard.dictOfCells[location].CheckColor = null;
            if (IsEndOfGame())
            {
                MessageBox.Show("Конец игры!", "Конец партии");
                DialogResult result = MessageBox.Show("Начать новую партию?", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    EndGame();

                }
                else
                {
                    NewGame();
                }

            }
        }

        private bool IsEndOfGame()
        {
            bool flagEndGame = false;
            if (myBoard.lstOfBlackChecker.Count == 0)
            {
                flagEndGame = true;
                // открытие файла и запись результата
                using (StreamWriter sw = new StreamWriter("Result.txt", true))
                {
                    sw.WriteLine("Победа компьютера!");
                    sw.Close();
                }
            }
            else if (myBoard.lstOfWhiteChecker.Count == 0)
            {
                flagEndGame = true;
                // открытие файла и запись результата
                using (StreamWriter sw = new StreamWriter("Result.txt", true))
                {
                    sw.WriteLine("Победа игрока!");
                    sw.Close();
                }
            }
            return flagEndGame;
        }

        private void EndGame()
        {
            Close();
        }

        private void ClickOnCell(object sender, MouseEventArgs e)
        {
            bool flagMultiKill = false;
            Panel tempPanel = sender as Panel;
            if (!myBoard.IsStartMove)
            {
                if (myBoard.dictOfCells[tempPanel.Name.ToString()].IsChecker
                &&
                IsValidClick(tempPanel.Name.ToString()))
                {
                    myBoard.currentMove.MoveFrom = tempPanel.Name.ToString();
                    myBoard.currentMove.ColorOfMovedChecker = myBoard.dictOfCells[tempPanel.Name.ToString()].CheckColor;
                    myBoard.IsStartMove = true;
                    tempPanel.BorderStyle = BorderStyle.Fixed3D;
                    tempPanel.BackColor = Color.Yellow;
                }
            }
            else
            {
                myBoard.currentMove.MoveTo = tempPanel.Name.ToString();
                if (myBoard.currentMove.MoveTo == myBoard.currentMove.MoveFrom)
                {
                    myBoard.IsStartMove = false;
                    tempPanel.BorderStyle = BorderStyle.None;
                    tempPanel.BackColor = Color.SaddleBrown;
                }
                else
                {
                    myBoard.IsAttack(myBoard.currentMove);
                    if
                    (myBoard.currentMove.IsAttack)
                        flagMultiKill = myBoard.IsAttackElse(myBoard.currentMove.Clone() as Move);
                    if (IsValidCheckMove(myBoard.currentMove.MoveFrom, myBoard.currentMove.MoveTo))
                    {
                        Move(myBoard.currentMove);
                        if (!IsEndOfGame())
                        {
                            myBoard.IsStartMove = false;
                            if (!flagMultiKill)
                            {
                                //label35.Visible = false;
                                ComputerMove();
                            }
                            //else
                                //label35.Visible = true;
                        }
                    }
                }

            }
        }
    }
}
