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
    public partial class ortasudoku : Form
    {
        public ortasudoku()
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
        private void ortasudoku_Load(object sender, EventArgs e)
        {
            ortaSudokuDataGrid.RowCount = 9;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((i < 3 || i >= 6) && (j < 3 || j >= 6))
                    {
                        ortaSudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.Plum;
                    }
                    else
                    {
                        ortaSudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.BlueViolet;

                    }
                    if ((i >= 3 && i < 6) && (j >= 3 && j < 6))
                    {
                        ortaSudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.Plum;
                    }

                }
            }
        }

        private void ortaStart_Click(object sender, EventArgs e)
        {
            int[,] board = new int[,]
            {
                {2, 0, 9, 0, 0, 0, 6, 0, 0},
                {0, 4, 0, 8, 7, 0, 0, 1, 2},
                {8, 0, 0, 0, 1, 9, 0, 4, 0},
                {0, 3, 0, 7, 0, 0, 8, 0, 1},
                {0, 6, 5, 0, 0, 8, 0, 3, 0},
                {1, 0, 0, 0, 3, 0, 0, 0, 7},
                {0, 0, 0, 6, 5, 0, 7, 0, 9},
                {6, 0, 4, 0, 0, 0, 0, 2, 0},
                {0, 8, 0, 3, 0, 1, 4, 5, 0}
            };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != 0)
                    {
                        ortaSudokuDataGrid.Rows[i].Cells[j].Value = board[i, j];
                        ortaSudokuDataGrid.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        ortaSudokuDataGrid.Rows[i].Cells[j].Value = null;
                        ortaSudokuDataGrid.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void ortaKontrolEt_Click(object sender, EventArgs e)
        {
            int[,] board = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (ortaSudokuDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        board[i, j] = int.Parse(ortaSudokuDataGrid.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                        board[i, j] = 0;
                }
            }

            //satırlar için kontrol
            for (int i = 0; i < 9; i++)
            {
                int sum = 0;

                for (int j = 0; j < 9; j++)
                {
                    sum += board[i, j];
                }
                if (sum != 45)
                {
                    MessageBox.Show("Hatalı Çözüm Satırı: " + (i + 1).ToString() + ". Satır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //sütünlar için kontrol

            for (int i = 0; i < 9; i++)
            {
                int sum = 0;

                for (int j = 0; j < 9; j++)
                {
                    sum += board[j, i];
                }
                if (sum != 45)
                {
                    MessageBox.Show("Hatalı Çözüm Sütunu " + (i + 1).ToString() + ". Sütun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //Kare kontrolu

            int row, col;

            int[] satir = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
            int[] sutun = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
            int[] ihtimaller = new int[10];

            for (int kare = 0; kare < 9; kare++)
            {
                row = satir[kare];
                col = sutun[kare];

                int toplam = 0;

                //satir
                for (int i = row; i < row + 3; i++)
                {
                    //sütun

                    for (int j = col; j < col + 3; j++)
                    {
                        toplam += board[j, i];
                    }
                }

                if (toplam != 45)
                {
                    MessageBox.Show("Hatalı Çözüm (3x3 Kare içinde) " + (kare + 1).ToString() + ". (3x3)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            MessageBox.Show("Oyun Başarıyla Tamamlandı", "Tebrikler!!", MessageBoxButtons.OK);
        }

        private void form2exit_MouseEnter(object sender, EventArgs e)
        {
            form2exit.BackColor = Color.OrangeRed;
        }

        private void form2exit_MouseLeave(object sender, EventArgs e)
        {
            form2exit.BackColor = Color.Coral;
        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
