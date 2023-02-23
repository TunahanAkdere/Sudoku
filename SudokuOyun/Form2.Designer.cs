namespace SudokuOyun
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kolaySec = new System.Windows.Forms.Button();
            this.ortaSec = new System.Windows.Forms.Button();
            this.zorSec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kolaySec
            // 
            this.kolaySec.BackColor = System.Drawing.Color.DarkCyan;
            this.kolaySec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolaySec.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolaySec.Location = new System.Drawing.Point(29, 48);
            this.kolaySec.Name = "kolaySec";
            this.kolaySec.Size = new System.Drawing.Size(151, 39);
            this.kolaySec.TabIndex = 3;
            this.kolaySec.Text = "Kolay";
            this.kolaySec.UseVisualStyleBackColor = false;
            this.kolaySec.Click += new System.EventHandler(this.kolaySec_Click);
            this.kolaySec.MouseEnter += new System.EventHandler(this.kolaySec_MouseEnter);
            this.kolaySec.MouseLeave += new System.EventHandler(this.kolaySec_MouseLeave);
            // 
            // ortaSec
            // 
            this.ortaSec.BackColor = System.Drawing.Color.DarkCyan;
            this.ortaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ortaSec.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortaSec.Location = new System.Drawing.Point(183, 48);
            this.ortaSec.Name = "ortaSec";
            this.ortaSec.Size = new System.Drawing.Size(151, 39);
            this.ortaSec.TabIndex = 4;
            this.ortaSec.Text = "Normal";
            this.ortaSec.UseVisualStyleBackColor = false;
            this.ortaSec.Click += new System.EventHandler(this.ortaSec_Click);
            this.ortaSec.MouseEnter += new System.EventHandler(this.ortaSec_MouseEnter);
            this.ortaSec.MouseLeave += new System.EventHandler(this.ortaSec_MouseLeave);
            // 
            // zorSec
            // 
            this.zorSec.BackColor = System.Drawing.Color.DarkCyan;
            this.zorSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zorSec.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorSec.Location = new System.Drawing.Point(340, 48);
            this.zorSec.Name = "zorSec";
            this.zorSec.Size = new System.Drawing.Size(151, 39);
            this.zorSec.TabIndex = 5;
            this.zorSec.Text = "Zor";
            this.zorSec.UseVisualStyleBackColor = false;
            this.zorSec.Click += new System.EventHandler(this.zorSec_Click);
            this.zorSec.MouseEnter += new System.EventHandler(this.zorSec_MouseEnter);
            this.zorSec.MouseLeave += new System.EventHandler(this.zorSec_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(340, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(512, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zorSec);
            this.Controls.Add(this.ortaSec);
            this.Controls.Add(this.kolaySec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Zorluk Seçim Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kolaySec;
        private System.Windows.Forms.Button ortaSec;
        private System.Windows.Forms.Button zorSec;
        private System.Windows.Forms.Button button1;
    }
}