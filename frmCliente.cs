using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP3
{
    public partial class frmCliente : Form
    {
        public int LBLID { get; set; }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(105, 50);
                lblID.Text = "";
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(83, 50);
                lblTittle.Text = "Modificar cliente";
                lblID.Text = $"ID: {LBLID.ToString()}";
                txtbNombre.Text = "Nombre 1 Apellido 1";
                txtbDocumento.Text = "Documento del cliente";
                txtbDireccion.Text = "Calle donde vive el cliente";
                txtbTelefono.Text = "Telefono del cliente";

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbDocumento.Text != "" && txtbDireccion.Text != "" && txtbTelefono.Text != "")
            {
                if (lblTittle.Text.Contains("Modificar"))
                {
                    MessageBox.Show("Cambio realizado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cliente añadido con exito");
                    this.Close();
                }
            }
        }
        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
