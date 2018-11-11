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
    public partial class update : Form
    {
        String conStr;
        SqlCeConnection sqlCon;
        SqlCeCommand command;
        string sql;
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Matches" :

                    sql = "update cricket set matches =" + textBox1.Text+ " where pname = " + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); };
                        MessageBox.Show("Updated Successfully");
                    }
                    break;

                case "Runs":
                    sql = "update cricket set runs =" + textBox1.Text + " where pname = " + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); };
                        MessageBox.Show("Updated Successfully");
                    }
                    break;
                case "Batting Rating":
                    sql = "update cricket set batrat =" + textBox1.Text + " where pname =" + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); };
                        MessageBox.Show("Updated Successfully");
                    }
                        break;

                case "Wickets":
                    sql = "update cricket set wickets =" + textBox1.Text + " where pname = " + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); }
                        MessageBox.Show("Updated Successfully");
                    }
                    break;

                case "Bowling Rating":
                    sql = "update cricket set bowlrat =" + textBox1.Text + " where pname = " + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); }
                        MessageBox.Show("Updated Successfully");
                    }
                       break;

                case "Overall Rating":
                    sql = "update cricket set overallrat =" + textBox1.Text + " where pname = " + comboBox1.Text + "";
                    using (SqlCeCommand command = new SqlCeCommand(sql, sqlCon))
                    {
                        try { command.ExecuteNonQuery(); }
                        catch (SqlCeException exc) { MessageBox.Show("error"); };
                        MessageBox.Show("Updated Successfully");
                    }
                        break;
                        
            }
            
        }

        private void update_Load(object sender, EventArgs e)
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
    }
}
