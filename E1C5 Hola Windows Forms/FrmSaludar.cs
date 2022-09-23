using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1C5_Hola_Windows_Forms
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                GenerarMensaje();
            }
            else
            {
                FrmSaludo frmSaludo = new FrmSaludo(txtNombre.Text, txtApellido.Text, cmbMaterias.Text);
                frmSaludo.ShowDialog();
            }
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
            cmbMaterias.SelectedIndex = 0;
        }

        private void GenerarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los siguientes campos:");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                sb.AppendLine("Apellido");
            }
            
            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
    }
}
