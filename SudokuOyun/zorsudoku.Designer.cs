namespace SudokuOyun
{
    partial class zorsudoku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zorsudoku));
            this.form2exit = new System.Windows.Forms.Button();
            this.zorKontrolEt = new System.Windows.Forms.Button();
            this.zorStart = new System.Windows.Forms.Button();
            this.zorSudokuDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zorSudokuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // form2exit
            // 
            this.form2exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.form2exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.form2exit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.form2exit.Location = new System.Drawing.Point(558, 359);
            this.form2exit.Name = "form2exit";
            this.form2exit.Size = new System.Drawing.Size(107, 31);
            this.form2exit.TabIndex = 10;
            this.form2exit.Text = "Geri";
            this.form2exit.UseVisualStyleBackColor = false;
            this.form2exit.Click += new System.EventHandler(this.form2exit_Click);
            this.form2exit.MouseEnter += new System.EventHandler(this.form2exit_MouseEnter);
            this.form2exit.MouseLeave += new System.EventHandler(this.form2exit_MouseLeave);
            // 
            // zorKontrolEt
            // 
            this.zorKontrolEt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.zorKontrolEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zorKontrolEt.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zorKontrolEt.Location = new System.Drawing.Point(451, 131);
            this.zorKontrolEt.Name = "zorKontrolEt";
            this.zorKontrolEt.Size = new System.Drawing.Size(157, 50);
            this.zorKontrolEt.TabIndex = 9;
            this.zorKontrolEt.Text = "Kontrol Et";
            this.zorKontrolEt.UseVisualStyleBackColor = false;
            this.zorKontrolEt.Click += new System.EventHandler(this.zorKontrolEt_Click);
            // 
            // zorStart
            // 
            this.zorStart.BackColor = System.Drawing.Color.MediumAquamarine;
            this.zorStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zorStart.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zorStart.Location = new System.Drawing.Point(451, 75);
            this.zorStart.Name = "zorStart";
            this.zorStart.Size = new System.Drawing.Size(157, 50);
            this.zorStart.TabIndex = 8;
            this.zorStart.Text = "Başla";
            this.zorStart.UseVisualStyleBackColor = false;
            this.zorStart.Click += new System.EventHandler(this.zorStart_Click);
            // 
            // zorSudokuDataGrid
            // 
            this.zorSudokuDataGrid.AllowUserToAddRows = false;
            this.zorSudokuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zorSudokuDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zorSudokuDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.zorSudokuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zorSudokuDataGrid.ColumnHeadersVisible = false;
            this.zorSudokuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.zorSudokuDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.zorSudokuDataGrid.Location = new System.Drawing.Point(30, 25);
            this.zorSudokuDataGrid.Name = "zorSudokuDataGrid";
            this.zorSudokuDataGrid.RowHeadersVisible = false;
            this.zorSudokuDataGrid.RowTemplate.Height = 39;
            this.zorSudokuDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.zorSudokuDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zorSudokuDataGrid.Size = new System.Drawing.Size(360, 360);
            this.zorSudokuDataGrid.TabIndex = 11;
            this.zorSudokuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.zorSudokuDataGrid_CellContentClick);
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
            // zorsudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(679, 397);
            this.Controls.Add(this.zorSudokuDataGrid);
            this.Controls.Add(this.form2exit);
            this.Controls.Add(this.zorKontrolEt);
            this.Controls.Add(this.zorStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "zorsudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zor Sudoku";
            this.Load += new System.EventHandler(this.zorsudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zorSudokuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form2exit;
        private System.Windows.Forms.Button zorKontrolEt;
        private System.Windows.Forms.Button zorStart;
        private System.Windows.Forms.DataGridView zorSudokuDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}