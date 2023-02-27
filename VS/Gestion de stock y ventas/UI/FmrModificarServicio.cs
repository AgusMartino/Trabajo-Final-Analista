using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMAIN;
using BLL.Services;
using UI.Lisener;
using SL.Services.Extensions;

namespace UI
{
    public partial class FmrModificarServicio : Form, IServicioSeleccionadoLisener
    {
        public Servicio servicio = new Servicio();
        public FmrModificarServicio()
        {
            InitializeComponent();
        }

        private void BtnModificarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if(servicio.CodigoServicio == null)
                {
                    MessageBox.Show("Debe seleccionar un servicio".Traducir());
                }
                else
                {
                    //Modificando Servicio
                    this.servicio = new Servicio();
                    this.servicio.CodigoServicio = TxtCodigoServicio.Text;
                    this.servicio.Nombre = TxtNombre.Text;
                    ServicioService.Current.update(servicio);
                    TxtCodigoServicio.Text = "";
                    TxtNombre.Text = "";
                    MessageBox.Show($"Servicio modificado".Traducir());
                }               
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void BtnBuscarServicio_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Servicios
            FmrListarServicio F = new FmrListarServicio(this);
            F.Show();
        }

        public void ServicioSeleccionado(Servicio servicio)
        {
            //Obteniendo servicio seleccionado
            TxtCodigoServicio.Text = servicio.CodigoServicio;
            TxtCodigoServicio.Enabled = false;
            TxtNombre.Text = servicio.Nombre;
        }

        private void FmrModificarServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("380", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnBuscarServicio.Text = BtnBuscarServicio.Text.Traducir();
            BtnModificarServicio.Text = BtnModificarServicio.Text.Traducir();
        }
    }
}
