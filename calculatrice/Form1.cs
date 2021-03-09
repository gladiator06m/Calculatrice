using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        //CONDITION SI L'UN DES DEUX CHAMPS EST VIDE
        public void condition()
        {
            string message = "Champ vide ! Veuillez saisir un chiffre";

            if (textBox1.Text == "")
            {
                textBox1.Text = message;
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = message;
            }
        }
      
        public Form1()
        {
            InitializeComponent();
        }

        //DECLARATION DES VARIABLES POUR LES DEUX CHAMPS -> SAISIE
        double txt1 = 0;
        double txt2 = 0;

        //ADDITION 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                condition();

                txt1 = Convert.ToDouble(textBox1.Text);
                txt2 = Convert.ToDouble(textBox2.Text);
                double sum = txt1 + txt2;

                textBox3.Text = sum.ToString();

            }
            catch 
            {
                    textBox3.Text = "Veuillez remplir les champs correctement";
            }

            
        }

        //SOUSTRACTION
        private void button2_Click(object sender, EventArgs e)
        {
    
            try
            {
                condition();

                txt1 = Convert.ToDouble(textBox1.Text);
                txt2 = Convert.ToDouble(textBox2.Text);
                double sum = txt1 - txt2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                textBox3.Text = "Veuillez remplir les champs correctement";

            }

        }

        //DIVISION
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                condition();

                txt1 = Convert.ToDouble(textBox1.Text);
                txt2 = Convert.ToDouble(textBox2.Text);
                double sum = txt1 / txt2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                textBox3.Text = "Veuillez remplir les champs correctement";

            }
        }

        //MULTIPLICATION
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                condition();

                txt1 = Convert.ToDouble(textBox1.Text);
                txt2 = Convert.ToDouble(textBox2.Text);
                double sum = txt1 * txt2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                textBox3.Text = "Veuillez remplir les champs correctement";
            }
        }

    }
}
