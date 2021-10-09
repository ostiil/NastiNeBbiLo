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

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] test = File.ReadAllLines(@"C:\Users\686-19\Desktop\test.txt");
            string[] element = new string[test.Length];
            bool admin = false;
            bool check = false;

            for (int i = 0; i < test.Length; i++)
            {
                element = test[i].Split(':');
                
                string login = element[3];
                string password = element[4];

                if ((LogintextBox.Text == login)&(PasswordtextBox.Text == password))
                {

                }

            }
        }
    }
            public static class Global
            {
                public static string role;
            }
}

