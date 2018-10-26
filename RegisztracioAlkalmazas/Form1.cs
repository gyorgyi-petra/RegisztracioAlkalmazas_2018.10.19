using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            button2.Click +=   (sender, e) =>
            {
                Mentes();
            };

            button3.Click += (sender, e) =>
            {
                Betoltes();
            };

        }

      

        private void Mentes()
        {
            List<string> adatok = new List<string>();
            string tartalom = "Név: "  + textBox1.Text + ";" +"\nSzületési dátum: "+ textBox2.Text + ";"+ "\nKedvenc hobbi: "  + listBox1.Text;

            if (listBox1.SelectedValue !=null) {
                tartalom += listBox1.SelectedValue;

            }
            adatok.Add(tartalom);
            var eredmeny = saveFileDialog1.ShowDialog(this);
            if (eredmeny == DialogResult.OK) {

                string fajlnev = saveFileDialog1.FileName;
                using (var file = File.CreateText(fajlnev)) {
                    file.Write(tartalom);
                }
            }

        }

        private void Betoltes()
        {
           

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

               // adatok = File.ReadAllText(openFileDialog1.FileName);
            }


        }

        //hobbi hozzáad
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4 !=null) {
                listBox1.Items.Add(textBox4.Text);

            }


        }
    




    }

}