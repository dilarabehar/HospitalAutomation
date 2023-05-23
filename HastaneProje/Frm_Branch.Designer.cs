namespace HastaneProje
{
    partial class Frm_Branch
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AccessibleName = "btn_update";
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(348, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 28;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "btn_del";
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(348, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 27;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_add";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(348, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(604, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 289);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_branch
            // 
            this.txt_branch.AccessibleName = "txt_br";
            this.txt_branch.Location = new System.Drawing.Point(259, 198);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.Size = new System.Drawing.Size(199, 42);
            this.txt_branch.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Branch:";
            // 
            // txt_id
            // 
            this.txt_id.AccessibleName = "txt_brid";
            this.txt_id.Location = new System.Drawing.Point(259, 139);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(199, 42);
            this.txt_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Branch ID:";
            // 
            // Frm_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 523);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_branch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Branch";
            this.Text = "Frm_Branch";
            this.Load += new System.EventHandler(this.Frm_Branch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
    }
}