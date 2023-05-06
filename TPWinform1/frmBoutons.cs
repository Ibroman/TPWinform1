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
    public partial class frmBoutons : Form
    {
        public frmBoutons()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            int nombre = Convert.ToInt32(txtNombre.Text);
            for (int i = 1; i <= 10; i++)
            {
                StringBuilder chaine = new StringBuilder();
                chaine.AppendFormat("{0} + {1} = {2}", nombre, i, nombre + i);
                MessageBox.Show(chaine.ToString(), "Table d'addition");
            }
        }
    }
}
