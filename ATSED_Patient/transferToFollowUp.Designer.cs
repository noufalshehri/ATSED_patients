namespace ATSED_Patient
{
    partial class transferToFollowUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(37, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "you must be seen by a specialized doctor please take the transfer form to the nur" +
    "se";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ATSED_Patient.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1083, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 67);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Typographer Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(45, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1071, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "يجب أن يراك الطبيب المختص، الرجاء استلام نموذج التحويل واخذه للممرضه لتعبئته";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ATSED_Patient.Properties.Resources.heartbeat;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-32, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 143);
            this.panel1.TabIndex = 5;
            // 
            // transferToFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1179, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transferToFollowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transferToFollowUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}