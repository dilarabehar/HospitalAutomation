namespace HastaneProje
{
    partial class Doctor_Panel
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.AccessibleName = "txt_name";
            this.txt_name.Location = new System.Drawing.Point(262, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 42);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // cmb_branch
            // 
            this.cmb_branch.AccessibleName = "cmb_branch";
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(262, 211);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(199, 43);
            this.cmb_branch.TabIndex = 4;
            this.cmb_branch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Branch:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "TC:";
            // 
            // msk_tc
            // 
            this.msk_tc.AccessibleName = "msk_tc";
            this.msk_tc.Location = new System.Drawing.Point(262, 155);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(199, 42);
            this.msk_tc.TabIndex = 3;
            this.msk_tc.ValidatingType = typeof(int);
            this.msk_tc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_surname
            // 
            this.txt_surname.AccessibleName = "txt_surname";
            this.txt_surname.Location = new System.Drawing.Point(262, 95);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(199, 42);
            this.txt_surname.TabIndex = 2;
            this.txt_surname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.AccessibleName = "txt_pass";
            this.txt_pass.Location = new System.Drawing.Point(262, 270);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(199, 42);
            this.txt_pass.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 289);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_add";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(351, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "btn_del";
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(351, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "btn_update";
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(351, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Doctor_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_branch);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Doctor_Panel";
            this.Text = "Doctor_Panel";
            this.Load += new System.EventHandler(this.Doctor_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}