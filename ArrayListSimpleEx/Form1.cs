using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList phrase = new ArrayList();
        bool forwardOrder = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phrase.Add("I");
            phrase.Add("Love");
            phrase.Add("Programming");
            phrase.Add("So");
            phrase.Add("Much");

        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (!forwardOrder)
            {
                phrase.Reverse();
                forwardOrder = !forwardOrder;

            }

            lblMessage.Text = string.Empty;
            printPhrase();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (forwardOrder)
            {
                phrase.Reverse();
                forwardOrder = !forwardOrder;
            }

            lblMessage.Text = string.Empty;
            printPhrase();

        }

        private void printPhrase()
        {
            foreach (object word in phrase)
            {
                lblMessage.Text += word + " ";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (forwardOrder)
            {
                phrase.Insert(1, txtSecondPos.Text);
            }
            else
            {
                phrase.Insert(phrase.Count - 1, txtSecondPos.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (forwardOrder)
            {
                phrase.RemoveAt(1);
            }
            else
            {
                phrase.RemoveAt(phrase.Count - 2);
            }
        }
    }
}
