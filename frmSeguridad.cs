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
    public partial class frmSeguridad : Form
    {
        public int LBLID { get; set; }
        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(78, 57);
                lblID.Text = "";
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(100, 57);
                lblTittle.Text = "Modificar usuario";
                lblID.Text = $"ID: {LBLID.ToString()}";
                txtbNombre.Text = "Nombre usuario";
                txtbDocumento.Text = "Documento usuario";
                txtbUsuario.Text = "Usuario";
                txtbContraseña.Text = "Contraseña";

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbDocumento.Text != "" && txtbUsuario.Text != "" && txtbContraseña.Text != "")
            {
                if (lblTittle.Text.Contains("Modificar"))
                {
                    MessageBox.Show("Cambio realizado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario añadido con exito");
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
