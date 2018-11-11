using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player_Profile
{
    public partial class MainMenu : Form
    {
        displaymenu d;
        public MainMenu()
        {
            InitializeComponent();
           
        }

       
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
           
        }

       

        private void vIEWPLAYERPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displaymenu d = new displaymenu();
            d.Show();
            d.MdiParent = this;
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized; 
        }

        private void uPDATEPLAYERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update u = new update();
            u.Show();
            u.MdiParent = this;
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized; 
            
        }

        private void iNSERTNEWPLAYERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insert i = new insert();
            i.Show();
            i.MdiParent = this;
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized; 
        }

        private void dELETEPLAYERPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete d = new delete();
            d.Show();
            d.MdiParent = this;
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized; 
        }
    }
}
