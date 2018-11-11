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
    public partial class insert : Form
    {
        string imgpath = "";
        public insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            DialogResult dr = o.ShowDialog();
            if (dr == DialogResult.OK)
            {
               imgpath = o.FileName;
            }
        }

       

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            SqlCeConnection sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            string sql = "Insert Into cricket(pid, pname, nationality, type,matches,runs,wickets,batrate,bowlrate,overallrate, image) Values(@pid, @pname, @nationality, @type, @matches, @runs, @wickets,@batrate,@bowlrate,@overallrate,@image)";
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
                    
                };
                command.Parameters.Add(parameter);

                parameter = new SqlCeParameter
                {
                    ParameterName = "@nationality",
                    Value = nationality.Text,
                    SqlDbType = SqlDbType.NVarChar,
                   
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@type",
                    Value = type.Text,
                    SqlDbType = SqlDbType.NVarChar,
                   
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
                parameter = new SqlCeParameter
                {
                    ParameterName = "@batrate",
                    Value = trackBar1.Value,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@bowlrate",
                    Value = trackBar2.Value,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@overallrate",
                    Value = trackBar3.Value,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                parameter = new SqlCeParameter
                {
                    ParameterName = "@image",
                    Value = imgpath,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);

                try { command.ExecuteNonQuery(); }
                catch (SqlCeException exc ) { MessageBox.Show("error"); };
                MessageBox.Show("Inserted Successfully");
            } 
        }
    }
}
