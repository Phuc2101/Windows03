namespace Windows03
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
            this.tn1 = new System.Windows.Forms.Label();
            this.tn2 = new System.Windows.Forms.Label();
            this.tn3 = new System.Windows.Forms.Label();
            this.tn4 = new System.Windows.Forms.Label();
            this.hs1 = new System.Windows.Forms.TextBox();
            this.hs2 = new System.Windows.Forms.TextBox();
            this.hs3 = new System.Windows.Forms.TextBox();
            this.hs4 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tn1
            // 
            this.tn1.AutoSize = true;
            this.tn1.Location = new System.Drawing.Point(306, 41);
            this.tn1.Name = "tn1";
            this.tn1.Size = new System.Drawing.Size(45, 13);
            this.tn1.TabIndex = 0;
            this.tn1.Text = "He so A";
            // 
            // tn2
            // 
            this.tn2.AutoSize = true;
            this.tn2.Location = new System.Drawing.Point(306, 93);
            this.tn2.Name = "tn2";
            this.tn2.Size = new System.Drawing.Size(45, 13);
            this.tn2.TabIndex = 1;
            this.tn2.Text = "He so B";
            // 
            // tn3
            // 
            this.tn3.AutoSize = true;
            this.tn3.Location = new System.Drawing.Point(306, 138);
            this.tn3.Name = "tn3";
            this.tn3.Size = new System.Drawing.Size(45, 13);
            this.tn3.TabIndex = 2;
            this.tn3.Text = "He so C";
            // 
            // tn4
            // 
            this.tn4.AutoSize = true;
            this.tn4.Location = new System.Drawing.Point(306, 190);
            this.tn4.Name = "tn4";
            this.tn4.Size = new System.Drawing.Size(44, 13);
            this.tn4.TabIndex = 3;
            this.tn4.Text = "Ket qua";
            // 
            // hs1
            // 
            this.hs1.Location = new System.Drawing.Point(417, 49);
            this.hs1.Name = "hs1";
            this.hs1.Size = new System.Drawing.Size(100, 20);
            this.hs1.TabIndex = 4;
            // 
            // hs2
            // 
            this.hs2.Location = new System.Drawing.Point(417, 93);
            this.hs2.Name = "hs2";
            this.hs2.Size = new System.Drawing.Size(100, 20);
            this.hs2.TabIndex = 5;
            // 
            // hs3
            // 
            this.hs3.Location = new System.Drawing.Point(417, 135);
            this.hs3.Name = "hs3";
            this.hs3.Size = new System.Drawing.Size(100, 20);
            this.hs3.TabIndex = 6;
            // 
            // hs4
            // 
            this.hs4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hs4.Location = new System.Drawing.Point(417, 187);
            this.hs4.Name = "hs4";
            this.hs4.Size = new System.Drawing.Size(100, 20);
            this.hs4.TabIndex = 7;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(497, 244);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "show";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.hs4);
            this.Controls.Add(this.hs3);
            this.Controls.Add(this.hs2);
            this.Controls.Add(this.hs1);
            this.Controls.Add(this.tn4);
            this.Controls.Add(this.tn3);
            this.Controls.Add(this.tn2);
            this.Controls.Add(this.tn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tn1;
        private System.Windows.Forms.Label tn2;
        private System.Windows.Forms.Label tn3;
        private System.Windows.Forms.Label tn4;
        private System.Windows.Forms.TextBox hs1;
        private System.Windows.Forms.TextBox hs2;
        private System.Windows.Forms.TextBox hs3;
        private System.Windows.Forms.TextBox hs4;
        private System.Windows.Forms.Button bt1;
    }
}

