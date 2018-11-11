using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
namespace Player_Profile
{ 
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=C:\Users\ravichandran\Documents\cricket.sdf";
            SqlCeConnection sqlCon = new SqlCeConnection { ConnectionString = conStr };
            sqlCon.Open();
            string sql = "Select * From login";
            SqlCeCommand myCommand = new SqlCeCommand(sql, sqlCon);
            int flag = 0;
            using (SqlCeDataReader myDataReader = myCommand.ExecuteReader())
            {

                while (myDataReader.Read())
                {
                    string usr  = myDataReader["username"].ToString();
                    string pass = myDataReader["password"].ToString();
                    if (textBox1.Text == usr && textBox2.Text == pass)
                        flag = 1;


                }


            }
            if (flag == 1)
            {
                this.Hide();
                MainMenu m = new MainMenu();
                m.Show();

                

            }
            else
            {
                MessageBox.Show("Username/Password Invalid");
            }

        }
    }
}
