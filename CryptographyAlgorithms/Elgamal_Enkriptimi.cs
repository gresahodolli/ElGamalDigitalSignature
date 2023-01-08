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
    public partial class Elgamal_Enkriptimi : Form
    {
        public Elgamal_Enkriptimi()
        {
            InitializeComponent();
        }

        private void ButtonEncryption_Click(object sender, EventArgs e)
        {
            //Hyrja
            BigInteger Message = BigInteger.Parse(txtboxMesazhi.Text);

            Int32 PjesaPareQelesitPublik = Int32.Parse(txtboxPjesaPareQelesitPublik.Text);
            Int32 PjesaDyteQelesitPublik = Int32.Parse(txtboxPjesaDyteQelesitPublik.Text);
            BigInteger PjesaTretQelesitPublik = BigInteger.Parse(txtboxPjesaTreteQelesitPublik.Text);

            //Gjenerimi i qelesit te perkohshem (session qelesit)
            Int32 QelesiRastitSession;

            if (checkbox_Qelesi_Session.Checked == true)
            {
                txtboxQelesi_Session.Text = "";
                Random tempRastit = new Random();
                
                QelesiRastitSession = (42 + tempRastit.Next()) % (Math.Abs(Convert.ToInt32(PjesaPareQelesitPublik-PjesaDyteQelesitPublik))) + 6;
            }
            else
            {
                QelesiRastitSession = int.Parse(txtboxQelesi_Session.Text);
            }
                       

            //enkriptimi
            BigInteger PjesaPareTekstitEnkriptuar = BigInteger.Pow(PjesaDyteQelesitPublik, QelesiRastitSession) % PjesaPareQelesitPublik;
            BigInteger PjesaDyteTesktitEnkriptuar = (BigInteger.Pow(PjesaTretQelesitPublik, QelesiRastitSession) * Message) % PjesaPareQelesitPublik;

            //dalja
            LabelCiphertextOutput.Text = Convert.ToString(PjesaPareTekstitEnkriptuar + " / " + PjesaDyteTesktitEnkriptuar);
        }

        private void KeyGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elgamal_Gjenerimi_Qelesave temp = new Elgamal_Gjenerimi_Qelesave();
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

    }
}
