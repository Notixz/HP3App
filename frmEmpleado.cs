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
    public partial class frmEmpleado : Form
    {
        public int LBLID { get; set; }
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(269, 52);
                lblID.Text = "";

                lblNombreE_mod.Visible = false;
                lblDocumento_mod.Visible = false;
                lblDireccion_mod.Visible = false;
                lblTelefono_mod.Visible = false;
                lblEmail_mod.Visible = false;
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(247, 52);
                lblTittle.Text = "Modificar empleado";
                lblID.Text = $"ID: {LBLID.ToString()}";

                lblNombreE_mod.Text = "Nombre empleado";
                lblDocumento_mod.Text = "Documento empleado";
                lblDireccion_mod.Text = "Direccion empleado";
                lblTelefono_mod.Text = "Telefono empleado";
                lblEmail_mod.Text = "Email empleado";

                txtbNombre.Visible = false;
                txtbDocumento.Visible = false;
                txtbDireccion.Visible = false;
                txtbTelefono.Visible = false;
                txtbEmail.Visible = false;

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbDocumento.Text != "" && txtbDireccion.Text != "" && txtbTelefono.Text != "" && txtbEmail.Text != "")
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
