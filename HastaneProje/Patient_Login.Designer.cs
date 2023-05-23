namespace HastaneProje
{
    partial class Patient_Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lnk_signup = new System.Windows.Forms.LinkLabel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AccessibleName = "";
            this.btn_login.Location = new System.Drawing.Point(1083, 463);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(190, 77);
            this.btn_login.TabIndex = 26;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnk_signup
            // 
            this.lnk_signup.AccessibleName = "";
            this.lnk_signup.AutoSize = true;
            this.lnk_signup.Location = new System.Drawing.Point(601, 579);
            this.lnk_signup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnk_signup.Name = "lnk_signup";
            this.lnk_signup.Size = new System.Drawing.Size(106, 35);
            this.lnk_signup.TabIndex = 25;
            this.lnk_signup.TabStop = true;
            this.lnk_signup.Text = "Sign Up";
            this.lnk_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // txt_pass
            // 
            this.txt_pass.AccessibleName = "";
            this.txt_pass.Location = new System.Drawing.Point(584, 458);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(437, 42);
            this.txt_pass.TabIndex = 24;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // msk_tc
            // 
            this.msk_tc.AccessibleName = "";
            this.msk_tc.Location = new System.Drawing.Point(584, 319);
            this.msk_tc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(437, 42);
            this.msk_tc.TabIndex = 23;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Citizen Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 58);
            this.label1.TabIndex = 20;
            this.label1.Text = "Patient Login Panel";
            // 
            // Patient_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1425, 724);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lnk_signup);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Patient_Login";
            this.Text = "Patient_Login";
            this.Load += new System.EventHandler(this.Patient_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lnk_signup;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}