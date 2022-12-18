using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_Game
{
    public partial class Form1 : Form
    {
         Random random = new Random();
        byte ranNum;
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0X20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            GetRanNum();
        }

        public void GetRanNum()
        {
            ranNum = Convert.ToByte(random.Next(1, 100+1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(textBox1.Text) < ranNum)
            {
                label4.Text = "Your num < random num";
            }
            if (Convert.ToByte(textBox1.Text) > ranNum)
            {
                label4.Text = "Your num > random num";
            }
            if (Convert.ToByte(textBox1.Text) == ranNum)
            {
                DialogResult result = MessageBox.Show("You win!\nDo you want to play again?","Message",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ranNum = Convert.ToByte(random.Next(1, 100+1));
                    label4.Text = "";
                    textBox1.Text = "";
                }
                if (result == DialogResult.No)
                    Close();
            }
        }
    }
}
