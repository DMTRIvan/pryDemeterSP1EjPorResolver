using System;
using System.IO;
using System.Windows.Forms;

namespace pryDemeterSP1EjPorResolver
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            frmConsultar objConsultar = new frmConsultar();
            objConsultar.ShowDialog();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtNumeroCliente.Text != "" && txtNombreCliente.Text != "")
            {
                StreamWriter clientes = new StreamWriter("./clientes.txt", true);     //Creo el archivo
                clientes.Close();          //Cierro el archivo clientes
                bool bandera = false;
                StreamReader numeros = new StreamReader("./clientes.txt");    //leo el archivo clientes
                char varSeparador = Convert.ToChar(".");

                while (!numeros.EndOfStream)
                {
                    string[] vecnombrenumeros = numeros.ReadLine().Split(varSeparador);


                    if (txtNumeroCliente.Text == vecnombrenumeros[0] && txtNombreCliente.Text == vecnombrenumeros[1])
                    {
                        MessageBox.Show("No se puede cargar, el cliente se repite");
                        bandera = true;
                    }
                }
                numeros.Close();              //cierro el archivo clientes

                if (bandera == false)
                {
                    StreamWriter grabar = new StreamWriter("./clientes.txt", true);      //abro el archivo para guardar
                    grabar.WriteLine(txtNumeroCliente.Text + "." + txtNombreCliente.Text);
                    MessageBox.Show("Se grabaron los datos");
                    grabar.Close();
                    txtNumeroCliente.Text = "";
                    txtNombreCliente.Text = "";
                }
                else
                {
                    txtNumeroCliente.Text = "";
                    txtNombreCliente.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
           



        }

        private void txtCargarVendedor_Click(object sender, EventArgs e)
        {
            if (txtNumeroVendedor.Text != "" && txtNombreVendedor.Text != "" && txtComision.Text != "")
            {
                StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);     //Creo el archivo
                vendedor.Close();          //Cierro el archivo vendedor
                bool bandera1 = false;
                StreamReader numeros1 = new StreamReader("./Vendedor.txt");    //leo el archivo vendedor
                char varSeparador1 = Convert.ToChar(".");

                while (!numeros1.EndOfStream)
                {
                    string[] vecnombrenumeros1 = numeros1.ReadLine().Split(varSeparador1);


                    if (txtNumeroVendedor.Text == vecnombrenumeros1[0] && txtNombreVendedor.Text == vecnombrenumeros1[1])
                    {
                        MessageBox.Show("No se puede cargar, el vendedor se repite");
                        bandera1 = true;
                    }
                }
                numeros1.Close();              //cierro el archivo vendedor

                if (bandera1 == false)
                {
                    StreamWriter grabar1 = new StreamWriter("./Vendedor.txt", true);      //abro el archivo para guardar
                    grabar1.WriteLine(txtNumeroVendedor.Text + "." + txtNombreVendedor.Text + "." + txtComision.Text);
                    MessageBox.Show("Se grabaron los datos");
                    grabar1.Close();
                    txtNumeroVendedor.Text = "";
                    txtNombreVendedor.Text = "";
                }
                else
                {
                    txtNumeroVendedor.Text = "";
                    txtNombreVendedor.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void cmdCargar1_Click(object sender, EventArgs e)
        {
            if (lstNombreVenta.SelectedIndex != -1 && lstIDCliente.SelectedIndex != -1 && txtFacturaVentass.Text != "" && txtNumeroDeFactura.Text != "" && txtMonto.Text != "")
            {
                StreamWriter ventas = new StreamWriter("./Ventas.txt", true);
                ventas.WriteLine(lstNombreVenta.Text + "." + lstIDCliente.Text + "." + txtFacturaVentass.Text + "." + txtNumeroDeFactura.Text + "." + dtpVenta.Text + "." + txtMonto.Text);
                MessageBox.Show("Venta cargada con exito");
                ventas.Close();
                lstNombreVenta.SelectedIndex = -1;
                lstIDCliente.SelectedIndex = -1;
                txtFacturaVentass.Text = "";
                txtNumeroDeFactura.Text = "";
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lstNombreVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            //StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);     //Creo el archivo
            //vendedor.Close();          //Cierro el archivo vendedor
            //StreamWriter clientes = new StreamWriter("./clientes.txt", true);     //Creo el archivo
            //clientes.Close();          //Cierro el archivo clientes

            //StreamReader lectorClientes = new StreamReader("./clientes.txt");
            //StreamReader lectorVendedor = new StreamReader("./Vendedor.txt");
            //char varSeparador = Convert.ToChar(".");

            //while (!lectorVendedor.EndOfStream)
            //{
            //    string[] vectorVendedor = lectorVendedor.ReadLine().Split(varSeparador);
            //    lstNombreVenta.Items.Add(vectorVendedor[0]);

            //}
            //lectorVendedor.Close();

            //while (!lectorClientes.EndOfStream)
            //{
            //    string[] vecCliente = lectorClientes.ReadLine().Split(varSeparador);
            //    lstIDCliente.Items.Add(vecCliente[0]);

            //}
            //lectorClientes.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstNombreVenta.Items.Clear();
            lstIDCliente.Items.Clear();
            StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);     //Creo el archivo
            vendedor.Close();          //Cierro el archivo vendedor
            StreamWriter clientes = new StreamWriter("./clientes.txt", true);     //Creo el archivo
            clientes.Close();          //Cierro el archivo clientes

            StreamReader lectorClientes = new StreamReader("./clientes.txt");
            StreamReader lectorVendedor = new StreamReader("./Vendedor.txt");
            char varSeparador = Convert.ToChar(".");

            while (!lectorVendedor.EndOfStream)
            {
                string[] vectorVendedor = lectorVendedor.ReadLine().Split(varSeparador);
                lstNombreVenta.Items.Add(vectorVendedor[0]);

            }
            lectorVendedor.Close();

            while (!lectorClientes.EndOfStream)
            {
                string[] vecCliente = lectorClientes.ReadLine().Split(varSeparador);
                lstIDCliente.Items.Add(vecCliente[0]);

            }
            lectorClientes.Close();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
