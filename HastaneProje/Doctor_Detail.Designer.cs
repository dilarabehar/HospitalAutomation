namespace HastaneProje
{
    partial class Doctor_Detail
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name Lastname:";
            // 
            // lbl_name
            // 
            this.lbl_name.AccessibleName = "lbl_name";
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(295, 153);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(86, 35);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "label4";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AccessibleName = "lbl_tc";
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(295, 70);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(86, 35);
            this.lbl_tc.TabIndex = 6;
            this.lbl_tc.Text = "label2";
            this.lbl_tc.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 343);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(593, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 897);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment List";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(3, 646);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 263);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button3
            // 
            this.button3.AccessibleName = "btn_exit";
            this.button3.Location = new System.Drawing.Point(151, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "btn_announc";
            this.button2.Location = new System.Drawing.Point(281, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Announcements";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_editinfo";
            this.button1.Location = new System.Drawing.Point(31, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(632, 856);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 302);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Doctor_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 931);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Doctor_Detail";
            this.Text = "Doctor_Detail";
            this.Load += new System.EventHandler(this.Doctor_Detail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}