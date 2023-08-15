using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HP3
{
    public partial class frmMain : Form
    {
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        public frmMain()
        {
            InitializeComponent();

            //  Llenar los dataGridView
            agregarDatos();
        }

        //  Definiciones para metodos
        private string bttName;
        private string newName;
        private int yPos = 0;

        private string altBttName;

        private string modBttName;

        DataTable dt = new DataTable();
        Random rnd = new Random();

        frmCliente Cliente = new frmCliente();
        frmProducto Producto = new frmProducto();
        frmCategoria Categoria = new frmCategoria();

        frmFactura Factura = new frmFactura();

        frmEmpleado Empleado = new frmEmpleado();
        frmRol Rol = new frmRol();
        frmSeguridad Seguridad = new frmSeguridad();

        //  Metodos
        public void moverIndicador(int Y)
        {
            indicator.Location = new Point(indicator.Location.X, Y);
            indicator.BringToFront();
        }
        public string actualizarNombre(string bttName)
        {
            //  Definicion de variables
            string modName;
            string aRemover;

            //  Modificaciones para mover los tabPages
            if (bttName.StartsWith("main"))
            {
                aRemover = "main";
                modName = bttName.Replace(aRemover, "");
                return modName;
            }
            else if (bttName.StartsWith("tablas"))
            {
                aRemover = "tablas";
                modName = bttName.Replace(aRemover, "");
                return modName;
            }
            else if (bttName.StartsWith("facturacion"))
            {
                aRemover = "facturacion";
                modName = bttName.Replace(aRemover, "");
                return modName;
            }
            else if (bttName.StartsWith("seguridad"))
            {
                aRemover = "seguridad";
                modName = bttName.Replace(aRemover, "");
                return modName;
            }
            else if (bttName.StartsWith("acerca"))
            {
                aRemover = "acerca";
                modName = bttName.Replace(aRemover, "");
                return modName;
            }
            
            else
            {
                MessageBox.Show("No se pudo realizar el cambio en la variable");
                modName = bttName;
                return modName;
            }
        }
        public string removerBtt(string bttName)
        {
            //  Definicion de variables
            string modName;
            string aRemover;

            //  Eliminacion de "Btt"
            aRemover = "Btt";
            modName = bttName.Replace(aRemover, "");
            return modName;
        }
        public string removerAñadir(string bttName)
        {
            //  Definicion de variables
            string modName;
            string aRemover;

            //  Eliminacion de "Añadir"
            aRemover = "Añadir";
            modName = bttName.Replace(aRemover, "");
            return modName;
        }
        public void moverPageTabs(string actName)
        {
            //  Cambia las tabPages del mainPages
            mainPages.SetPage(actName);

            //  Cambia las tabPages del pagesTablas
            pagesTablas.SetPage(actName);

            //  Cambia las tabPages del pagesFacturacion
            pagesFacturacion.SetPage(actName);

            //  Cambia las tabPages del pagesSeguridad
            pagesSeguridad.SetPage(actName);

            //  Cambia las tabPages del pagesAcerca
            pagesAcerca.SetPage(actName);
        }
        //  Metodos para llenar dataGridViews
        public void agregarDatos()
        {
            //  Llenar tablasDtClientes
            for (int i = 1; i < 10; i++)
            {
                tablasDtClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2 ", $"{rnd.Next(1000, 100000)}", $"3{rnd.Next(3000, 999999999)}");
            }
            //  Llenar tablasDtProductos
            for (int i = 1; i < 10; i++)
            {
                tablasDtProductos.Rows.Add(i, $"Producto {i}", $"{rnd.Next(1, 999999999)}", $"{2 * rnd.Next(9999, 99999)}", $"{2 * rnd.Next(9999, 99999)}", $"{rnd.Next(1, 1000)}");
            }
            //  Llenar tablasDtCategorias
            for (int i = 1; i < 10; i++)
            {
                tablasDtCategorias.Rows.Add(i * rnd.Next(999, 9999), $"Descripcion categoria {i}");
            }

            //  Llenar facturacionDtFacturas
            for (int i = 1; i < 10; i++)
            {
                facturacionDtFacturas.Rows.Add(i * rnd.Next(999, 9999), $"Cliente {i}", $"{i}/0{i}/2023", i * rnd.Next(444, 4444), "Pendiente");
            }

            //  Llenar seguridadDtEmpleados
            for (int i = 1; i < 10; i++)
            {
                seguridadDtEmpleados.Rows.Add(i, $"Nombre {i} Apellido 1 Apellido 2", rnd.Next(1000, 999999), rnd.Next(999, 999999));
            }
            //  Llenar seguridadDtRoles
            for (int i = 1; i < 10; i++)
            {
                seguridadDtRoles.Rows.Add(i, $"Nombre del Rol {i}");
            }
            //  Llenar seguridadDtSeguridad
            for (int i = 1; i < 10; i++)
            {
                seguridadDtSeguridad.Rows.Add(i, rnd.Next(246, 999999), $"Persona {i} Apellido 1 Apellido 2");
            }
        }
        //  Preparacion de botones para metodos

        //  Botones izquierdos principales
        private void mainClickBotones(object sender, EventArgs e)
        {
            // Opciones para obtener campos del boton
            BunifuButton botonClickeado = (BunifuButton)sender;

            // Obtiene el Nombre del Boton
            bttName = botonClickeado.Name;

            // Obtiene la posicion "Y" del boton
            yPos = botonClickeado.Location.Y;

            // Nuevo nombre Retornado (con la modificacion incluida)
            newName = actualizarNombre(bttName);
            newName = removerBtt(newName);

            // Ejecuta los metodos para el pageMain
            moverPageTabs(newName); // Utiliza newName en lugar de bttName
            moverIndicador(yPos);
        }
        //  Botones superiores alternativos
        private void altClickBotones(object sender, EventArgs e)
        {
            // Opciones para obtener campos del boton
            BunifuButton botonClickeado = (BunifuButton)sender;

            // Obtiene el Nombre del Boton + primera modificacion del nombre del boton
            altBttName = botonClickeado.Name;

            //  Segunda modificacion del nombre del boton
            newName = actualizarNombre(altBttName);
            newName = removerBtt(newName);

            //  Mueve los pageTabs
            moverPageTabs(newName);
        }
        //  Botones Añadir/Modificar
        private void modClickBotones(object sender, EventArgs e)
        {
            BunifuButton botonClickeado = (BunifuButton)sender;

            modBttName = botonClickeado.Name;

            newName = actualizarNombre(modBttName);

            newName = removerBtt(newName);

            newName = removerAñadir(newName);

            if (newName == "Clientes")
            {
                Cliente.Show();
            }
            else if (newName == "Productos")
            {
                Producto.Show();
            }
            else if (newName == "Categorias")
            {
                Categoria.Show();
            }
            else if (newName == "Facturas")
            {
                Factura.Show();
            }
            else if (newName == "Empleados")
            {
                Empleado.Show();
            }
            else if (newName == "Roles")
            {
                Rol.Show();
            }
            else if (newName =="Seguridad")
            {
                Seguridad.Show();
            }
        }
        //  Boton cerrar sesion - Salir
        private void mainBttExit_Click(object sender, EventArgs e)
        {
            //  Hay que mejorar el metodo para que si cierre el programa
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }
        private void dtButtonsClick(object sender, DataGridViewCellEventArgs e)
        {
            //  tablasDtClientes
            if (this.tablasDtClientes.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = tablasDtClientes.CurrentRow.Index;
                Cliente.LBLID = int.Parse(tablasDtClientes[0, posActual].Value.ToString());
                Cliente.ShowDialog();
            }
            if (this.tablasDtClientes.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                tablasDtClientes.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  tablasDtProductos
            if (this.tablasDtProductos.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = tablasDtProductos.CurrentRow.Index;
                Producto.LBLID = int.Parse(tablasDtProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();
            }
            if (this.tablasDtProductos.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                tablasDtProductos.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  tablasDtCategorias
            if (this.tablasDtCategorias.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = tablasDtCategorias.CurrentRow.Index;
                Categoria.LBLID = int.Parse(tablasDtCategorias[0, posActual].Value.ToString());
                Categoria.ShowDialog();
            }
            if (this.tablasDtCategorias.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                tablasDtCategorias.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  facturacionDtFacturas
            if (this.facturacionDtFacturas.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = facturacionDtFacturas.CurrentRow.Index;
                Factura.LBLID = int.Parse(facturacionDtFacturas[0, posActual].Value.ToString());
                Factura.ShowDialog(); // Corregido aquí
            }
            if (this.facturacionDtFacturas.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                facturacionDtFacturas.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  seguridadDtEmpleados
            if (this.seguridadDtEmpleados.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = seguridadDtEmpleados.CurrentRow.Index;
                Empleado.LBLID = int.Parse(seguridadDtEmpleados[0, posActual].Value.ToString());
                Empleado.ShowDialog();
            }
            if (this.seguridadDtEmpleados.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                seguridadDtEmpleados.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  seguridadDtRoles
            if (this.seguridadDtRoles.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = seguridadDtRoles.CurrentRow.Index;
                Rol.LBLID = int.Parse(seguridadDtRoles[0, posActual].Value.ToString());
                Rol.ShowDialog();
            }
            if (this.seguridadDtRoles.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                seguridadDtRoles.Rows.Remove(tablasDtClientes.CurrentRow);
            }

            //  seguridadDtSeguridad
            if (this.seguridadDtSeguridad.Columns[e.ColumnIndex].Name.Contains("DtEditar"))
            {
                int posActual = seguridadDtSeguridad.CurrentRow.Index;
                Seguridad.LBLID = int.Parse(seguridadDtSeguridad[0, posActual].Value.ToString());
                Seguridad.ShowDialog();
            }
            if (this.seguridadDtSeguridad.Columns[e.ColumnIndex].Name.Contains("DtBorrar"))
            {
                seguridadDtSeguridad.Rows.Remove(tablasDtClientes.CurrentRow);
            }
        }
    }
}