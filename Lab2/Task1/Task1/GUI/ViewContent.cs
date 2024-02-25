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
    public partial class ViewContent : Form
    {
        bool isStudnt;
        public ViewContent(bool isStudent)
        {
            this.isStudnt = isStudent;
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            display_GV.DataSource = null;
            
            if (isStudnt)
            {
                search_Label.Text = "Enter RegNo. :";
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Student", con);
                Mutual.show_table_data(display_GV, cmd);
            }
            else
            {
                search_Label.Text = "Enter Course_ID : ";
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Course", con);
                Mutual.show_table_data(display_GV, cmd);
            }
            AddDelButton();
        }

        private void AddDelButton()
        {
            DataGridViewButtonColumn button = Mutual.GV_AddButton("Delete", "Gv_Del_Btn");
            display_GV.Columns.Add(button);
            display_GV.CellContentClick += GV_Del_CellContentClick;
        }
        private void GV_Del_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (display_GV.SelectedCells[0].ColumnIndex == display_GV.Columns["Gv_Del_Btn"].Index)
            {
                if (isStudnt)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE CONVERT(nvarchar(max), RegisterationNumber) = @RegisterationNumber", con);
                    cmd.Parameters.Add("@RegisterationNumber", SqlDbType.NVarChar, -1).Value = display_GV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE CONVERT(nvarchar(max), Course_ID) = @Course_ID", con);
                    cmd.Parameters.Add("@Course_ID", SqlDbType.NVarChar, -1).Value = display_GV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (isStudnt)
            {
                if (search_Txt.Text == "")
                {
                    MessageBox.Show("Please Enter RegNo. !!!");
                }
                else
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE CONVERT(nvarchar(max), RegisterationNumber) = @RegisterationNumber", con);
                    cmd.Parameters.Add("@RegisterationNumber", SqlDbType.NVarChar, -1).Value = search_Txt.Text;
                    Mutual.show_table_data(display_GV, cmd);
                }
            }
            else
            {
                if (search_Txt.Text == "")
                {
                    MessageBox.Show("Please Enter RegNo. !!!");
                }
                else
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE CONVERT(nvarchar(max), Course_ID) = @Course_ID", con);
                    cmd.Parameters.Add("@Course_ID", SqlDbType.NVarChar, -1).Value = search_Txt.Text;
                    Mutual.show_table_data(display_GV, cmd);
                }
            }
        }

        
    }
}
