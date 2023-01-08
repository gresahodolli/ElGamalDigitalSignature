namespace CryptographyAlgorithms
{
    partial class Elgamal_Gjenerimi_Qelesave
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
            this.txtbox_Numri_Thjeshte = new System.Windows.Forms.TextBox();
            this.LabelSimpleNumber = new System.Windows.Forms.Label();
            this.LabelPrimitiveRootOfTheSimpleNumber = new System.Windows.Forms.Label();
            this.txtbox_Rrenja_Primitive_NumritThjesht = new System.Windows.Forms.TextBox();
            this.LabelAnySimpleNumber = new System.Windows.Forms.Label();
            this.txtbox_NumriThjeshte_Randomt = new System.Windows.Forms.TextBox();
            this.lbl_QelesiPublik = new System.Windows.Forms.Label();
            this.lbl_Qelesi_Sekret = new System.Windows.Forms.Label();
            this.LabelPublicKeyOutput = new System.Windows.Forms.Label();
            this.LabelSecretKeyOutput = new System.Windows.Forms.Label();
            this.Kalkulo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elGamalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutCryptographyAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_Numri_Thjeshte
            // 
            this.txtbox_Numri_Thjeshte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Numri_Thjeshte.Location = new System.Drawing.Point(18, 197);
            this.txtbox_Numri_Thjeshte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_Numri_Thjeshte.Name = "txtbox_Numri_Thjeshte";
            this.txtbox_Numri_Thjeshte.Size = new System.Drawing.Size(412, 40);
            this.txtbox_Numri_Thjeshte.TabIndex = 0;
            // 
            // LabelSimpleNumber
            // 
            this.LabelSimpleNumber.AutoSize = true;
            this.LabelSimpleNumber.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.LabelSimpleNumber.Location = new System.Drawing.Point(18, 138);
            this.LabelSimpleNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSimpleNumber.Name = "LabelSimpleNumber";
            this.LabelSimpleNumber.Size = new System.Drawing.Size(413, 35);
            this.LabelSimpleNumber.TabIndex = 1;
            this.LabelSimpleNumber.Text = "Select a prime number (p):";
            // 
            // LabelPrimitiveRootOfTheSimpleNumber
            // 
            this.LabelPrimitiveRootOfTheSimpleNumber.AutoSize = true;
            this.LabelPrimitiveRootOfTheSimpleNumber.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.LabelPrimitiveRootOfTheSimpleNumber.Location = new System.Drawing.Point(18, 272);
            this.LabelPrimitiveRootOfTheSimpleNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPrimitiveRootOfTheSimpleNumber.Name = "LabelPrimitiveRootOfTheSimpleNumber";
            this.LabelPrimitiveRootOfTheSimpleNumber.Size = new System.Drawing.Size(446, 35);
            this.LabelPrimitiveRootOfTheSimpleNumber.TabIndex = 2;
            this.LabelPrimitiveRootOfTheSimpleNumber.Text = "Find a primitive root (g) of p:";
            // 
            // txtbox_Rrenja_Primitive_NumritThjesht
            // 
            this.txtbox_Rrenja_Primitive_NumritThjesht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Rrenja_Primitive_NumritThjesht.Location = new System.Drawing.Point(18, 332);
            this.txtbox_Rrenja_Primitive_NumritThjesht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_Rrenja_Primitive_NumritThjesht.Name = "txtbox_Rrenja_Primitive_NumritThjesht";
            this.txtbox_Rrenja_Primitive_NumritThjesht.Size = new System.Drawing.Size(412, 40);
            this.txtbox_Rrenja_Primitive_NumritThjesht.TabIndex = 3;
            // 
            // LabelAnySimpleNumber
            // 
            this.LabelAnySimpleNumber.AutoSize = true;
            this.LabelAnySimpleNumber.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.LabelAnySimpleNumber.Location = new System.Drawing.Point(18, 403);
            this.LabelAnySimpleNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAnySimpleNumber.Name = "LabelAnySimpleNumber";
            this.LabelAnySimpleNumber.Size = new System.Drawing.Size(827, 35);
            this.LabelAnySimpleNumber.TabIndex = 4;
            this.LabelAnySimpleNumber.Text = "Choose a random integer (a) as private key (1<a<p-1):";
            // 
            // txtbox_NumriThjeshte_Randomt
            // 
            this.txtbox_NumriThjeshte_Randomt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NumriThjeshte_Randomt.Location = new System.Drawing.Point(18, 472);
            this.txtbox_NumriThjeshte_Randomt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_NumriThjeshte_Randomt.Name = "txtbox_NumriThjeshte_Randomt";
            this.txtbox_NumriThjeshte_Randomt.Size = new System.Drawing.Size(412, 40);
            this.txtbox_NumriThjeshte_Randomt.TabIndex = 5;
            // 
            // lbl_QelesiPublik
            // 
            this.lbl_QelesiPublik.AutoSize = true;
            this.lbl_QelesiPublik.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbl_QelesiPublik.Location = new System.Drawing.Point(18, 666);
            this.lbl_QelesiPublik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QelesiPublik.Name = "lbl_QelesiPublik";
            this.lbl_QelesiPublik.Size = new System.Drawing.Size(175, 35);
            this.lbl_QelesiPublik.TabIndex = 6;
            this.lbl_QelesiPublik.Text = "Public key:";
            // 
            // lbl_Qelesi_Sekret
            // 
            this.lbl_Qelesi_Sekret.AutoSize = true;
            this.lbl_Qelesi_Sekret.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbl_Qelesi_Sekret.Location = new System.Drawing.Point(18, 754);
            this.lbl_Qelesi_Sekret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Qelesi_Sekret.Name = "lbl_Qelesi_Sekret";
            this.lbl_Qelesi_Sekret.Size = new System.Drawing.Size(188, 35);
            this.lbl_Qelesi_Sekret.TabIndex = 7;
            this.lbl_Qelesi_Sekret.Text = "Private key:";
            // 
            // LabelPublicKeyOutput
            // 
            this.LabelPublicKeyOutput.AutoSize = true;
            this.LabelPublicKeyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPublicKeyOutput.Location = new System.Drawing.Point(309, 688);
            this.LabelPublicKeyOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPublicKeyOutput.Name = "LabelPublicKeyOutput";
            this.LabelPublicKeyOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPublicKeyOutput.Size = new System.Drawing.Size(0, 33);
            this.LabelPublicKeyOutput.TabIndex = 8;
            // 
            // LabelSecretKeyOutput
            // 
            this.LabelSecretKeyOutput.AutoSize = true;
            this.LabelSecretKeyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecretKeyOutput.Location = new System.Drawing.Point(309, 722);
            this.LabelSecretKeyOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSecretKeyOutput.Name = "LabelSecretKeyOutput";
            this.LabelSecretKeyOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelSecretKeyOutput.Size = new System.Drawing.Size(0, 33);
            this.LabelSecretKeyOutput.TabIndex = 9;
            // 
            // Kalkulo
            // 
            this.Kalkulo.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.Kalkulo.Location = new System.Drawing.Point(18, 552);
            this.Kalkulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Kalkulo.Name = "Kalkulo";
            this.Kalkulo.Size = new System.Drawing.Size(414, 62);
            this.Kalkulo.TabIndex = 10;
            this.Kalkulo.Text = "Generate";
            this.Kalkulo.UseVisualStyleBackColor = true;
            this.Kalkulo.Click += new System.EventHandler(this.ButtonСalculate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlgorithmToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 36);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AlgorithmToolStripMenuItem
            // 
            this.AlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elGamalToolStripMenuItem});
            this.AlgorithmToolStripMenuItem.Name = "AlgorithmToolStripMenuItem";
            this.AlgorithmToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.AlgorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // elGamalToolStripMenuItem
            // 
            this.elGamalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyGenerationToolStripMenuItem,
            this.EncryptionToolStripMenuItem,
            this.DecryptionToolStripMenuItem});
            this.elGamalToolStripMenuItem.Name = "elGamalToolStripMenuItem";
            this.elGamalToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.elGamalToolStripMenuItem.Text = "ElGamal";
            // 
            // KeyGenerationToolStripMenuItem
            // 
            this.KeyGenerationToolStripMenuItem.Name = "KeyGenerationToolStripMenuItem";
            this.KeyGenerationToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.KeyGenerationToolStripMenuItem.Text = "Generate Keys";
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.EncryptionToolStripMenuItem.Text = "Encryption";
            this.EncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // DecryptionToolStripMenuItem
            // 
            this.DecryptionToolStripMenuItem.Name = "DecryptionToolStripMenuItem";
            this.DecryptionToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.DecryptionToolStripMenuItem.Text = "Decryption";
            this.DecryptionToolStripMenuItem.Click += new System.EventHandler(this.DecryptionToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutCryptographyAlgorithmsToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(60, 32);
            this.InfoToolStripMenuItem.Text = "Info";
            // 
            // AboutCryptographyAlgorithmsToolStripMenuItem
            // 
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Name = "AboutCryptographyAlgorithmsToolStripMenuItem";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Text = "ElGamal Description";
            this.AboutCryptographyAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.AboutCryptographyAlgorithmsToolStripMenuItem_Click);
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.LabelNameForm.Location = new System.Drawing.Point(269, 53);
            this.LabelNameForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(278, 38);
            this.LabelNameForm.TabIndex = 14;
            this.LabelNameForm.Text = "Generate Keys";
            // 
            // Elgamal_Gjenerimi_Qelesave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(888, 840);
            this.Controls.Add(this.LabelNameForm);
            this.Controls.Add(this.Kalkulo);
            this.Controls.Add(this.LabelSecretKeyOutput);
            this.Controls.Add(this.LabelPublicKeyOutput);
            this.Controls.Add(this.lbl_Qelesi_Sekret);
            this.Controls.Add(this.lbl_QelesiPublik);
            this.Controls.Add(this.txtbox_NumriThjeshte_Randomt);
            this.Controls.Add(this.LabelAnySimpleNumber);
            this.Controls.Add(this.txtbox_Rrenja_Primitive_NumritThjesht);
            this.Controls.Add(this.LabelPrimitiveRootOfTheSimpleNumber);
            this.Controls.Add(this.LabelSimpleNumber);
            this.Controls.Add(this.txtbox_Numri_Thjeshte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Elgamal_Gjenerimi_Qelesave";
            this.Text = "Key Generation ";
            this.Load += new System.EventHandler(this.Elgamal_Gjenerimi_Qelesave_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Numri_Thjeshte;
        private System.Windows.Forms.Label LabelSimpleNumber;
        private System.Windows.Forms.Label LabelPrimitiveRootOfTheSimpleNumber;
        private System.Windows.Forms.TextBox txtbox_Rrenja_Primitive_NumritThjesht;
        private System.Windows.Forms.Label LabelAnySimpleNumber;
        private System.Windows.Forms.TextBox txtbox_NumriThjeshte_Randomt;
        private System.Windows.Forms.Label lbl_QelesiPublik;
        private System.Windows.Forms.Label lbl_Qelesi_Sekret;
        private System.Windows.Forms.Label LabelPublicKeyOutput;
        private System.Windows.Forms.Label LabelSecretKeyOutput;
        private System.Windows.Forms.Button Kalkulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elGamalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyGenerationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutCryptographyAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label LabelNameForm;
    }
}

