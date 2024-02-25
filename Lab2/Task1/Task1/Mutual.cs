using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    internal class Mutual
    {
        public static void Set_Form(Form name, Panel p_name)
        {
            name.TopLevel = false;
            name.FormBorderStyle = FormBorderStyle.None;
            name.Dock = DockStyle.Fill;
            p_name.Controls.Add(name);
            p_name.Tag = name;
            name.BringToFront();
            name.Show();
        }

        public static DataGridViewButtonColumn GV_AddButton(string headingname, string name)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            buttonColumn.HeaderText = headingname;
            buttonColumn.Text = headingname;
            buttonColumn.UseColumnTextForButtonValue = true;

            buttonColumn.Name = name;

            return buttonColumn;
        }

        public static void show_table_data(DataGridView GV, SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GV.DataSource = dt;
        }
    }
}
