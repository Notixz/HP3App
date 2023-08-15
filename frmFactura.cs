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
    public partial class frmFactura : Form
    {
        public int LBLID { get; set; }
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //  Nuevo registro
            if (LBLID == 0)
            {
                lblTittle.Location = new Point(239, 52);
                lblID.Text = "";

                lblDescuento_mod.Text = "";
                lblTotalIVA_mod.Text = "";
                lblTotalF_mod.Text = "";
            }
            //  Modificar registro
            else
            {
                lblTittle.Location = new Point(217, 52);
                lblTittle.Text = "Modificar factura";
                lblID.Text = $"ID: {LBLID.ToString()}";

                bttAñadir.Text = "Confirmar";
            }
        }
        private void bttAñadir_Click(object sender, EventArgs e)
        {
            if (txtbDatosAdicionales.Text != "")
            {
                if (lblTittle.Text.Contains("Modificar"))
                {
                    MessageBox.Show("Cambio realizado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Factura añadido con exito");
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
