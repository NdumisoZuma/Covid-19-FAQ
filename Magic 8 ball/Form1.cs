using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string question;

        string output;
        private void button1_Click(object sender, EventArgs e)
        {

           


            string[] what = new string[]
            {"Covid is a virus",
             "Covid is an infectious disease",
             "Coronaviruses are a group of related viruses that cause diseases in mammals and birds"};


            string[] prevent = new string[] 
            {"Wear a mask",
             "Sanatize oor wash your hands with soap",
             "Maintain safe distance from others",
             "Stay home if you feel unwell" };


            string[] protect = new string[] 
            {"Cover your mouth and nose around people",
            "Clean your hands",
            "Keep your distance",

            };

            string[] symptoms = new string[]
            {
                "Corona Virus symptoms include fever, cough, tiredness, loss of taste or smell",
                "Corona virus symptoms include sore throat, headache, diarrhoea",
                "Serious Corona virus symptoms include difficulty breathing, chest pain and loss of speech "

            };

            Random rd = new Random();
            if (Question.Text.Contains("What"))
            {

                int index = rd.Next(what.Length);
           
                  Response.Text = what[index];
            }

            else if (Question.Text.Contains("prevent"))
            {
                int index = rd.Next(prevent.Length);
                Response.Text = prevent[index];
            }

            else if (Question.Text.Contains("protect"))
            {
                int index = rd.Next(protect.Length);
                Response.Text = protect[index];
            }

            else if (Question.Text.Contains("symptoms"))
            {
                int index = rd.Next(symptoms.Length);
                Response.Text = symptoms[index];
            }
                
                








        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Question_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Response.Text);
        }

        private void Again_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Question.Clear();
        }
    }
}
