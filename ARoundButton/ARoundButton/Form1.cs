using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARoundButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundButton rb = new RoundButton();
            rb.Click += new EventHandler(this.roudButton_Click);
            this.Controls.Add(rb);
        }
        private void roudButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
