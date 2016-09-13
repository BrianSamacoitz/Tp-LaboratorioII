using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.label1.Text = "";
            this.comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            Numero num2 = new Numero();            

            string nro1 = this.textBox1.Text;
            string nro2 = this.textBox1.Text;

            num1.Setter(nro1);
            num2.Setter(nro2);

            string op = this.comboBox1.SelectedItem.ToString();


            this.label1.Text = Calculadora.operar(num1, num2, op).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
