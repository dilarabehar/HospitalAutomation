namespace HastaneProje
{
    partial class Patient_Detail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmb_doctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Lastname:";
            // 
            // lbl_name
            // 
            this.lbl_name.AccessibleName = "lbl_name";
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(256, 136);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(86, 35);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "label4";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AccessibleName = "lbl_tc";
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(256, 53);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(86, 35);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "label2";
            this.lbl_tc.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.cmb_doctor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_branch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 535);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(155, 55);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(252, 42);
            this.txt_id.TabIndex = 12;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(39, 55);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 35);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "ID:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleName = "lnk_chinfo";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(157, 464);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(250, 35);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Information";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_approve";
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(283, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Disease:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleName = "rtxt_disease";
            this.richTextBox1.Location = new System.Drawing.Point(155, 243);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 155);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cmb_doctor
            // 
            this.cmb_doctor.AccessibleName = "cmb_doctor";
            this.cmb_doctor.FormattingEnabled = true;
            this.cmb_doctor.Location = new System.Drawing.Point(155, 172);
            this.cmb_doctor.Name = "cmb_doctor";
            this.cmb_doctor.Size = new System.Drawing.Size(252, 43);
            this.cmb_doctor.TabIndex = 6;
            this.cmb_doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 35);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doctor:";
            // 
            // cmb_branch
            // 
            this.cmb_branch.AccessibleName = "cmn_branch";
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(155, 110);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(252, 43);
            this.cmb_branch.TabIndex = 4;
            this.cmb_branch.SelectedIndexChanged += new System.EventHandler(this.cmb_branch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Branch:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(558, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1068, 345);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(559, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1068, 361);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1062, 320);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Patient_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1696, 901);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Patient_Detail";
            this.Text = "Patient_Detail";
            this.Load += new System.EventHandler(this.Patient_Detail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmb_doctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}