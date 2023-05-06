using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinform1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            string message = "Vous vous appelez " + txtNom.Text + ", et vous êtes agé de " + txtAge.Text + " ans.";
            message += "\nVous êtes né en " + (2023 - Convert.ToInt32(txtAge.Text));
            MessageBox.Show(message);
        }
    }
}
