using ListLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuPraxe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> listCisel = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            

            Operace.Vygenerovani(listCisel, n);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operace.Vypsani(listCisel, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pocet;
            pocet = Operace.pocetJedinecnych(listCisel);
            MessageBox.Show("Pocet vygenerovaných jedinecnych čísel je " + pocet);
        }
    }
}
