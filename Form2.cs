using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        bool check = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((new Regex(@"^[А-Я]{9}$")).IsMatch(PasswordtextBox.Text))
            {

                check = true;

            }
            else
            {

                check = false;
                MessageBox.Show("Пароль не соответсвует условию");
            }
            if (check)
            {
                string str =  SurnametextBox.Text + ':' + NametextBox.Text + ':' + LastNametextBox.Text + ':' + LogintextBox.Text + ':' + PasswordtextBox.Text +  '\n';
                StreamWriter SW = new StreamWriter(@"C:\Users\686-19\Desktop\test.txt", true);
                SW.Write(str);
                SW.Close();
                this.Close();
                MessageBox.Show("Вы зарегистрировались.");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
