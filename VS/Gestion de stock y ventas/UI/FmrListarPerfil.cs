using SL.BLL.Services;
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
using UI.Lisener;

namespace UI
{
    public partial class FmrListarPerfil : Form
    {
        private IPerfilSeleccionadoLisener perfilSeleccionadoLisener;
        public FmrListarPerfil(IPerfilSeleccionadoLisener perfilSeleccionadoLisener)
        {
            InitializeComponent();
            this.perfilSeleccionadoLisener = perfilSeleccionadoLisener;
        }

        private void FmrListarPerfil_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("470", helpProvider1, this);
            BtnSeleccionarPerfil.Text = BtnSeleccionarPerfil.Text.Traducir();
            try
            {
                //Listando Perfiles
                List<Perfil> perfils = new List<Perfil>();
                perfils = (List<Perfil>)PerfilService.Current.GetAll();
                foreach (var item in perfils)
                {
                    DtgPerfil.Rows.Add(item.Id, item.Nombre);
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

        private void BtnSeleccionarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                //Mapeando Perfil
                Perfil perfil = new Perfil();
                int i = DtgPerfil.CurrentRow.Index;
                perfil.Id = int.Parse(DtgPerfil[0, i].Value.ToString());
                perfil.Nombre = DtgPerfil[1, i].Value.ToString();
                perfilSeleccionadoLisener.PerfilSeleccionado(perfil);
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
