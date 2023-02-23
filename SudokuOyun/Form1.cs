using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //21'den 30. satıra kadar çarpı tuşunun özelliğini kapatma
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.CadetBlue;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.DarkSlateGray;
        }

        private void infoButton_MouseEnter(object sender, EventArgs e)
        {
            infoButton.BackColor = Color.CadetBlue;
        }

        private void infoButton_MouseLeave(object sender, EventArgs e)
        {
            infoButton.BackColor = Color.DarkSlateGray;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Tunahan Akdere Tarafından Yapılmıştır", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.CadetBlue;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.DarkSlateGray;
        }

       
    }
}
