using SL.DOMAIN;
using SL.DOMAIN.SecurityComposite;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDeTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrGestionTurnos F = new FmrGestionTurnos();
            F.MdiParent = this;
            F.Show();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrRealizarVenta F = new FmrRealizarVenta();
            F.MdiParent = this;
            F.Show();
        }

        private void cancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCancelarVenta F = new FmrCancelarVenta();
            F.MdiParent = this;
            F.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FmrGestionCaja F = new FmrGestionCaja();
            F.MdiParent = this;
            F.Show();
        }

        private void altaRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaRubro F = new FmrAltaRubro();
            F.MdiParent = this;
            F.Show();
        }

        private void modificacionRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarRubro F = new FmrModificarRubro();
            F.MdiParent = this;
            F.Show();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaCliente F = new FmrAltaCliente();
            F.MdiParent = this;
            F.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarCliente F = new FmrModificarCliente();
            F.MdiParent = this;
            F.Show();
        }

        private void altaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaProveedor F = new FmrAltaProveedor();
            F.MdiParent = this;
            F.Show();
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarProveedor F = new FmrModificarProveedor();
            F.MdiParent = this;
            F.Show();
        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaEmpleado F = new FmrAltaEmpleado();
            F.MdiParent = this;
            F.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarEmpleado F = new FmrModificarEmpleado();
            F.MdiParent = this;
            F.Show();
        }

        private void altaServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaServicio F = new FmrAltaServicio();
            F.MdiParent = this;
            F.Show();
        }

        private void modificarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarServicio F = new FmrModificarServicio();
            F.MdiParent = this;
            F.Show();
        }

        private void listarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FmrGestionInventario F = new FmrGestionInventario();
            F.MdiParent = this;
            F.Show();
        }

        private void resumenOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrVentasPorProducto F = new FmrVentasPorProducto();
            F.MdiParent = this;
            F.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrInventario F = new FmrInventario();
            F.MdiParent = this;
            F.Show();
        }

        private void altaMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaMateriaPrima F = new FmrAltaMateriaPrima();
            F.Show();
            F.MdiParent = this;
        }

        private void modificarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarMateriaPrima F = new FmrModificarMateriaPrima();
            F.Show();
            F.MdiParent = this;
        }

        private void altaProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrAltaProducto F = new FmrAltaProducto();
            F.Show();
            F.MdiParent = this;
        }

        private void modificarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrModificarProducto F = new FmrModificarProducto();
            F.Show();
            F.MdiParent = this;
        }

        private void realizarPagoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrPagoProveedor F = new FmrPagoProveedor();
            F.MdiParent = this;
            F.Show();
        }

        private void cancelarPagoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCancelarPagoProveedor F = new FmrCancelarPagoProveedor();
            F.Show();
            F.MdiParent = this;
        }

        private void realizarPagoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrPagoEmpleado F = new FmrPagoEmpleado();
            F.MdiParent = this;
            F.Show();
        }

        private void cancelarPagoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCancelarPagoEmpleado F = new FmrCancelarPagoEmpleado();
            F.Show();
            F.MdiParent = this;
        }

        private void realizarPagoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrPagoServicio F = new FmrPagoServicio();
            F.MdiParent = this;
            F.Show();
        }

        private void cancelarPagoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCancelarPagoServicio F = new FmrCancelarPagoServicio();
            F.Show();
            F.MdiParent = this;
        }

        private void altaUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrAltaUsuario F = new FmrAltaUsuario();
            F.Show();
            F.MdiParent = this;
        }

        private void modificarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmrModificarUsuario F = new FmrModificarUsuario();
            F.Show();
            F.MdiParent = this;
        }

        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrCrearPerfil F = new FmrCrearPerfil();
            F.MdiParent = this;
            F.Show();
        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrModificarPerfil F = new FmrModificarPerfil();
            F.MdiParent = this;
            F.Show();
        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("430", helpProvider1, this);
            List<string> permisos = new List<string>();
            List<string> Roles = new List<string>();
            foreach (var item in LoginCache.Roles)
            {
                Roles.Add(item.Nombre);
            }
            foreach (var item in LoginCache.PermisoMenu)
            {
                permisos.Add(item.Nombre);
            }
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.DropDownItems.Count > 0)
                {
                    foreach (ToolStripMenuItem subitem in item.DropDownItems)
                    {
                        if (subitem.DropDownItems.Count > 0)
                        {
                            foreach (ToolStripMenuItem Hoja in subitem.DropDownItems)
                            {
                                if (Hoja.DropDownItems.Count == 0)
                                {
                                    if (permisos.Contains(Hoja.Text))
                                    {
                                        Hoja.Visible = true;
                                    }
                                    else
                                    {
                                        Hoja.Visible = false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (permisos.Contains(subitem.Text))
                            {
                                subitem.Visible = true;
                            }
                            else
                            {
                                if (Roles.Contains(subitem.Text))
                                {
                                    subitem.Visible = true;
                                }
                                else
                                {
                                    subitem.Visible = false;
                                }
                            }
                        }
                    }
                }
                if (permisos.Contains(item.Text))
                {
                   item.Visible = true;
                }
                else
                {
                    if (Roles.Contains(item.Text))
                    {
                       item.Visible = true;
                    }
                    else
                    {
                       item.Visible = false;
                    }
                }
            }
            TraducirForm();
        }
           
        private void BtnCerrarsecion_Click(object sender, EventArgs e)
        {
            FmrLogin F = new FmrLogin();
            F.Show();
            LoginCache.IdUsuario = null;
            LoginCache.Usuario = null;
            LoginCache.Contraseña = null;
            LoginCache.Codigo_idioma = null;
            LoginCache.Habilitado = null;
            LoginCache.Permisos.Clear();
            this.Hide();
        }
        
        public void TraducirForm()
        {
            BtnCerrarsecion.Text = BtnCerrarsecion.Text.Traducir();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.DropDownItems.Count > 0)
                {
                    foreach (ToolStripMenuItem subitem in item.DropDownItems)
                    {
                        if (subitem.DropDownItems.Count > 0)
                        {
                            foreach (ToolStripMenuItem hoja in subitem.DropDownItems)
                            {
                               hoja.Text = hoja.Text.Traducir();
                            }
                        }
                        subitem.Text = subitem.Text.Traducir();
                    }
                }
                item.Text = item.Text.Traducir();
            }
        }

        private void altaProductoMasivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAltaProductoMasiva F = new FmrAltaProductoMasiva();
            F.MdiParent = this;
            F.Show();
        }
    }
}
