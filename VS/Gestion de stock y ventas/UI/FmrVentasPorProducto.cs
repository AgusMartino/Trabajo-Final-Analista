using CrystalDecisions.Shared;
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
    public partial class FmrVentasPorProducto : Form
    {
        public FmrVentasPorProducto()
        {
            InitializeComponent();
        }

        private void FmrVentasPorProducto_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("450", helpProvider1, this);
            DateTime FechaDesde = DateTime.Today;
            DateTime Fechahasta = FechaDesde.AddHours(24);
            VentasPorProductoR1.SetParameterValue("Fecha Desde", FechaDesde);
            VentasPorProductoR1.SetParameterValue("Fecha Hasta", Fechahasta);
        }

    }
}
