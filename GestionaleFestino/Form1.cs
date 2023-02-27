using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleFestino
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> amici = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            double prezzo = Double.Parse(textBox2.Text);

            amici.Add(nome, prezzo);

            string[] row = {nome, prezzo.ToString()};
            var ListViewItem = new ListViewItem(row);
            listView1.Items.Add(ListViewItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            double prezzo = Double.Parse(textBox2.Text);

            amici.Remove(textBox1.Text);

            listView1.Items.RemoveAt();
        }
    }
}
