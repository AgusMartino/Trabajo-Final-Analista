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
    public partial class FmrAltaUsuario : Form
    {
        List<Perfil> perfils = new List<Perfil>();
        List<Permiso> permisos = new List<Permiso>();
        Usuario usuario = new Usuario();
        public FmrAltaUsuario()
        {
            InitializeComponent();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
             try
             {
                //Realizando Alta de Usuario
                usuario.usuario = TxtUsuario.Text;
                if(TxtContraseña.Text == TxtRepetirContraseña.Text)
                {
                    if (RdbSi.Checked == true)
                    {
                        usuario.Habilitado = true;
                    }
                    if (RdbNo.Checked == true)
                    {
                        usuario.Habilitado = false;
                    }
                    usuario.Contraseña = TxtContraseña.Text;
                    UsuarioService.Current.insert(usuario);
                    LtbPerfiles.Items.Clear();
                    LtbPerfilesAgregados.Items.Clear();
                    LtbPermisos.Items.Clear();
                    LtbPermisosAgregados.Items.Clear();
                    TxtUsuario.Text = "";
                    TxtContraseña.Text = "";
                    TxtRepetirContraseña.Text = "";
                    RdbSi.Checked = true;
                    RdbNo.Checked = false;
                    perfils = (List<Perfil>)PerfilService.Current.GetAll();
                    permisos = (List<Permiso>)PermisoService.Current.GetAll();
                    foreach (var item in perfils)
                    {
                        LtbPerfiles.Items.Add(item.Nombre);
                    }
                    foreach (var item in permisos)
                    {
                        LtbPermisos.Items.Add(item.Nombre);
                    }
                    MessageBox.Show("Usuario dado de alta".Traducir());
                }
                else
                {
                    //Error de que no coinciden contraseña
                    MessageBox.Show("Las Contraseñas no coinciden".Traducir());
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

        private void FmrAltaUsuario_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("70", helpProvider1, this);
            //Mostrando Permisos y Pefiles Disponibles
            perfils = (List<Perfil>)PerfilService.Current.GetAll();
            permisos = (List<Permiso>)PermisoService.Current.GetAll();
            foreach (var item in perfils)
            {
                LtbPerfiles.Items.Add(item.Nombre);
            }
            foreach (var item in permisos)
            {
                LtbPermisos.Items.Add(item.Nombre);
            }
        }

        private void BtnAgregarPerfil_Click(object sender, EventArgs e)
        {
            //Agregado Perfil a lista de permisos del usuario que se va a dar de Alta
            Perfil perfilagregado = new Perfil();
            string item = LtbPerfiles.SelectedItem.ToString();
            foreach (var perfil in perfils)
            {
                if (perfil.Nombre == item)
                {
                    perfilagregado = perfil;
                    LtbPerfiles.Items.Remove(item);
                    LtbPerfilesAgregados.Items.Add(item);
                    this.usuario.Permisos.Add(perfilagregado);
                }                
            }
        }

        private void BtnRemoverPerfil_Click(object sender, EventArgs e)
        {
            // Sacando Perfil de lista de permisos del usuario que se va a dar de Alta
            Perfil perfilRemovido = new Perfil();
            string item = LtbPerfilesAgregados.SelectedItem.ToString();
            foreach (var perfil in perfils)
            {
                if (perfil.Nombre == item)
                {
                    perfilRemovido = perfil;
                    LtbPerfilesAgregados.Items.Remove(item);
                    LtbPerfiles.Items.Add(item);
                    foreach (var permisosUsuario in usuario.Permisos)
                    {
                        if (permisosUsuario.Nombre == perfilRemovido.Nombre)
                        {
                            this.usuario.Permisos.Remove(permisosUsuario);
                        }
                    }
                }               
            }
        }

        private void BtnAgregarPermiso_Click(object sender, EventArgs e)
        {
            // Agregado Permiso a lista de permisos del usuario que se va a dar de Alta
            Permiso permisoAgregado = new Permiso();
            string item = LtbPermisos.SelectedItem.ToString();
            foreach (var permiso in permisos)
            {
                if (permiso.Nombre == item)
                {
                    permisoAgregado = permiso;
                    LtbPermisosAgregados.Items.Add(item);
                    LtbPermisos.Items.Remove(item);
                    this.usuario.Permisos.Add(permisoAgregado);
                }
            }         
        }

        private void BtnRemoverPermiso_Click(object sender, EventArgs e)
        {
            // Sacando permiso de lista de permisos del usuario que se va a dar de Alta
            Permiso permisoRemovido = new Permiso();
            string item = LtbPermisosAgregados.SelectedItem.ToString();
            foreach (var permiso in permisos)
            {
                if (permiso.Nombre == item)
                {
                    permisoRemovido = permiso;
                    LtbPermisosAgregados.Items.Remove(item);
                    LtbPermisos.Items.Add(item);
                    foreach (var permisosUsuario in usuario.Permisos)
                    {
                        if (permisosUsuario.Nombre == permisoRemovido.Nombre)
                        {
                            this.usuario.Permisos.Remove(permisosUsuario);
                        }
                    }
                }
            }           
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label8.Text = label8.Text.Traducir();
            BtnAgregarPerfil.Text = BtnAgregarPerfil.Text.Traducir();
            BtnAgregarPermiso.Text = BtnAgregarPermiso.Text.Traducir();
            BtnCrearUsuario.Text = BtnCrearUsuario.Text.Traducir();
            BtnRemoverPerfil.Text = BtnRemoverPerfil.Text.Traducir();
            BtnRemoverPermiso.Text = BtnRemoverPermiso.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
            RdbSi.Text = RdbSi.Text.Traducir();
            RdbNo.Text = RdbNo.Text.Traducir();
        }
    }
}
