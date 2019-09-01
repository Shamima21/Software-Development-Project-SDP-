using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Handwriting
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.ShowDialog(); 
        }
}
}
