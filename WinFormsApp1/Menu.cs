using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpForm hForm = new HelpForm();
            hForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutForm aForm = new AboutForm();
            aForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameForm gForm = new GameForm();
            gForm.ShowDialog();
            this.Visible = true;
        }
    }
}
