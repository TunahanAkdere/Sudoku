namespace SudokuOyun
{
    partial class kolaysudoku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kolaysudoku));
            this.kolayStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kolaySudokuDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form2exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kolaySudokuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kolayStart
            // 
            this.kolayStart.BackColor = System.Drawing.Color.Sienna;
            this.kolayStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolayStart.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolayStart.Location = new System.Drawing.Point(450, 60);
            this.kolayStart.Name = "kolayStart";
            this.kolayStart.Size = new System.Drawing.Size(157, 50);
            this.kolayStart.TabIndex = 1;
            this.kolayStart.Text = "Başla";
            this.kolayStart.UseVisualStyleBackColor = false;
            this.kolayStart.Click += new System.EventHandler(this.kolayStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kontrol Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolaySudokuDataGrid
            // 
            this.kolaySudokuDataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.kolaySudokuDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.kolaySudokuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kolaySudokuDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kolaySudokuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kolaySudokuDataGrid.ColumnHeadersVisible = false;
            this.kolaySudokuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kolaySudokuDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.kolaySudokuDataGrid.Location = new System.Drawing.Point(40, 25);
            this.kolaySudokuDataGrid.Name = "kolaySudokuDataGrid";
            this.kolaySudokuDataGrid.RowHeadersVisible = false;
            this.kolaySudokuDataGrid.RowTemplate.Height = 39;
            this.kolaySudokuDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kolaySudokuDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kolaySudokuDataGrid.Size = new System.Drawing.Size(360, 360);
            this.kolaySudokuDataGrid.TabIndex = 3;
            this.kolaySudokuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kolaySudokuDataGrid_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // form2exit
            // 
            this.form2exit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.form2exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.form2exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2exit.Location = new System.Drawing.Point(560, 354);
            this.form2exit.Name = "form2exit";
            this.form2exit.Size = new System.Drawing.Size(107, 31);
            this.form2exit.TabIndex = 8;
            this.form2exit.Text = "Geri";
            this.form2exit.UseVisualStyleBackColor = false;
            this.form2exit.Click += new System.EventHandler(this.form2exit_Click);
            this.form2exit.MouseEnter += new System.EventHandler(this.form2exit_MouseEnter);
            this.form2exit.MouseLeave += new System.EventHandler(this.form2exit_MouseLeave);
            // 
            // kolaysudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(679, 397);
            this.Controls.Add(this.form2exit);
            this.Controls.Add(this.kolaySudokuDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kolayStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kolaysudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kolay Sudoku";
            this.Load += new System.EventHandler(this.kolaysudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolaySudokuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kolayStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView kolaySudokuDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button form2exit;
    }
}