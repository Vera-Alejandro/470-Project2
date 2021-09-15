using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Fish
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void crappieButton_CheckedChanged(object sender, EventArgs e)
        {
            new FormSeeFish("Crappie");
        }

        private void perchButton_CheckedChanged(object sender, EventArgs e)
        {
            new FormSeeFish("Perch");
        }

        private void walleyeButton_CheckedChanged(object sender, EventArgs e)
        {
            new FormSeeFish("Walleye");
        }
    }
}