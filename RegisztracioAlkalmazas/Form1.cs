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
        }



        public void Ffi_vagy_no() {
            if (radioButton1.Checked == true) {
                radioButton2.Checked = false;
            } else if (radioButton2.Checked == true) {
                radioButton1.Checked = false;
            }
        }

        //hobbi hozzáad
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4 != null) {
                listBox1.Items.Add(textBox4.Text);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
            Console.WriteLine(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> adatok = new List<string>();
            string tartalom = "";

            if (radioButton1.Checked == true)
            {
                tartalom = "Név: " + textBox1.Text + ";" + "\nSzületési dátum: " + textBox2.Text + ";" + "Nem: Nő " + ";" + "\nKedvenc hobbi: " + listBox1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                tartalom = "Név: " + textBox1.Text + ";" + "\nSzületési dátum: " + textBox2.Text + ";" + "Nem: Férfi" + ";" + "\nKedvenc hobbi: " + listBox1.Text;
            }


            if (listBox1.SelectedValue != null)
            {
                tartalom += listBox1.SelectedValue;

            }


            adatok.Add(tartalom);
            var eredmeny = saveFileDialog1.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {

                string fajlnev = saveFileDialog1.FileName;
                using (var file = File.CreateText(fajlnev))
                {
                    file.Write(tartalom);
                }
            }
        }
        }

    }


    

