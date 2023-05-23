namespace HastaneProje
{
    partial class Doctor_EditInfo
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 35);
            this.label8.TabIndex = 50;
            this.label8.Text = "Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 35);
            this.label7.TabIndex = 49;
            this.label7.Text = "Lastname:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_name
            // 
            this.txt_name.AccessibleName = "txt_name";
            this.txt_name.Location = new System.Drawing.Point(326, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(264, 42);
            this.txt_name.TabIndex = 48;
            // 
            // txt_last
            // 
            this.txt_last.AccessibleName = "txt_lastname";
            this.txt_last.Location = new System.Drawing.Point(326, 72);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(264, 42);
            this.txt_last.TabIndex = 47;
            // 
            // msk_tc
            // 
            this.msk_tc.AccessibleName = "msk_tc";
            this.msk_tc.Location = new System.Drawing.Point(326, 132);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(264, 42);
            this.msk_tc.TabIndex = 46;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 45;
            this.label2.Text = "TC Citizen Number:";
            // 
            // txt_pass
            // 
            this.txt_pass.AccessibleName = "txt_pass";
            this.txt_pass.Location = new System.Drawing.Point(329, 258);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(264, 42);
            this.txt_pass.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 51;
            this.label3.Text = "Branch:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_update";
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(472, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 53;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_branch
            // 
            this.cmb_branch.AccessibleName = "cmb_branch";
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(326, 189);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(267, 43);
            this.cmb_branch.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.TabIndex = 55;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Doctor_EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_branch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Doctor_EditInfo";
            this.Text = "Doctor_EditInfo";
            this.Load += new System.EventHandler(this.Doctor_EditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.Label label1;
    }
}