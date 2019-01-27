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
            string[] riadok1;
            string[] riadok2;
            int slovaVRiadku = 5;
            int pocetVersov = 4;
            int rnd;
            string koncoveSlovo1 = "";
            string koncoveSlovo2 = "";
            string[] basen = new string[pocetVersov * slovaVRiadku];
            
            string[] prechodnyArray = new string[slovaVRiadku * 2];
            for (int i = 0; i < pocetVersov/2; i++)
            {
                riadok1 = new string[slovaVRiadku - 1];
                riadok2 = new string[slovaVRiadku - 1];

                for (int x = 0; x < slovaVRiadku - 1; x++)         // 2 verse naplni 4 slovami
                {
                    rnd = rndCislo.Next(slova.Count);
                    
                    if(slova[rnd] is string)
                    {
                        riadok1[x] = (string)slova[rnd];
                        slova.Remove(rnd);
                    }

                    rnd = rndCislo.Next(slova.Count);

                    if (slova[rnd] is string)
                    {
                        riadok2[x] = (string)slova[rnd];
                        slova.Remove(rnd);
                    }
                }

                rnd = rndCislo.Next(slova.Count);

                if (slova[rnd] is string)
                {
                    koncoveSlovo1 = (string)slova[rnd];
                    slova.Remove(rnd);
                }
                
                do
                {
                    rnd = rndCislo.Next(slova.Count);
                    if (slova[rnd] is string)
                    {
                        koncoveSlovo2 = (string)slova[rnd];
                    }
                } while (!(koncoveSlovo2.Substring(koncoveSlovo2.Length - 2) == koncoveSlovo1.Substring(koncoveSlovo1.Length - 2)));

                slova.Remove(rnd);

                /*Array.Copy(riadok1, prechodnyArray, riadok1.Length);                //spojime riadok1 + koncoveSlovo1 + riadok2 + koncoveSlovo2
                prechodnyArray[riadok1.Length] = koncoveSlovo1;                               // do jedneho arrayu ktory sa nakopiruje
                Array.Copy(riadok2, 0, prechodnyArray, riadok1.Length + 1, riadok2.Length);   // na spravnu poziciu v basni
                prechodnyArray[riadok1.Length + riadok2.Length + 2] = koncoveSlovo2;

                Array.Copy(prechodnyArray, 1, basen, i * 2 * slovaVRiadku, prechodnyArray.Length);*/
                
                for (int a = 0; a < riadok1.Length; a++)
                {
                    tbOutPut.Text += riadok1[a] + "  ";
                }
                tbOutPut.Text += koncoveSlovo1 + "\n";
                for (int b = 0; b < riadok2.Length; b++)
                {
                    tbOutPut.Text += riadok2[b] + "  ";
                }
                tbOutPut.Text += koncoveSlovo2 + "";

            }

            /*for (int i = 0; i < basen.Length; i++)
            {
                tbOutPut.Text += basen[i];
                if(i + 1 % slovaVRiadku == 0)
                {
                    tbOutPut.Text += "\n";
                }
            }*/


        }
    }
}
