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
    public partial class frmProducto : Form
    {
        public int LBLID { get; set; }
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(227, 57);
                lblID.Text = "";
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(205, 57);
                lblTittle.Text = "Modificar producto";
                lblID.Text = $"ID: {LBLID.ToString()}";

                txtbNombre.Text = "Nombre producto";
                txtbCodigo.Text = "Codigo producto";
                txtbPrecioC.Text = "Precio compra producto";
                txtPrecioV.Text = "Precio venta producto";
                txtbCantidad.Text = "Cantidad producto";
                txtbDescripcion.Text = "Descripcion del producto";

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbCodigo.Text != "" && txtbPrecioC.Text != "" && txtPrecioV.Text != "" && txtbCantidad.Text != "" && txtbDescripcion.Text != "")
            {
                if (lblTittle.Text.Contains("Modificar"))
                {
                    MessageBox.Show("Cambio realizado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Producto añadido con exito");
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
