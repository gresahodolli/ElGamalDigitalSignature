using ElgamalAgoritmi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyAlgorithms
{
    public partial class FormaStartuese : Form
    {
        public FormaStartuese()
        {
            InitializeComponent();
        }

        //Elgamal
        private void EGKeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Elgamal_Gjenerimi_Qelesave temp = new Elgamal_Gjenerimi_Qelesave();
            temp.Hide();
            temp.Show();
        }

        private void EGEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Elgamal_Enkriptimi temp = new Elgamal_Enkriptimi();
            temp.Hide();
            temp.Show();
        }

        private void EGDecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Elgamal_Dekriptimi temp = new Elgamal_Dekriptimi();
            temp.Hide();
            temp.Show();
        }

        private void ElGamalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Elgamal_Gjenerimi_Qelesave tempKG = new Elgamal_Gjenerimi_Qelesave();
            Elgamal_Enkriptimi tempE = new Elgamal_Enkriptimi();
            Elgamal_Dekriptimi tempD = new Elgamal_Dekriptimi();
            tempKG.Hide();
            tempE.Hide();
            tempD.Hide();
            tempKG.Show();
            tempE.Show();
            tempD.Show();
        }

      

        //te tjera
        private void AboutCryptographyAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RrethAlgoritmitElgamal temp = new RrethAlgoritmitElgamal();
            temp.Hide();
            temp.Show();
        }
    }
}
