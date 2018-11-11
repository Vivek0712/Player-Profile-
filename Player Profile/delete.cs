using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Player_Profile
{
    

    public partial class delete : Form
    {
        string conStr="";
        SqlCeConnection sqlCon;
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            string sql = "Select * From cricket";
            SqlCeCommand myCommand = new SqlCeCommand(sql, sqlCon);
            using (SqlCeDataReader myDataReader = myCommand.ExecuteReader())
            {

                while (myDataReader.Read())
                {
                    comboBox1.Items.Add(myDataReader["pname"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open(); 
            string sql = "Delete from cricket where pid=@PId";
            using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
            {
                try
                {
                    SqlCeParameter parameter = new SqlCeParameter
                    {
                        ParameterName = "@PId",
                        Value = comboBox1.SelectedIndex + 1,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    int j = command.ExecuteNonQuery();
                    if (j == 1)
                        MessageBox.Show("Deleted Successfully");
                    else
                        MessageBox.Show("Sorry! No player found ");
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("Sorry! No player found ");
                }
            }
        }
    }
}
