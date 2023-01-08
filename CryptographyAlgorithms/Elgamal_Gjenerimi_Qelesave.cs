using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using ElgamalAgoritmi;

namespace CryptographyAlgorithms
{
    public partial class Elgamal_Gjenerimi_Qelesave : Form
    {
        public Elgamal_Gjenerimi_Qelesave()
        {
            InitializeComponent();
        }

        private void ButtonСalculate_Click(object sender, EventArgs e)
        {

                //hyrja
            Int32 PjesaPareQelesitPublik = Int32.Parse(txtbox_Numri_Thjeshte.Text);

            Int32 PjesaDyteQelesiPublik = Int32.Parse(txtbox_Rrenja_Primitive_NumritThjesht.Text);

            Int32 QelesiSekret = Int32.Parse(txtbox_NumriThjeshte_Randomt.Text);
            
            BigInteger PjesaTreteQelesitPublik = BigInteger.Pow(PjesaDyteQelesiPublik, QelesiSekret) % PjesaPareQelesitPublik;

            //dalja
            LabelPublicKeyOutput.Text = Convert.ToString(PjesaTreteQelesitPublik + " / " + PjesaDyteQelesiPublik + " / " + PjesaPareQelesitPublik);
            LabelSecretKeyOutput.Text = Convert.ToString(QelesiSekret);
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elgamal_Enkriptimi temp = new Elgamal_Enkriptimi();
            temp.Hide();
            temp.Show();
        }
        private void DecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elgamal_Dekriptimi temp = new Elgamal_Dekriptimi();
            temp.Hide();
            temp.Show();
        }

        private void AboutCryptographyAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RrethAlgoritmitElgamal temp = new RrethAlgoritmitElgamal();
            temp.Hide();
            temp.Show();
        }

        private void Elgamal_Gjenerimi_Qelesave_Load(object sender, EventArgs e)
        {

        }
    }
}
