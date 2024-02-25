namespace Task1.GUI
{
    partial class RegisterStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.regstu_Btn = new System.Windows.Forms.Button();
            this.course_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reload_Btn = new System.Windows.Forms.Button();
            this.enrol_GV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrol_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.regstu_Btn);
            this.panel1.Controls.Add(this.course_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.reg_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(229, 480);
            this.panel1.TabIndex = 0;
            // 
            // regstu_Btn
            // 
            this.regstu_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regstu_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.regstu_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regstu_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regstu_Btn.Location = new System.Drawing.Point(36, 329);
            this.regstu_Btn.Name = "regstu_Btn";
            this.regstu_Btn.Size = new System.Drawing.Size(148, 55);
            this.regstu_Btn.TabIndex = 3;
            this.regstu_Btn.Text = "Register";
            this.regstu_Btn.UseVisualStyleBackColor = false;
            this.regstu_Btn.Click += new System.EventHandler(this.regstu_Btn_Click);
            // 
            // course_tb
            // 
            this.course_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_tb.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_tb.Location = new System.Drawing.Point(5, 244);
            this.course_tb.Margin = new System.Windows.Forms.Padding(5);
            this.course_tb.MinimumSize = new System.Drawing.Size(4, 40);
            this.course_tb.Name = "course_tb";
            this.course_tb.Size = new System.Drawing.Size(219, 40);
            this.course_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(0, 50);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.label3.Size = new System.Drawing.Size(194, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Course Name:";
            // 
            // reg_tb
            // 
            this.reg_tb.Dock = System.Windows.Forms.DockStyle.Top;
            this.reg_tb.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_tb.Location = new System.Drawing.Point(5, 162);
            this.reg_tb.Margin = new System.Windows.Forms.Padding(5);
            this.reg_tb.MinimumSize = new System.Drawing.Size(4, 40);
            this.reg_tb.Name = "reg_tb";
            this.reg_tb.Size = new System.Drawing.Size(219, 32);
            this.reg_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(0, 50);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(148, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Reg No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(225, 107);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 35, 5, 5);
            this.label1.Size = new System.Drawing.Size(225, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Student";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reload_Btn);
            this.panel2.Controls.Add(this.enrol_GV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 480);
            this.panel2.TabIndex = 0;
            // 
            // reload_Btn
            // 
            this.reload_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reload_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reload_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reload_Btn.Location = new System.Drawing.Point(393, 377);
            this.reload_Btn.Name = "reload_Btn";
            this.reload_Btn.Size = new System.Drawing.Size(146, 54);
            this.reload_Btn.TabIndex = 4;
            this.reload_Btn.Text = "Reload";
            this.reload_Btn.UseVisualStyleBackColor = false;
            // 
            // enrol_GV
            // 
            this.enrol_GV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enrol_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enrol_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.enrol_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrol_GV.Location = new System.Drawing.Point(68, 43);
            this.enrol_GV.Name = "enrol_GV";
            this.enrol_GV.RowHeadersWidth = 51;
            this.enrol_GV.RowTemplate.Height = 24;
            this.enrol_GV.Size = new System.Drawing.Size(471, 313);
            this.enrol_GV.TabIndex = 4;
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterStudent";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enrol_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regstu_Btn;
        private System.Windows.Forms.TextBox course_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reload_Btn;
        private System.Windows.Forms.DataGridView enrol_GV;
    }
}