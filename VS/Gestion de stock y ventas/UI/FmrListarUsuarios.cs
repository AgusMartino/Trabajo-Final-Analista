using BLL.Services;
using DOMAIN;
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
    public partial class FmrListarUsuarios : Form
    {
        public IUsuarioSeleccionadoLisener usuarioSeleccionadoLisener;
        public FmrListarUsuarios(IUsuarioSeleccionadoLisener usuarioSeleccionadoLisener)
        {
            InitializeComponent();
            this.usuarioSeleccionadoLisener = usuarioSeleccionadoLisener;
        }

        private void BrnSeleccioarUsuario_Click(object sender, EventArgs e)
        {
            //Mapeando Usuario
            Usuario usuario = new Usuario();
            int i = DtgUsuario.CurrentRow.Index;
            usuario.IdUsuario = int.Parse(DtgUsuario[0, i].Value.ToString());
            usuario.usuario = DtgUsuario[1, i].Value.ToString();
            usuario.Habilitado = bool.Parse(DtgUsuario[2, i].Value.ToString());
            usuarioSeleccionadoLisener.UsuarioSeleccionado(usuario);
            this.Hide();
        }

        private void FmrListarUsuarios_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("280", helpProvider1, this);
            try
            {
                BrnSeleccioarUsuario.Text = BrnSeleccioarUsuario.Text.Traducir();
                //Listando Usuarios
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = (List<Usuario>)UsuarioService.Current.GetAll();
                foreach (var item in usuarios)
                {
                    DtgUsuario.Rows.Add(item.IdUsuario, item.usuario, item.Habilitado);
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
    }
}
