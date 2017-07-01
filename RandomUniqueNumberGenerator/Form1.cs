using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogics;
namespace RandomUniqueNumberGenerator
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

        // From TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // To TextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Generate Buttons

      

        private void buttonGenerateUnique_Click(object sender, EventArgs e)
        {
            listBoxResult.Text = null;
            Calculation _calculation = new Calculation();

            if ((int)Convert.ToUInt64(textBoxFrom.Text) > (int)Convert.ToUInt64(textBoxTo.Text))
            {

                MessageBox.Show("From cannot be bigger than To");
                ResetAll();
                return;
            }

            if (!string.IsNullOrEmpty(textBoxFrom.Text) && !string.IsNullOrEmpty(textBoxTo.Text))
            {
                if (string.IsNullOrEmpty(textBoxHowMany.Text))
                {
                    listBoxResult.DataSource = _calculation.GenerateDistinctNumbersRandomOrder((int)Convert.ToUInt64(textBoxFrom.Text), (int)Convert.ToUInt64(textBoxTo.Text));
                }
                else
                {
                    listBoxResult.DataSource = _calculation.GenerateDistinctNumbersRandomOrder((int)Convert.ToUInt64(textBoxFrom.Text), (int)Convert.ToUInt64(textBoxTo.Text), (int)Convert.ToUInt64(textBoxHowMany.Text));
                }
            }
            else
                MessageBox.Show("From and To are required fields");
                
            //    throw new Exception("The From or To values cannot be empty");
        }
       
        private void buttonGenerateSet_Click(object sender, EventArgs e)
        {

        }


        public void ResetAll()
        {
            List<string> _empty = new List<string>();
            _empty.Add("");

            listBoxResult.DataSource = _empty;
            textBoxFrom.Text = null;
            textBoxTo.Text = null;
            textBoxHowMany.Text = null;
            textBoxFrom.Select();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void buttonCopyAll_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBoxResult.Items) s1 += item.ToString() + "\r\n";

            if (string.IsNullOrEmpty(s1))
                return;
            Clipboard.SetText(s1);
           
        }

       
    }
}
