using BLL.Services;
using SL.BLL.Services;
using SL.DOMAIN.SecurityComposite;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FmrLogin : Form
    {
        public FmrLogin()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Haciendo Login
                Usuario usuario = new Usuario();
                usuario.usuario = TxtUsuario.Text;
                usuario.Contraseña = TxtContraseña.Text;
                bool login = UsuarioService.Current.Login(usuario);
                if (login == true)
                {
                    FmrPrincipal F = new FmrPrincipal();
                    F.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña invalido");
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

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            if(CmbIdioma.Text == "Español".Traducir())
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");
            }
            if(CmbIdioma.Text == "Ingles".Traducir())
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            }
            Traducirform();
            CompletoCombo();
        }

        private void FmrLogin_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("300", helpProvider1, this);
            CompletoCombo();
        }

        public void Traducirform()
        {
            LblIdioma.Text = LblIdioma.Text.Traducir();
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnCambiarIdioma.Text = BtnCambiarIdioma.Text.Traducir();
            BtnIngresar.Text = BtnIngresar.Text.Traducir();
        }
        private void CompletoCombo()
        {
            List<string> Opciones = new List<string>();
            Opciones.Insert(0, "Ingles".Traducir());
            Opciones.Insert(1, "Español".Traducir());
            CmbIdioma.DataSource = Opciones;
        }
    }
}
