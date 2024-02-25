using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            student_Panel.Visible = false;
            course_Panel.Visible = false;
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            student_Panel.Visible = true;
            course_Panel.Visible = false;
        }
        private void stuDetails_Btn_Click(object sender, EventArgs e)
        {
            ViewContent stud = new ViewContent(true);
            Mutual.Set_Form(stud, display_Panel);
        }
        private void addstudent_Btn_Click_1(object sender, EventArgs e)
        {
            AddStudent stud = new AddStudent();
            Mutual.Set_Form(stud, display_Panel);
        }


        private void course_Btn_Click(object sender, EventArgs e)
        {
            student_Panel.Visible = false;
            course_Panel.Visible = true;
        }
        private void courseDetailsBtn_Click(object sender, EventArgs e)
        {
            ViewContent stud = new ViewContent(false);
            Mutual.Set_Form(stud, display_Panel);
        }
        private void addcourse_Btn_Click(object sender, EventArgs e)
        {
            AddCourse stud = new AddCourse();
            Mutual.Set_Form(stud, display_Panel);
        }
        

        private void registers_Btn_Click(object sender, EventArgs e)
        {
            student_Panel.Visible = false;
            course_Panel.Visible = false;
            RegisterStudent stud = new RegisterStudent();
            Mutual.Set_Form(stud, display_Panel);
        }

    }
}
