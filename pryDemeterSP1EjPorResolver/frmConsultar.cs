using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterSP1EjPorResolver
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConsultarVenta_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();

            StreamReader srLectorVentas = new StreamReader("./Ventas.txt");


            while (!srLectorVentas.EndOfStream)
            {
                string varVentas = srLectorVentas.ReadLine();
                string[] vecVentas = varVentas.Split('.');
                dgvConsultaVentas.Rows.Add(vecVentas[2], vecVentas[3], vecVentas[4], vecVentas[1], vecVentas[0], vecVentas[5]);
            }
            srLectorVentas.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
