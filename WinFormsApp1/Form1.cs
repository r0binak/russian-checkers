using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        String name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                name = textBox1.Text;
                try
                {
                    // открытие файла и запись результата
                    using (StreamWriter sw = new StreamWriter("Result.txt", true))
                    {
                        sw.WriteLine();
                        sw.WriteLine(DateTime.Now +  " Новый игрок: " + name);
                        sw.Close();
                    }
                }
                catch { MessageBox.Show("Ошибка сохранения!"); }

                Menu fm_menu = new Menu();
                this.Visible = false;
                fm_menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Введите имя игрока!");
            }
        }
    }
}
