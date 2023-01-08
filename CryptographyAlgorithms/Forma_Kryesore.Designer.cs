namespace CryptographyAlgorithms
{
    partial class FormaStartuese
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Algoritmi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Elgamal_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GjenerimiQelesave_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Enkriptimi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Dekriptimi_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.info_toolstrip_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.rreth_algoritmit_toolstripmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Algoritmi_toolstrip_menu,
            this.info_toolstrip_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Algoritmi_toolstrip_menu
            // 
            this.Algoritmi_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Elgamal_toolstrip_menu});
            this.Algoritmi_toolstrip_menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Algoritmi_toolstrip_menu.Name = "Algoritmi_toolstrip_menu";
            this.Algoritmi_toolstrip_menu.Size = new System.Drawing.Size(145, 40);
            this.Algoritmi_toolstrip_menu.Text = "Algorithm";
            // 
            // Elgamal_toolstrip_menu
            // 
            this.Elgamal_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GjenerimiQelesave_toolstrip_menu,
            this.Enkriptimi_toolstrip_menu,
            this.Dekriptimi_toolstrip_menu});
            this.Elgamal_toolstrip_menu.Name = "Elgamal_toolstrip_menu";
            this.Elgamal_toolstrip_menu.Size = new System.Drawing.Size(270, 44);
            this.Elgamal_toolstrip_menu.Text = "ElGamal";
            this.Elgamal_toolstrip_menu.Click += new System.EventHandler(this.ElGamalToolStripMenuItem_Click);
            // 
            // GjenerimiQelesave_toolstrip_menu
            // 
            this.GjenerimiQelesave_toolstrip_menu.Name = "GjenerimiQelesave_toolstrip_menu";
            this.GjenerimiQelesave_toolstrip_menu.Size = new System.Drawing.Size(286, 44);
            this.GjenerimiQelesave_toolstrip_menu.Text = "Generate Keys";
            this.GjenerimiQelesave_toolstrip_menu.Click += new System.EventHandler(this.EGKeyGenerationToolStripMenuItem_Click);
            // 
            // Enkriptimi_toolstrip_menu
            // 
            this.Enkriptimi_toolstrip_menu.Name = "Enkriptimi_toolstrip_menu";
            this.Enkriptimi_toolstrip_menu.Size = new System.Drawing.Size(286, 44);
            this.Enkriptimi_toolstrip_menu.Text = "Encryption";
            this.Enkriptimi_toolstrip_menu.Click += new System.EventHandler(this.EGEncryptionToolStripMenuItem_Click);
            // 
            // Dekriptimi_toolstrip_menu
            // 
            this.Dekriptimi_toolstrip_menu.Name = "Dekriptimi_toolstrip_menu";
            this.Dekriptimi_toolstrip_menu.Size = new System.Drawing.Size(286, 44);
            this.Dekriptimi_toolstrip_menu.Text = "Decryption";
            this.Dekriptimi_toolstrip_menu.Click += new System.EventHandler(this.EGDecryptionToolStripMenuItem_Click);
            // 
            // info_toolstrip_menu
            // 
            this.info_toolstrip_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rreth_algoritmit_toolstripmenu});
            this.info_toolstrip_menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.info_toolstrip_menu.Name = "info_toolstrip_menu";
            this.info_toolstrip_menu.Size = new System.Drawing.Size(76, 40);
            this.info_toolstrip_menu.Text = "Info";
            // 
            // rreth_algoritmit_toolstripmenu
            // 
            this.rreth_algoritmit_toolstripmenu.Name = "rreth_algoritmit_toolstripmenu";
            this.rreth_algoritmit_toolstripmenu.Size = new System.Drawing.Size(348, 44);
            this.rreth_algoritmit_toolstripmenu.Text = "ElGamal Description";
            this.rreth_algoritmit_toolstripmenu.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // FormaStartuese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CryptographyAlgorithms.Properties.Resources.ElGamal_Encryption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 258);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormaStartuese";
            this.Opacity = 0.9D;
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Algoritmi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Elgamal_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem GjenerimiQelesave_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Enkriptimi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem Dekriptimi_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem info_toolstrip_menu;
        private System.Windows.Forms.ToolStripMenuItem rreth_algoritmit_toolstripmenu;
    }
}