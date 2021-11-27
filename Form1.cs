using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{

    public partial class Form1 : Form
    {
        Dictionary<string, string> myDict =
        new Dictionary<string, string>();




        public Form1()
        {
            InitializeComponent();
            myDict.Add("Pies", "Dog"); //1
            myDict.Add("Kot", "Cat");
            myDict.Add("Swinia", "Pig");
            myDict.Add("Chomik", "Hamster");
            myDict.Add("Ptak", "Bird"); //5
            myDict.Add("Mysz", "Mouse");
            myDict.Add("Pszczola", "Bee");
            myDict.Add("Niedzwiedz", "Bear");
            myDict.Add("Krowa", "Cow");
            myDict.Add("Kurczak", "Chicken"); //10
            myDict.Add("Kaczka", "Duck");
            myDict.Add("Slon", "Elephant");
            myDict.Add("Ryba", "Fish");
            myDict.Add("Zaba", "Frog");
            myDict.Add("Lew", "Lion"); //15
            myDict.Add("Dog", "Pies");
            myDict.Add("Cat", "Kot");
            myDict.Add("Pig", "Swinia");
            myDict.Add("Hamster", "Chomik");
            myDict.Add("Bird", "Ptak"); //20
            myDict.Add("Mouse", "Mysz");
            myDict.Add("Bee", "Pszczola");
            myDict.Add("Bear", "Niedzwiedz");
            myDict.Add("Cow", "Krowa");
            myDict.Add("Chicken", "Kurczak"); //25
            myDict.Add("Duck", "Kaczka");
            myDict.Add("Elephant", "Slon");
            myDict.Add("Fish", "Ryba");
            myDict.Add("Frog", "Zaba");
            myDict.Add("Lion", "Lew"); //30

            //angielsko polskie
            for (int i = 0; i < 15; i++)
            {
                string a = myDict.Values.ElementAt(i);
                string b = myDict.Keys.ElementAt(i);
                listBox3.Items.Add(a+ " -  "+b);
            }
            //polsko angielskie
            for (int i = 0; i < 15; i++)
            {
                string a = myDict.Values.ElementAt(i);
                string b = myDict.Keys.ElementAt(i);
                listBox2.Items.Add(b + " - " + a);
            }
            //wszystkie tlumaczenia
            for (int i = 0; i < 15; i++)
            {
                string a = myDict.Values.ElementAt(i);
                string b = myDict.Keys.ElementAt(i);
                listBox1.Items.Add(b + " - " + a);
                listBox1.Items.Add(a + " - " + b);
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox3.Visible = false;
            listBox1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            listBox3.Visible = true;
            listBox1.Visible = false;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == myDict[textBox1.Text])
            {
                MessageBox.Show("Dobrze");
                var rnd = new Random();
                int randomValue = rnd.Next(15, 30);
                string b = myDict.Values.ElementAt(randomValue);
                textBox2.Text = b;
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == myDict[textBox1.Text])
            {
                MessageBox.Show("Dobrze");
                var rnd = new Random();
                int randomValue = rnd.Next(1, 15);
                string a = myDict.Values.ElementAt(randomValue);
                textBox2.Text = a;
                textBox1.Text = "";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == myDict[textBox1.Text])
            {
                MessageBox.Show("Dobrze");
                var rnd = new Random();
                int randomValue = rnd.Next(1, 30);
                string a = myDict.Values.ElementAt(randomValue);
                textBox2.Text = a;
                textBox1.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Dog";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Pies";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Pies";
        }
    }

}

