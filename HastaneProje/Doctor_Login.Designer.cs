namespace HastaneProje
{
    partial class Doctor_Login
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
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_login";
            this.button1.Location = new System.Drawing.Point(1101, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.AccessibleName = "txt_pass";
            this.txt_pass.Location = new System.Drawing.Point(567, 504);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(437, 42);
            this.txt_pass.TabIndex = 17;
            this.txt_pass.Text = "1801";
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // msk_tc
            // 
            this.msk_tc.AccessibleName = "msk_tc";
            this.msk_tc.Location = new System.Drawing.Point(567, 367);
            this.msk_tc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(437, 42);
            this.msk_tc.TabIndex = 16;
            this.msk_tc.Text = "11254545454";
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 511);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC Citizen Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Doctor Login Panel";
            // 
            // Doctor_Login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1802, 781);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Doctor_Login";
            this.Text = "Doctor_Login";
            this.Load += new System.EventHandler(this.Doctor_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}