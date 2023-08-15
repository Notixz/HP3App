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
    public partial class frmCategoria : Form
    {
        public int LBLID { get; set; }
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(82, 57);
                lblID.Text = "";
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(60, 57);
                lblTittle.Text = "Modificar categoria";
                lblID.Text=$"ID: {LBLID.ToString()}";
                txtbNombre.Text = "Nombre de la categoria";
                txtbDescripcion.Text = "Descripcion de la categoria";

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbDescripcion.Text != "")
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
