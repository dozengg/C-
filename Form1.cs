using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessinggame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static ArrayList WordList = new ArrayList();
        static StringBuilder SB1 = new StringBuilder();
        static StringBuilder SB2 = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {
            Return();
        }
        private void Return()
        {
            WordList.Add("C*o*m*p*u*t*e*r");
            WordList.Add("K*e*y*b*o*a*r*d");
            WordList.Add("P*a*t*r*i");
            WordList.Add("M*o*u*s*e");
            WordList.Add("C*a*s*e");

            Random rand = new Random();
            int randomNum = rand.Next(1, 5);

            string[] word = WordList[randomNum].ToString().Split('*');

            for (int i = 0; i < word.Length; i++)
            {
                SB1.Append(word[i]);
            }
            SB2.Append(word[0]);
            for (int i = 1; i < word.Length - 1; i++)
            {
                word[i] = "?";
                SB2.Append(word[i]);
            }
            SB2.Append(word[word.Length - 1]);
            label1.Text = SB2.ToString();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text.ToString();
            if (answer.Equals(SB1.ToString()))
            {
                label1.Text = answer;
                MessageBox.Show("Correct!!");

                listBox1.Items.Clear();
                SB1.Clear();
                SB2.Clear();
                Return();

            }
            else if (answer == "")
            {
                MessageBox.Show("No Input");
            }
            else if (!answer.Equals(SB1.ToString()))
            {
                MessageBox.Show("Incorrect Answer " +
                    "\nTry Again");
                listBox1.Items.Add(answer);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
