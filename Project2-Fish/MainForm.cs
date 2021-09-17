using System;
using System.Windows.Forms;

namespace Project2_Fish
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string _fish;

        private void crappieButton_CheckedChanged(object sender, EventArgs e)
        {
            _fish = "Crappie";
        }

        private void perchButton_CheckedChanged(object sender, EventArgs e)
        {
            _fish = "Perch";
        }

        private void walleyeButton_CheckedChanged(object sender, EventArgs e)
        {
            _fish = "Walleye";
        }

        private void fishButton_Click(object sender, EventArgs e)
        {
            FormSeeFish fishForm = new FormSeeFish(_fish);
            DialogResult result = fishForm.ShowDialog();

            if (result == DialogResult.OK) 
                MessageBox.Show("The selected " + fishForm.response);
      
        }
    }
}