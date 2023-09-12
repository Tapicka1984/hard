using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardasf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list.Clear();
        }

        List<int> list = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            Random rng = new Random();
            int n = 0;
            while (n < N)
            {
                int cislo = rng.Next(-5, 101);
                list.Add(cislo);
                n++;
            }
            Vypis(list, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Smazani_dokonalych_cisel(list);
            Vypis(list, listBox2);
        }

        void Smazani_dokonalych_cisel(List<int> list)
        {
            foreach (int i in list)
            {
                if ((i == 6) || (i == 28))
                {
                    list.Remove(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sorting(list);
            Vypis(list, listBox3);
        }

        public void Sorting(List<int> list)
        {
            list.Sort();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prumer(list);
        }

        void Prumer(List<int> list)
        {
            int soucet = 0;
            int pocet = 0;
            foreach(int i in list)
            {
                soucet += i;
                pocet++;
            }
            MessageBox.Show("aritmeticky prumer cisel je: " + soucet / pocet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Maximum(list);
        }

        void Maximum(List<int>list)
        {
            int maximum = -500;
            foreach(int i in list)
            {
                if(i > maximum)
                {
                    maximum = i;
                }
            }
            MessageBox.Show("nejvetsi cislo je: " + maximum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Druhy_maximum(list);
        }

        void Druhy_maximum(List<int> list)
        {
            int max = -500;
            int dMax = 0;
            foreach (int i in list)
            {
                if (i > max)
                {
                    dMax = max;
                    max = i;
                }
            }
            MessageBox.Show("druhe maximum je: " + dMax);
        }

        void Vypis(List<int> list, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach(int i in list)
            {
                listbox.Items.Add(i);
            }
        }
    }
}
