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
    public partial class FrmSaludo : Form
    {
        string nombre;
        string apellido;
        string materia;
        public FrmSaludo()
        {
            InitializeComponent();
            
        }

        public FrmSaludo(string nombre, string apellido): this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public FrmSaludo(string nombre, string apellido, string materias) : this(nombre,apellido)
        {
            this.materia = materias;
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
        }
    }
}
