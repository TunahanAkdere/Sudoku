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
    public partial class kolaysudoku : Form
    {
        public kolaysudoku()
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

        private void kolaysudoku_Load(object sender, EventArgs e)
        {
            kolaySudokuDataGrid.RowCount = 9;
            kolaySudokuDataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor= Color.Chocolate;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((i < 3 || i >= 6) && (j < 3 || j >= 6))
                    {
                        kolaySudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.Sienna;
                    }
                    else
                    {
                        kolaySudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.Peru;

                    }
                    if ((i >= 3 && i < 6) && (j >= 3 && j < 6))
                    {
                        kolaySudokuDataGrid.Rows[i].Cells[j].Style.BackColor = Color.Sienna;
                    }

                }
            }
        }

        private void kolayStart_Click(object sender, EventArgs e)
        {
            int[,] board = new int[,]
            {
                {7, 0, 0, 0, 3, 0, 0, 9, 8},
                {8, 4, 0, 7, 2, 0, 5, 3, 0},
                {5, 3, 0, 8, 9, 6, 0, 7, 4},
                {0, 7, 0, 0, 5, 0, 3, 1, 2},
                {9, 0, 0, 3, 1, 2, 6, 8, 7},
                {3, 0, 2, 6, 0, 8, 0, 0, 0},
                {0, 0, 5, 0, 6, 0, 0, 0, 3},
                {0, 6, 0, 0, 0, 3, 4, 5, 0},
                {2, 0, 0, 0, 0, 9, 7, 6, 1}
            };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != 0)
                    {
                        kolaySudokuDataGrid.Rows[i].Cells[j].Value = board[i, j];
                        kolaySudokuDataGrid.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        kolaySudokuDataGrid.Rows[i].Cells[j].Value = null;
                        kolaySudokuDataGrid.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        //CheckButton
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] board = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (kolaySudokuDataGrid.Rows[i].Cells[j].Value != null)
                    {
                        board[i, j] = int.Parse(kolaySudokuDataGrid.Rows[i].Cells[j].Value.ToString());
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

        private void kolaySudokuDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kolaySudokuDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form2exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void form2exit_MouseEnter(object sender, EventArgs e)
        {
            form2exit.BackColor= Color.Goldenrod;
        }

        private void form2exit_MouseLeave(object sender, EventArgs e)
        {
            form2exit.BackColor= Color.DarkGoldenrod;
        }
    }
}
