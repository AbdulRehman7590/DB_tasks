namespace Task1.GUI
{
    partial class AddCourse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.semester_txt = new System.Windows.Forms.TextBox();
            this.teacherName_txt = new System.Windows.Forms.TextBox();
            this.studentName_txt = new System.Windows.Forms.TextBox();
            this.courseName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseID_txt = new System.Windows.Forms.TextBox();
            this.Add_Course_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.semester_txt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.teacherName_txt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.studentName_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.courseName_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CourseID_txt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // semester_txt
            // 
            this.semester_txt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_txt.Location = new System.Drawing.Point(256, 255);
            this.semester_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.semester_txt.MinimumSize = new System.Drawing.Size(240, 30);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(240, 27);
            this.semester_txt.TabIndex = 5;
            // 
            // teacherName_txt
            // 
            this.teacherName_txt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherName_txt.Location = new System.Drawing.Point(256, 195);
            this.teacherName_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.teacherName_txt.MinimumSize = new System.Drawing.Size(240, 30);
            this.teacherName_txt.Name = "teacherName_txt";
            this.teacherName_txt.Size = new System.Drawing.Size(240, 27);
            this.teacherName_txt.TabIndex = 4;
            // 
            // studentName_txt
            // 
            this.studentName_txt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_txt.Location = new System.Drawing.Point(256, 135);
            this.studentName_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.studentName_txt.MinimumSize = new System.Drawing.Size(240, 30);
            this.studentName_txt.Name = "studentName_txt";
            this.studentName_txt.Size = new System.Drawing.Size(240, 27);
            this.studentName_txt.TabIndex = 3;
            // 
            // courseName_txt
            // 
            this.courseName_txt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName_txt.Location = new System.Drawing.Point(256, 75);
            this.courseName_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.courseName_txt.MinimumSize = new System.Drawing.Size(240, 30);
            this.courseName_txt.Name = "courseName_txt";
            this.courseName_txt.Size = new System.Drawing.Size(240, 27);
            this.courseName_txt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(40, 20, 20, 0);
            this.label5.Size = new System.Drawing.Size(247, 60);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter Teacher Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(40, 20, 20, 0);
            this.label4.Size = new System.Drawing.Size(247, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 20, 20, 0);
            this.label3.Size = new System.Drawing.Size(247, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 20, 20, 0);
            this.label2.Size = new System.Drawing.Size(247, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 20, 20, 0);
            this.label1.Size = new System.Drawing.Size(247, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Course ID:";
            // 
            // CourseID_txt
            // 
            this.CourseID_txt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID_txt.Location = new System.Drawing.Point(256, 15);
            this.CourseID_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.CourseID_txt.MinimumSize = new System.Drawing.Size(240, 30);
            this.CourseID_txt.Name = "CourseID_txt";
            this.CourseID_txt.Size = new System.Drawing.Size(240, 27);
            this.CourseID_txt.TabIndex = 1;
            // 
            // Add_Course_Btn
            // 
            this.Add_Course_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Course_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add_Course_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Course_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Course_Btn.Location = new System.Drawing.Point(476, 367);
            this.Add_Course_Btn.Name = "Add_Course_Btn";
            this.Add_Course_Btn.Size = new System.Drawing.Size(163, 43);
            this.Add_Course_Btn.TabIndex = 6;
            this.Add_Course_Btn.Text = "Add Course";
            this.Add_Course_Btn.UseVisualStyleBackColor = false;
            this.Add_Course_Btn.Click += new System.EventHandler(this.Add_Course_Btn_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_Course_Btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Course_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CourseID_txt;
        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.TextBox teacherName_txt;
        private System.Windows.Forms.TextBox studentName_txt;
        private System.Windows.Forms.TextBox courseName_txt;
    }
}