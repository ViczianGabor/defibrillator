using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace defibrillator
{
    public partial class foForm : Form
    {
        static private List<keszulek> adatok = new List<keszulek>();

        public foForm()
        {
            Beolv();
            InitializeComponent();
        }

        private void Beolv()
        {
            StreamReader sr = new StreamReader("data.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                double a2 = double.Parse(a[2].Replace('.',','));
                double a3 = double.Parse(a[3].Replace('.',','));
                adatok.Add(new keszulek(int.Parse(a[0]),a[1],a2,a3,a[4],a[5]));

            }

            sr.Close();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUjadat_Click(object sender, EventArgs e)
        {
            lbMegjelenit.Items.Clear();
            tbX.Text = "";
            tbY.Text = "";
            tbX.Focus();
        }

        private void btnLekeres_Click(object sender, EventArgs e)
        {
            if (tbX.Text == "" || tbY.Text == "")
            {
                MessageBox.Show("Az egyik koordináta nincs kitöltve");

            }
            else
            {
                double BeirtX = Convert.ToDouble(tbX.Text);
                double BeirtY = Convert.ToDouble(tbY.Text);
                double legkisebbtavolsag = 0;
                int index = 0;

                for (int i = 0; i < adatok.Count; i++)
                {
                    double hosszusag = 0;
                    adatok[i].DistCalc(BeirtX, BeirtY, adatok[i].Latitude, adatok[i].Longitude, ref hosszusag);
                    if (hosszusag > legkisebbtavolsag)
                    {
                        legkisebbtavolsag = hosszusag;

                        index = i;
                    }
                }

                lbMegjelenit.Items.Add("A legközelebb elérhető készülék:");
                lbMegjelenit.Items.Add($"Telefonszám:{adatok[index].Tel}");
                lbMegjelenit.Items.Add($"Cím:{adatok[index].Address}");

                

            }
        }
    }
}
