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

namespace Task1.GUI
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void Add_Course_Btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Course values (@Course_ID, @Course_Name, @Student_Name, @Teacher_Name, @Semester)", con);
            cmd.Parameters.AddWithValue("@Course_ID", CourseID_txt.Text);
            cmd.Parameters.AddWithValue("@Course_Name", courseName_txt.Text);
            cmd.Parameters.AddWithValue("@Student_Name", studentName_txt.Text);
            cmd.Parameters.AddWithValue("@Teacher_Name", teacherName_txt.Text);
            cmd.Parameters.AddWithValue("@Semester", semester_txt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }
    }
}
