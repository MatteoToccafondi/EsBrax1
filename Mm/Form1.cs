using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton=button1;
            this.CancelButton = button2;
        }

        List<int> Lista = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {


            int a = 1;
            int b = 12;

            int unused_variable = 9876;

            Lista.Add(Convert.ToInt32(textBox1.Text));
            label5.Text = Lista.Min().ToString();
            label4.Text = Lista.Max().ToString();
            Lista.Sort();
            label9.Text += textBox1.Text;       
          for (int i = 0; i < 5; i++){
                 Lista.Add(Convert.ToInt32(textBox1.Text));
                 label5.Text = Lista.Min().ToString();
                 label4.Text = Lista.Max().ToString();
                 
          }     

        }
        
        private string uselessFeature1(){
            return "Festure1";
        }

        void lassativo()
        {
            MessageBox.Show("lassativo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
