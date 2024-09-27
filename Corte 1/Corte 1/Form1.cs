using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte_1
{
    public partial class Form1 : Form
    {
        public object Fecha { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.FechaNac = Fecha.Value;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
        }
    }
}
