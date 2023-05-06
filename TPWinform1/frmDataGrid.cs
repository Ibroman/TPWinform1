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
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            int nombre = Convert.ToInt32(txtNombre.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Operation");
            dt.Columns.Add("Indice");
            dt.Columns.Add("Resultat");
            dataGridView1.DataSource = dt;

            switch (cbOperation.Text)
            {
                case "Addition":
                    
                    for (int i = 1; i <= 10; i++)
                    {
                        //StringBuilder chaine = new StringBuilder();
                        //chaine.AppendFormat("{0} + {1} = {2}", nombre, i, nombre + i);
                        //MessageBox.Show(chaine.ToString(), "Table d'addition");
                        DataRow dr = dt.NewRow(); 
                        dr["nombre"] = nombre;
                        dr["operation"] = "+";
                        dr["indice"] = i;
                        dr["resultat"] = nombre + i;
                        dt.Rows.Add(dr);
                        
                    }
                    break;
                case "Soustraction":
                    for (int i = 1; i <= 10; i++)
                    {
                        //StringBuilder chaine = new StringBuilder();
                        //chaine.AppendFormat("{0} - {1} = {2}", nombre, i, nombre - i);
                        //MessageBox.Show(chaine.ToString(), "Table de soustraction");
                        DataRow dr = dt.NewRow();
                        dr["nombre"] = nombre;
                        dr["operation"] = "-";
                        dr["indice"] = i;
                        dr["resultat"] = nombre - i;
                        dt.Rows.Add(dr);
                    }
                    break;
                case "Multiplication":
                    for (int i = 1; i <= 10; i++)
                    {
                        //StringBuilder chaine = new StringBuilder();
                        //chaine.AppendFormat("{0} * {1} = {2}", nombre, i, nombre * i);
                        //MessageBox.Show(chaine.ToString(), "Table de multiplication");
                        DataRow dr = dt.NewRow();
                        dr["nombre"] = nombre;
                        dr["operation"] = "*";
                        dr["indice"] = i;
                        dr["resultat"] = nombre * i;
                        dt.Rows.Add(dr);
                    }
                    break;
                case "Division":
                    for (int i = 1; i <= 10; i++)
                    {
                        //StringBuilder chaine = new StringBuilder();
                        //chaine.AppendFormat("{0} / {1} = {2}", nombre, i, (float)nombre / i);
                        //MessageBox.Show(chaine.ToString(), "Table de division");
                        DataRow dr = dt.NewRow();
                        dr["nombre"] = nombre;
                        dr["operation"] = "/";
                        dr["indice"] = i;
                        dr["resultat"] = (float)nombre / i;
                        dt.Rows.Add(dr);
                    }
                    break;
                default:

                    break;
            }

            
        }
    }
}
