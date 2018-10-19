﻿using System;
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



            button2.Click += (sender, e) =>
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
            string adatok = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text;

            var eremeny = saveFileDialog1.ShowDialog(this);
            if (eremeny == DialogResult.OK)
            {
                string FileNev = saveFileDialog1.FileName;
                File.WriteAllText(FileNev, adatok);

            }


        }

        private void Betoltes()
        {
            string adatok = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text;

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                adatok = File.ReadAllText(openFileDialog1.FileName);
            }


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           


        }
    




    }

}