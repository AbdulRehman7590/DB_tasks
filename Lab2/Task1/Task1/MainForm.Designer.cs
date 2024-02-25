namespace Task1
{
    partial class MainForm
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
            this.options_Panel = new System.Windows.Forms.Panel();
            this.registers_Btn = new System.Windows.Forms.Button();
            this.course_Panel = new System.Windows.Forms.Panel();
            this.addcourse_Btn = new System.Windows.Forms.Button();
            this.courseDetailsBtn = new System.Windows.Forms.Button();
            this.course_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.student_Panel = new System.Windows.Forms.Panel();
            this.addstudent_Btn = new System.Windows.Forms.Button();
            this.stuDetails_Btn = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            this.display_Panel = new System.Windows.Forms.Panel();
            this.options_Panel.SuspendLayout();
            this.course_Panel.SuspendLayout();
            this.student_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // options_Panel
            // 
            this.options_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.options_Panel.Controls.Add(this.registers_Btn);
            this.options_Panel.Controls.Add(this.course_Panel);
            this.options_Panel.Controls.Add(this.course_Btn);
            this.options_Panel.Controls.Add(this.exit_Btn);
            this.options_Panel.Controls.Add(this.student_Panel);
            this.options_Panel.Controls.Add(this.student_btn);
            this.options_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.options_Panel.Location = new System.Drawing.Point(0, 0);
            this.options_Panel.Name = "options_Panel";
            this.options_Panel.Size = new System.Drawing.Size(200, 546);
            this.options_Panel.TabIndex = 0;
            // 
            // registers_Btn
            // 
            this.registers_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registers_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.registers_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registers_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registers_Btn.Location = new System.Drawing.Point(0, 338);
            this.registers_Btn.Name = "registers_Btn";
            this.registers_Btn.Size = new System.Drawing.Size(200, 55);
            this.registers_Btn.TabIndex = 10;
            this.registers_Btn.Text = "Register";
            this.registers_Btn.UseVisualStyleBackColor = false;
            this.registers_Btn.Click += new System.EventHandler(this.registers_Btn_Click);
            // 
            // course_Panel
            // 
            this.course_Panel.Controls.Add(this.addcourse_Btn);
            this.course_Panel.Controls.Add(this.courseDetailsBtn);
            this.course_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_Panel.Location = new System.Drawing.Point(0, 224);
            this.course_Panel.Name = "course_Panel";
            this.course_Panel.Size = new System.Drawing.Size(200, 114);
            this.course_Panel.TabIndex = 9;
            // 
            // addcourse_Btn
            // 
            this.addcourse_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addcourse_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addcourse_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcourse_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addcourse_Btn.Location = new System.Drawing.Point(0, 55);
            this.addcourse_Btn.Name = "addcourse_Btn";
            this.addcourse_Btn.Size = new System.Drawing.Size(200, 55);
            this.addcourse_Btn.TabIndex = 2;
            this.addcourse_Btn.Text = "Add Course";
            this.addcourse_Btn.UseVisualStyleBackColor = false;
            this.addcourse_Btn.Click += new System.EventHandler(this.addcourse_Btn_Click);
            // 
            // courseDetailsBtn
            // 
            this.courseDetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.courseDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseDetailsBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDetailsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseDetailsBtn.Location = new System.Drawing.Point(0, 0);
            this.courseDetailsBtn.Name = "courseDetailsBtn";
            this.courseDetailsBtn.Size = new System.Drawing.Size(200, 55);
            this.courseDetailsBtn.TabIndex = 1;
            this.courseDetailsBtn.Text = "Course Details";
            this.courseDetailsBtn.UseVisualStyleBackColor = false;
            this.courseDetailsBtn.Click += new System.EventHandler(this.courseDetailsBtn_Click);
            // 
            // course_Btn
            // 
            this.course_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.course_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.course_Btn.Location = new System.Drawing.Point(0, 169);
            this.course_Btn.Name = "course_Btn";
            this.course_Btn.Size = new System.Drawing.Size(200, 55);
            this.course_Btn.TabIndex = 2;
            this.course_Btn.Text = "Courses";
            this.course_Btn.UseVisualStyleBackColor = false;
            this.course_Btn.Click += new System.EventHandler(this.course_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.exit_Btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_Btn.Location = new System.Drawing.Point(0, 491);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(200, 55);
            this.exit_Btn.TabIndex = 6;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = false;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // student_Panel
            // 
            this.student_Panel.Controls.Add(this.addstudent_Btn);
            this.student_Panel.Controls.Add(this.stuDetails_Btn);
            this.student_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_Panel.Location = new System.Drawing.Point(0, 55);
            this.student_Panel.Name = "student_Panel";
            this.student_Panel.Size = new System.Drawing.Size(200, 114);
            this.student_Panel.TabIndex = 8;
            // 
            // addstudent_Btn
            // 
            this.addstudent_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addstudent_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addstudent_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudent_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addstudent_Btn.Location = new System.Drawing.Point(0, 55);
            this.addstudent_Btn.Name = "addstudent_Btn";
            this.addstudent_Btn.Size = new System.Drawing.Size(200, 55);
            this.addstudent_Btn.TabIndex = 2;
            this.addstudent_Btn.Text = "Add Student";
            this.addstudent_Btn.UseVisualStyleBackColor = false;
            this.addstudent_Btn.Click += new System.EventHandler(this.addstudent_Btn_Click_1);
            // 
            // stuDetails_Btn
            // 
            this.stuDetails_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stuDetails_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stuDetails_Btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuDetails_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stuDetails_Btn.Location = new System.Drawing.Point(0, 0);
            this.stuDetails_Btn.Name = "stuDetails_Btn";
            this.stuDetails_Btn.Size = new System.Drawing.Size(200, 55);
            this.stuDetails_Btn.TabIndex = 1;
            this.stuDetails_Btn.Text = "Details";
            this.stuDetails_Btn.UseVisualStyleBackColor = false;
            this.stuDetails_Btn.Click += new System.EventHandler(this.stuDetails_Btn_Click);
            // 
            // student_btn
            // 
            this.student_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.student_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.student_btn.Location = new System.Drawing.Point(0, 0);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(200, 55);
            this.student_btn.TabIndex = 1;
            this.student_btn.Text = "Students";
            this.student_btn.UseVisualStyleBackColor = false;
            this.student_btn.Click += new System.EventHandler(this.student_btn_Click);
            // 
            // display_Panel
            // 
            this.display_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.display_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_Panel.Location = new System.Drawing.Point(200, 0);
            this.display_Panel.Name = "display_Panel";
            this.display_Panel.Size = new System.Drawing.Size(782, 546);
            this.display_Panel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 546);
            this.Controls.Add(this.display_Panel);
            this.Controls.Add(this.options_Panel);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.options_Panel.ResumeLayout(false);
            this.course_Panel.ResumeLayout(false);
            this.student_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel options_Panel;
        private System.Windows.Forms.Button stuDetails_Btn;
        private System.Windows.Forms.Button student_btn;
        private System.Windows.Forms.Panel display_Panel;
        private System.Windows.Forms.Button exit_Btn;
        private System.Windows.Forms.Panel student_Panel;
        private System.Windows.Forms.Button addstudent_Btn;
        private System.Windows.Forms.Button course_Btn;
        private System.Windows.Forms.Button registers_Btn;
        private System.Windows.Forms.Panel course_Panel;
        private System.Windows.Forms.Button addcourse_Btn;
        private System.Windows.Forms.Button courseDetailsBtn;
    }
}

