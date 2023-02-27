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
    public partial class FmrModificarRubro : Form, IRubroSeleccionadoLisener
    {
        Rubro Rubro = new Rubro();
        public FmrModificarRubro()
        {
            InitializeComponent();
        }

        private void BtnModificarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                if(Rubro.Codigo_Rubro == null)
                {
                    MessageBox.Show("Debe seleccionar un Rubro".Traducir());
                }
                else
                {
                    //Modificando Rubro
                    Rubro.Codigo_Rubro = TxtCodigoRubro.Text;
                    Rubro.Nombre = TxtNombre.Text;
                    RubroService.Current.update(Rubro);
                    TxtCodigoRubro.Text = "";
                    TxtNombre.Text = "";
                    MessageBox.Show($"Rubro modificado".Traducir());
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

        private void BtnBuscarRubro_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Rubros
            FmrListarRubros F = new FmrListarRubros(this);
            F.Show();
        }

        public void RubroSeleccionado(Rubro rubro)
        {
            //Obteniendo Rubro seleccionado
            TxtCodigoRubro.Text = rubro.Codigo_Rubro;
            TxtCodigoRubro.Enabled = false;
            TxtNombre.Text = rubro.Nombre;
        }

        private void FmrModificarRubro_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("350", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnBuscarRubro.Text = BtnBuscarRubro.Text.Traducir();
            BtnModificarRubro.Text = BtnModificarRubro.Text.Traducir();
        }
    }
}
