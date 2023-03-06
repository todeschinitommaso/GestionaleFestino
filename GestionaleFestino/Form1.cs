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

        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, double> lista = new Dictionary<string, double>();

        public void Aggiorna()
        {
            listView1.Items.Clear();

            double n = 0;
            foreach (KeyValuePair<string, double> p in lista)
            {
                string[] row = { p.Key, p.Value.ToString() };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                n = n + p.Value;
            }
            label4.Text = n.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(textBox2.Text);
                lista.Add(textBox1.Text, n);
                Aggiorna();

                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aggiorna();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    string s = listView1.SelectedItems[i].Text;
                    lista.Remove(s);
                    Aggiorna();
                }
            }
            else
                MessageBox.Show("Seleziona un elemento");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    string s = listView1.SelectedItems[i].Text;
                    textBox1.Text = s;
                    textBox2.Text = lista[s].ToString();
                    lista.Remove(s);
                    Aggiorna();
                }
            }
            else
                MessageBox.Show("Seleziona un elemento");
        }
    }
}
