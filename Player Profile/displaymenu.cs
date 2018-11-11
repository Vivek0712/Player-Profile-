using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
namespace Player_Profile
{
    public partial class displaymenu : Form
    {
        String conStr;
        SqlCeConnection sqlCon;
        public displaymenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void label8_Click(object sender, EventArgs e)
        {
        
        }
        
       /* private void button1_Click(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            int i = comboBox1.SelectedIndex;
            i = i + 1;
            string sql = "Select * From cricket where pid=" +i +"";
            SqlCeCommand myCommand = new SqlCeCommand(sql, sqlCon);
            using (SqlCeDataReader myDataReader = myCommand.ExecuteReader())
            {

                while (myDataReader.Read())
                {
                    pid.Text = myDataReader["pid"].ToString();
                    pname.Text = myDataReader["pname"].ToString();
                    nationality.Text = myDataReader["nationality"].ToString();
                    type.Text = myDataReader["type"].ToString();
                    matches.Text = myDataReader["matches"].ToString();
                    runs.Text = myDataReader["runs"].ToString();
                    wickets.Text = myDataReader["wickets"].ToString();
                    progressBar1.Value = int.Parse(myDataReader["batrate"].ToString());
                    progressBar2.Value = int.Parse(myDataReader["bowlrate"].ToString());
                    progressBar3.Value = int.Parse(myDataReader["overallrate"].ToString());
                    pictureBox1.ImageLocation =(myDataReader["image"]).ToString();


                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            string sql = "Insert Into cricket(pid, pname, nationality, type,matches,runs,wickets) Values(@pid, @pname, @nationality, @type, @matches, @runs, @wickets)";
            // This command will have internal parameters.  
            using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
            {
                // Fill params collection.    
                SqlCeParameter parameter = new SqlCeParameter
                {
                    ParameterName = "@pid",
                    Value = pid.Text,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);

                parameter = new SqlCeParameter
                {
                    ParameterName = "@pname",
                    Value = pname.Text,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlCeParameter
                {
                    ParameterName = "@nationality",
                    Value = nationality.Text,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@type",
                    Value = type.Text,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 10
                };
                command.Parameters.Add(parameter);

               parameter = new SqlCeParameter
                {
                    ParameterName = "@wickets",
                    Value = wickets.Text,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@matches",
                    Value = matches.Text,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@runs",
                    Value = runs.Text,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
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
                        Value = pid.Text,
                        SqlDbType = SqlDbType.Int
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("Sorry! No player found ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            string sql = "Update cricket Set runs = @runs Where pid = @pid";
            using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
            {
				SqlCeParameter parameter = new SqlCeParameter
					{
						ParameterName = "@PId",
						Value = pid.Text,
						SqlDbType = SqlDbType.Int
					};
					command.Parameters.Add(parameter);
					parameter = new SqlCeParameter
					{
						ParameterName = "@runs",
						Value =runs.Text,
						SqlDbType = SqlDbType.Int
						
					};
					command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
            }
        }
        */
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            int i = comboBox1.SelectedIndex;
            i = i + 1;
            string sql = "Select * From cricket where pid=" + i + "";
            SqlCeCommand myCommand = new SqlCeCommand(sql, sqlCon);
            using (SqlCeDataReader myDataReader = myCommand.ExecuteReader())
            {

                while (myDataReader.Read())
                {
                    pid.Text = myDataReader["pid"].ToString();
                    pname.Text = myDataReader["pname"].ToString();
                    nationality.Text = myDataReader["nationality"].ToString();
                    type.Text = myDataReader["type"].ToString();
                    matches.Text = myDataReader["matches"].ToString();
                    runs.Text = myDataReader["runs"].ToString();
                    wickets.Text = myDataReader["wickets"].ToString();
                    progressBar1.Value = int.Parse(myDataReader["batrate"].ToString());
                    progressBar2.Value = int.Parse(myDataReader["bowlrate"].ToString());
                    progressBar3.Value = int.Parse(myDataReader["overallrate"].ToString());
                    pictureBox1.ImageLocation = (myDataReader["image"]).ToString();


                }


            }
        }

        
    
    }
	
 
}
