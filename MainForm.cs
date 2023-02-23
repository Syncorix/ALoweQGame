using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALoweQGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            //code for hiding, revealing, and opening the new form
            DesignForm designForm = new DesignForm();
            designForm.goBack = this;
            designForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.goBack = this;
            playForm.Show();
            this.Hide();
        }
    }
}
