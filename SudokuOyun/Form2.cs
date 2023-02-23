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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
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

        private void kolaySec_Click(object sender, EventArgs e)
        {
            kolaysudoku sudokuKolay = new kolaysudoku();
            sudokuKolay.Show();
            this.Hide();
        }

        private void ortaSec_Click(object sender, EventArgs e)
        {
            ortasudoku sudokuOrta = new ortasudoku();
            sudokuOrta.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }

        private void zorSec_Click(object sender, EventArgs e)
        {
            zorsudoku zSo = new zorsudoku();
            zSo.Show();
            this.Hide();
        }

        private void kolaySec_MouseEnter(object sender, EventArgs e)
        {
            kolaySec.BackColor = Color.DarkSlateGray;
        }

        private void kolaySec_MouseLeave(object sender, EventArgs e)
        {
            kolaySec.BackColor = Color.DarkCyan;
        }

        private void ortaSec_MouseEnter(object sender, EventArgs e)
        {
            ortaSec.BackColor = Color.DarkSlateGray;
        }

        private void ortaSec_MouseLeave(object sender, EventArgs e)
        {
            ortaSec.BackColor = Color.DarkCyan;
        }

        private void zorSec_MouseEnter(object sender, EventArgs e)
        {
            zorSec.BackColor = Color.DarkSlateGray;
        }

        private void zorSec_MouseLeave(object sender, EventArgs e)
        {
            zorSec.BackColor= Color.DarkCyan;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
