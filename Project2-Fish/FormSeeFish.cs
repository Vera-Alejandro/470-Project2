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
    public partial class FormSeeFish : Form
    {
        private string _Fish;
        public string response;

        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _Fish = selectedFish;

        }
        private void LoadPictures()
        {
            //pictures get loaded
            switch (_Fish)
            {
                case "Crappie":
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
                case "Perch":
                    pictureBox1.Image = Properties.Resources.Perch;
                    break;
                case "Walleye":
                    pictureBox1.Image = Properties.Resources.Walleye;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            response = "Decision Cancelled.";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            response = "Decision is to Throw it back."; 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            response = "Decision is to Keep it.";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
