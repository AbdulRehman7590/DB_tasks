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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void regstu_Btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Enrollments values (@StudentRegNo, @CourseName)", con);
            cmd.Parameters.AddWithValue("@StudentRegNo", reg_tb.Text);
            cmd.Parameters.AddWithValue("@CourseName", course_tb.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            reload_Btn_Click(sender, e);
            AddunregisterButton();
        }

        private void AddunregisterButton()
        {
            DataGridViewButtonColumn button = Mutual.GV_AddButton("Delete", "Gv_Del_Btn");
            enrol_GV.Columns.Add(button);
            enrol_GV.CellContentClick += GV_unreg_CellContentClick;
        }
        private void GV_unreg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (enrol_GV.SelectedCells[0].ColumnIndex == enrol_GV.Columns["Gv_Del_Btn"].Index)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Enrollments WHERE CONVERT(nvarchar(max), StudentRegNo) = @StudentRegNo", con);
                cmd.Parameters.Add("@StudentRegNo", SqlDbType.NVarChar, -1).Value = enrol_GV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student unregistered");
            }
        }

        private void reload_Btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Enrollments", con);
            Mutual.show_table_data(enrol_GV, cmd);
        }

    }
}
