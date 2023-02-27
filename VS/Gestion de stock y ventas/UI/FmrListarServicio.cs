using BLL.Services;
using DOMAIN;
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
using UI.Lisener;

namespace UI
{
    public partial class FmrListarServicio : Form
    {
        public IServicioSeleccionadoLisener ServicioSeleccionadoLisener;
        public FmrListarServicio(IServicioSeleccionadoLisener ServicioSeleccionadoLisener)
        {
            InitializeComponent();
            this.ServicioSeleccionadoLisener = ServicioSeleccionadoLisener;
        }

        private void FmrListarServicio_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("260", helpProvider1, this);
            try
            {
                BtnSeleccionarServicio.Text = BtnSeleccionarServicio.Text.Traducir();
                //Listando Servicios
                List<Servicio> servicios = new List<Servicio>();
                servicios = (List<Servicio>)ServicioService.Current.GetAll();
                foreach (var item in servicios)
                {
                    DtgServicio.Rows.Add(item.CodigoServicio, item.Nombre);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
            }            
        }

        private void BtnSeleccionarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Servicio
                Servicio servicio = new Servicio();
                int i = DtgServicio.CurrentRow.Index;
                servicio.CodigoServicio = DtgServicio[0, i].Value.ToString();
                servicio.Nombre = DtgServicio[1, i].Value.ToString();
                ServicioSeleccionadoLisener.ServicioSeleccionado(servicio);
                this.Hide();
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
    }
}
