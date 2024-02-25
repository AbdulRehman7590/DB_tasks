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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1.GUI
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Add_Student_Btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@RegistrationNumber, @Name, @Department, @Session, @Address)", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", reg_txt.Text);
            cmd.Parameters.AddWithValue("@Name", name_txt.Text);
            cmd.Parameters.AddWithValue("@Department", dept_txt.Text);
            cmd.Parameters.AddWithValue("@Session", session_txt.Text);
            cmd.Parameters.AddWithValue("@Address", address_txt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

    }
}
