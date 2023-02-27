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
    public partial class FmrListarRubros : Form
    {
        public IRubroSeleccionadoLisener rubroSeleccionadoLisener;
        public FmrListarRubros(IRubroSeleccionadoLisener rubroSeleccionadoLisener)
        {
            InitializeComponent();
            this.rubroSeleccionadoLisener = rubroSeleccionadoLisener;
        }

        private void FmrListaRubros_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("250", helpProvider1, this);
            BtnSeleccionarRubro.Text = BtnSeleccionarRubro.Text.Traducir();
            try
            {
                //Listando Rubro
                List<Rubro> rubros = new List<Rubro>();
                rubros = (List<Rubro>)RubroService.Current.GetAll();
                foreach (var item in rubros)
                {
                    DtgRubros.Rows.Add(item.Codigo_Rubro, item.Nombre);
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
            }          
        }

        private void BtnSeleccionarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Rubro
                Rubro rubro = new Rubro();
                int i = DtgRubros.CurrentRow.Index;
                rubro.Nombre = DtgRubros[1, i].Value.ToString();
                rubro.Codigo_Rubro = DtgRubros[0, i].Value.ToString();
                rubroSeleccionadoLisener.RubroSeleccionado(rubro);
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
