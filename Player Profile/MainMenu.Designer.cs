namespace Player_Profile
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.vIEWPLAYERPROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTNEWPLAYERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEPLAYERDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEPLAYERPROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWPLAYERPROFILEToolStripMenuItem,
            this.iNSERTNEWPLAYERToolStripMenuItem,
            this.uPDATEPLAYERDETAILSToolStripMenuItem,
            this.dELETEPLAYERPROFILEToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(654, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(319, 354);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // vIEWPLAYERPROFILEToolStripMenuItem
            // 
            this.vIEWPLAYERPROFILEToolStripMenuItem.Name = "vIEWPLAYERPROFILEToolStripMenuItem";
            this.vIEWPLAYERPROFILEToolStripMenuItem.Size = new System.Drawing.Size(306, 29);
            this.vIEWPLAYERPROFILEToolStripMenuItem.Text = "VIEW PLAYER PROFILE";
            this.vIEWPLAYERPROFILEToolStripMenuItem.Click += new System.EventHandler(this.vIEWPLAYERPROFILEToolStripMenuItem_Click);
            // 
            // iNSERTNEWPLAYERToolStripMenuItem
            // 
            this.iNSERTNEWPLAYERToolStripMenuItem.Name = "iNSERTNEWPLAYERToolStripMenuItem";
            this.iNSERTNEWPLAYERToolStripMenuItem.Size = new System.Drawing.Size(306, 29);
            this.iNSERTNEWPLAYERToolStripMenuItem.Text = "INSERT NEW PLAYER";
            this.iNSERTNEWPLAYERToolStripMenuItem.Click += new System.EventHandler(this.iNSERTNEWPLAYERToolStripMenuItem_Click);
            // 
            // uPDATEPLAYERDETAILSToolStripMenuItem
            // 
            this.uPDATEPLAYERDETAILSToolStripMenuItem.Name = "uPDATEPLAYERDETAILSToolStripMenuItem";
            this.uPDATEPLAYERDETAILSToolStripMenuItem.Size = new System.Drawing.Size(306, 29);
            this.uPDATEPLAYERDETAILSToolStripMenuItem.Text = "UPDATE PLAYER DETAILS";
            this.uPDATEPLAYERDETAILSToolStripMenuItem.Click += new System.EventHandler(this.uPDATEPLAYERDETAILSToolStripMenuItem_Click);
            // 
            // dELETEPLAYERPROFILEToolStripMenuItem
            // 
            this.dELETEPLAYERPROFILEToolStripMenuItem.Name = "dELETEPLAYERPROFILEToolStripMenuItem";
            this.dELETEPLAYERPROFILEToolStripMenuItem.Size = new System.Drawing.Size(306, 29);
            this.dELETEPLAYERPROFILEToolStripMenuItem.Text = "DELETE PLAYER PROFILE";
            this.dELETEPLAYERPROFILEToolStripMenuItem.Click += new System.EventHandler(this.dELETEPLAYERPROFILEToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 354);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem vIEWPLAYERPROFILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTNEWPLAYERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEPLAYERDETAILSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEPLAYERPROFILEToolStripMenuItem;


    }
}