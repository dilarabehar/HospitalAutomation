namespace HastaneProje
{
    partial class Edit_Info
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.msk_num = new System.Windows.Forms.MaskedTextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 35);
            this.label8.TabIndex = 44;
            this.label8.Text = "Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 35);
            this.label7.TabIndex = 43;
            this.label7.Text = "Lastname:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 35);
            this.label6.TabIndex = 42;
            this.label6.Text = "Phone Number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 35);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gender:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_gender
            // 
            this.cmb_gender.AccessibleName = "cmb_gender";
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_gender.Location = new System.Drawing.Point(273, 322);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(264, 43);
            this.cmb_gender.TabIndex = 6;
            // 
            // msk_num
            // 
            this.msk_num.AccessibleName = "msk_num";
            this.msk_num.Location = new System.Drawing.Point(273, 197);
            this.msk_num.Mask = "(999) 000-0000";
            this.msk_num.Name = "msk_num";
            this.msk_num.Size = new System.Drawing.Size(264, 42);
            this.msk_num.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.AccessibleName = "txt_pass";
            this.txt_pass.Location = new System.Drawing.Point(273, 259);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(264, 42);
            this.txt_pass.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.AccessibleName = "txt_name";
            this.txt_name.Location = new System.Drawing.Point(273, 14);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(264, 42);
            this.txt_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_update";
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(410, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 36;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_lastname
            // 
            this.txt_lastname.AccessibleName = "txt_lastname";
            this.txt_lastname.Location = new System.Drawing.Point(273, 74);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(264, 42);
            this.txt_lastname.TabIndex = 2;
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // msk_tc
            // 
            this.msk_tc.AccessibleName = "msk_tc";
            this.msk_tc.Location = new System.Drawing.Point(273, 134);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(264, 42);
            this.msk_tc.TabIndex = 3;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "TC Citizen Number:";
            // 
            // Edit_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.msk_num);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Edit_Info";
            this.Text = "Edit_Info";
            this.Load += new System.EventHandler(this.Edit_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.MaskedTextBox msk_num;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}