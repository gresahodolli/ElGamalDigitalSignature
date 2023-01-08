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
using CryptographyAlgorithms;

namespace ElgamalAgoritmi
{
    public partial class Elgamal_Dekriptimi : Form
    {
        public Elgamal_Dekriptimi()
        {
            InitializeComponent();
        }

        private void ButtonDecryption_Click(object sender, EventArgs e)
        {
            //Hyrja
            BigInteger PjesaPareTesktitEnkriptuar = BigInteger.Parse(TextBoxFirstPartOfTheCipgertext.Text);
            BigInteger PjesaDyteTesktitEnkriptuar = BigInteger.Parse(TextBoxSecondPartOfTheCipgertext.Text);

            Int32 QelesiSekret = Int32.Parse(TextBoxSecretKey.Text);

            Int32 PjesaPareQelesitPublik = Int32.Parse(TextBoxFirstPartOfThePublicKey.Text);

            //Dekriptimi
            BigInteger Message = PjesaDyteTesktitEnkriptuar * BigInteger.Pow(PjesaPareTesktitEnkriptuar, PjesaPareQelesitPublik - 1 - QelesiSekret) % PjesaPareQelesitPublik;

            //Dalja
            LabelMessageOutput.Text = Convert.ToString(Message);
        }

        private void KeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elgamal_Gjenerimi_Qelesave temp = new Elgamal_Gjenerimi_Qelesave();
            temp.Hide();
            temp.Show();
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elgamal_Enkriptimi temp = new Elgamal_Enkriptimi();
            temp.Hide();
            temp.Show();
        }

        private void AboutCryptographyAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RrethAlgoritmitElgamal temp = new RrethAlgoritmitElgamal();
            temp.Hide();
            temp.Show();
        }

        private void LabelNameForm_Click(object sender, EventArgs e)
        {

        }

        private void lblMesazhi_Click(object sender, EventArgs e)
        {

        }
    }
}
