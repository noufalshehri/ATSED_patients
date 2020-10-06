namespace ATSED_Patient
{
    partial class language
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ARLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "English";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(72, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "العربية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ATSED_Patient.Properties.Resources.home;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(567, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 67);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(662, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 598);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ATSED_Patient.Properties.Resources.langbubble;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(74, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 389);
            this.panel2.TabIndex = 25;
            // 
            // ARLabel
            // 
            this.ARLabel.AutoSize = true;
            this.ARLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ARLabel.Location = new System.Drawing.Point(147, 278);
            this.ARLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(353, 64);
            this.ARLabel.TabIndex = 24;
            this.ARLabel.Text = "الرجاء اختيار اللغة";
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Bebas Neue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.ForeColor = System.Drawing.Color.Crimson;
            this.englishLabel.Location = new System.Drawing.Point(106, 221);
            this.englishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(444, 72);
            this.englishLabel.TabIndex = 23;
            this.englishLabel.Text = "Choose The Language";
            // 
            // language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.ARLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "language";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "language";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Panel panel2;
    }
}