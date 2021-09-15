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

        string fish;

        private void crappieButton_CheckedChanged(object sender, EventArgs e)
        {
            fish = "Crappie";
        }

        private void perchButton_CheckedChanged(object sender, EventArgs e)
        {
            fish = "Perch";
        }

        private void walleyeButton_CheckedChanged(object sender, EventArgs e)
        {
            fish = "Walleye";
        }

        private void fishButton_Click(object sender, EventArgs e)
        {
            FormSeeFish fishForm = new FormSeeFish(fish);
            fishForm.Show();
        }
    }
}