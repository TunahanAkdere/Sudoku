namespace SudokuOyun
{
    partial class ortasudoku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ortasudoku));
            this.ortaSudokuDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortaKontrolEt = new System.Windows.Forms.Button();
            this.ortaStart = new System.Windows.Forms.Button();
            this.form2exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ortaSudokuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ortaSudokuDataGrid
            // 
            this.ortaSudokuDataGrid.AllowUserToAddRows = false;
            this.ortaSudokuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ortaSudokuDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ortaSudokuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ortaSudokuDataGrid.ColumnHeadersVisible = false;
            this.ortaSudokuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ortaSudokuDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ortaSudokuDataGrid.Location = new System.Drawing.Point(45, 25);
            this.ortaSudokuDataGrid.Name = "ortaSudokuDataGrid";
            this.ortaSudokuDataGrid.RowHeadersVisible = false;
            this.ortaSudokuDataGrid.RowTemplate.Height = 39;
            this.ortaSudokuDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ortaSudokuDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ortaSudokuDataGrid.Size = new System.Drawing.Size(360, 360);
            this.ortaSudokuDataGrid.TabIndex = 4;
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
            // ortaKontrolEt
            // 
            this.ortaKontrolEt.BackColor = System.Drawing.Color.BlueViolet;
            this.ortaKontrolEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ortaKontrolEt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ortaKontrolEt.Location = new System.Drawing.Point(453, 126);
            this.ortaKontrolEt.Name = "ortaKontrolEt";
            this.ortaKontrolEt.Size = new System.Drawing.Size(157, 50);
            this.ortaKontrolEt.TabIndex = 6;
            this.ortaKontrolEt.Text = "Kontrol Et";
            this.ortaKontrolEt.UseVisualStyleBackColor = false;
            this.ortaKontrolEt.Click += new System.EventHandler(this.ortaKontrolEt_Click);
            // 
            // ortaStart
            // 
            this.ortaStart.BackColor = System.Drawing.Color.Plum;
            this.ortaStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ortaStart.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ortaStart.Location = new System.Drawing.Point(453, 73);
            this.ortaStart.Name = "ortaStart";
            this.ortaStart.Size = new System.Drawing.Size(157, 50);
            this.ortaStart.TabIndex = 5;
            this.ortaStart.Text = "Başla";
            this.ortaStart.UseVisualStyleBackColor = false;
            this.ortaStart.Click += new System.EventHandler(this.ortaStart_Click);
            // 
            // form2exit
            // 
            this.form2exit.BackColor = System.Drawing.Color.Coral;
            this.form2exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.form2exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2exit.Location = new System.Drawing.Point(560, 354);
            this.form2exit.Name = "form2exit";
            this.form2exit.Size = new System.Drawing.Size(107, 31);
            this.form2exit.TabIndex = 7;
            this.form2exit.Text = "Geri";
            this.form2exit.UseVisualStyleBackColor = false;
            this.form2exit.Click += new System.EventHandler(this.form2exit_Click);
            this.form2exit.MouseEnter += new System.EventHandler(this.form2exit_MouseEnter);
            this.form2exit.MouseLeave += new System.EventHandler(this.form2exit_MouseLeave);
            // 
            // ortasudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(679, 397);
            this.Controls.Add(this.form2exit);
            this.Controls.Add(this.ortaKontrolEt);
            this.Controls.Add(this.ortaStart);
            this.Controls.Add(this.ortaSudokuDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ortasudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orta Sudoku";
            this.Load += new System.EventHandler(this.ortasudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ortaSudokuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ortaSudokuDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button ortaKontrolEt;
        private System.Windows.Forms.Button ortaStart;
        private System.Windows.Forms.Button form2exit;
    }
}