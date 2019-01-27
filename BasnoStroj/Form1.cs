using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasnoStroj
{
    public partial class Form1 : Form
    {
        ArrayList slova;
        Random rndCislo = new Random();



        public Form1()
        {
            InitializeComponent();

            slova = new ArrayList();
            NaplnSlova();

        }

        private void NaplnSlova()
        {
            string[] docasneSlova = System.IO.File.ReadAllLines(@"D:\VisualStudio\BasnoStroj\slova.txt");
            for (int i = 0; i < docasneSlova.Length; i++)
            {
                slova.Add(docasneSlova[i]);

            }
        }

        private void btnGenerujBasen_Click(object sender, EventArgs e)
        {
            int pocetVersov = 4;
            int pocetSlovVoVersi = 5;
            int pocetStrof = 1;
            int rnd;
            string koncoveSlovo1 = "";
            string koncoveSlovo2 = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pocetVersov = 5;
                    pocetVersov = 4;
                    pocetStrof = 1;
                    break;
                case 1:
                    pocetSlovVoVersi = trackBarSlova.Value;
                    pocetVersov = trackBarVerse.Value;
                    pocetStrof = trackBarStrofy.Value;
                    break;
            }




            for (int z = 0; z < pocetStrof; z++)
            {
                for (int i = 0; i < pocetVersov / 2; i++)
                {
                    for (int x = 0; x < pocetSlovVoVersi - 1; x++)              // generuje vers 1
                    {
                        rnd = rndCislo.Next(slova.Count);
                        tbOutPut.Text += slova[rnd];
                        slova.Remove(slova[rnd]);
                    }
                    rnd = rndCislo.Next(slova.Count);
                    if (slova[rnd] is string)
                    {
                        koncoveSlovo1 = (string)slova[rnd];
                        tbOutPut.Text += koncoveSlovo1 + "\r\n";
                        slova.Remove(slova[rnd]);
                    }

                    for (int x = 0; x < pocetSlovVoVersi - 1; x++)              // generuje vers 2
                    {
                        rnd = rndCislo.Next(slova.Count);
                        tbOutPut.Text += slova[rnd];
                        slova.Remove(slova[rnd]);
                    }

                    do
                    {
                        rnd = rndCislo.Next(slova.Count);
                        if (slova[rnd] is string)
                        {
                            koncoveSlovo2 = (string)slova[rnd];
                        }

                    } while (!(koncoveSlovo2.Substring(Math.Max(0, koncoveSlovo2.Length - 3)) == koncoveSlovo1.Substring(Math.Max(0, koncoveSlovo1.Length - 3))));

                    tbOutPut.Text += koncoveSlovo2 + "\r\n";


                }
                tbOutPut.Text += "\r\n";
            }

           


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbOutPut.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    groupBox2.Visible = false;
                    btnGenerujBasen.Visible = true;
                    break;
                case 1:
                    groupBox2.Visible = true;
                    btnGenerujBasen.Visible = true;
                    break;
            }
        }
    }
}
