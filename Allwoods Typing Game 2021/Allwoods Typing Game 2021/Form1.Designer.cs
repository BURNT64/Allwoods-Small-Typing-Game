namespace Allwoods_Typing_Game_2021
{
    partial class Form1
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
            this.LBLCorrect = new System.Windows.Forms.Label();
            this.LBLIncorrect = new System.Windows.Forms.Label();
            this.LBLWord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLCorrect
            // 
            this.LBLCorrect.AutoSize = true;
            this.LBLCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCorrect.ForeColor = System.Drawing.Color.DarkGreen;
            this.LBLCorrect.Location = new System.Drawing.Point(112, 118);
            this.LBLCorrect.Name = "LBLCorrect";
            this.LBLCorrect.Size = new System.Drawing.Size(135, 31);
            this.LBLCorrect.TabIndex = 0;
            this.LBLCorrect.Text = "Correct 0";
            this.LBLCorrect.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLIncorrect
            // 
            this.LBLIncorrect.AutoSize = true;
            this.LBLIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIncorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBLIncorrect.Location = new System.Drawing.Point(466, 118);
            this.LBLIncorrect.Name = "LBLIncorrect";
            this.LBLIncorrect.Size = new System.Drawing.Size(154, 31);
            this.LBLIncorrect.TabIndex = 1;
            this.LBLIncorrect.Text = "Incorrect 0";
            this.LBLIncorrect.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBLWord
            // 
            this.LBLWord.AutoSize = true;
            this.LBLWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLWord.Location = new System.Drawing.Point(262, 177);
            this.LBLWord.Name = "LBLWord";
            this.LBLWord.Size = new System.Drawing.Size(189, 73);
            this.LBLWord.TabIndex = 2;
            this.LBLWord.Text = "Word";
            this.LBLWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLWord.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please Enter to check the text with word";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 80);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(111, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(521, 42);
            this.Title.TabIndex = 5;
            this.Title.Text = "Allwoods Typing Game 2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 490);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLWord);
            this.Controls.Add(this.LBLIncorrect);
            this.Controls.Add(this.LBLCorrect);
            this.Name = "Form1";
            this.Text = "Allwoods Typing Game 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLCorrect;
        private System.Windows.Forms.Label LBLIncorrect;
        private System.Windows.Forms.Label LBLWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
    }
}

