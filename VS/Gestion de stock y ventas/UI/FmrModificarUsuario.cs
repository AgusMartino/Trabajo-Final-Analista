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
    public partial class FmrModificarUsuario : Form, IUsuarioSeleccionadoLisener
    {
        Usuario usuario = new Usuario();
        List<Perfil> perfils = new List<Perfil>();
        List<Permiso> permisos = new List<Permiso>();
        public FmrModificarUsuario()
        {
            InitializeComponent();
        }

        public void UsuarioSeleccionado(Usuario usuario)
        {
            try
            {
                //Obteniendo Usuario Seleccionado
                this.usuario = UsuarioService.Current.GetOne((int)usuario.IdUsuario);
                TxtUsuario.Text = usuario.usuario;
                if(usuario.Habilitado == true)
                {
                    RdbSi.Checked = true;    
                }
                if (usuario.Habilitado == false)
                {
                    RdbNo.Checked = false;
                }
                foreach (var item in this.usuario.Permisos)
                {
                    if (item.Cantidad_de_permisos > 0)
                    {
                        LtbPerfilesAgregados.Items.Add(item.Nombre);
                    }
                    else
                    {
                        LtbPermisosAgregados.Items.Add(item.Nombre);
                    }
                }
                perfils = (List<Perfil>)PerfilService.Current.GetAll();
                permisos = (List<Permiso>)PermisoService.Current.GetAll();
                LtbPerfiles.Items.Clear();
                LtbPermisos.Items.Clear();
                foreach (var item in perfils)
                {
                    if (!LtbPerfilesAgregados.Items.Contains(item.Nombre))
                    {
                        LtbPerfiles.Items.Add(item.Nombre);
                    }
                }
                foreach (var _item in permisos)
                {
                    if (!LtbPermisosAgregados.Items.Contains(_item.Nombre))
                    {
                        LtbPermisos.Items.Add(_item.Nombre);
                    }
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


        private void BtnBuscarUsuario_Click_1(object sender, EventArgs e)
        {
            //Mostrando Lista de Usuarios
            FmrListarUsuarios F = new FmrListarUsuarios(this);
            F.Show();
        }

        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            //Modificando usuario
            try
            {
                string mensaje = "";
                if(usuario.IdUsuario != null)
                {
                    if (ChcCambiarContraseña.Checked == true)
                    {
                        if (TxtContraseña.Text == TxtRepetirContraseña.Text)
                        {
                            usuario.Contraseña = TxtContraseña.Text;
                        }
                        else
                        {
                            mensaje = "Las Contraseñas no coinciden".Traducir(); ;
                        }
                    }
                    else
                    {
                        usuario.Contraseña = null;
                    }
                    if (RdbSi.Checked == true)
                    {
                        usuario.Habilitado = true;
                    }
                    else
                    {
                        if (RdbNo.Checked == true)
                        {
                            usuario.Habilitado = false;
                        }
                        else
                        {
                            mensaje = "Debe seleccionar si esta Habilitado o no".Traducir();
                        }
                    }
                    if (mensaje == "")
                    {
                        usuario.usuario = TxtUsuario.Text;
                        UsuarioService.Current.update(usuario);
                        LtbPerfiles.Items.Clear();
                        LtbPerfilesAgregados.Items.Clear();
                        LtbPermisos.Items.Clear();
                        LtbPermisosAgregados.Items.Clear();
                        TxtContraseña.Text = "";
                        TxtRepetirContraseña.Text = "";
                        TxtUsuario.Text = "";
                        this.usuario = new Usuario();
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
                        MessageBox.Show("Usuario Modificado".Traducir());

                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Usuario".Traducir());
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

        private void BtnAgregarPerfil_Click(object sender, EventArgs e)
        {
            try
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
                    }
                    this.usuario.Permisos.Add(perfilagregado);
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

        private void FmrModificarUsuario_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("390", helpProvider1, this);
            TraducirForm();
            try
            {
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

        private void BtnRemoverPerfil_Click(object sender, EventArgs e)
        {
            try
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
                    }
                    foreach (var permisosUsuario in usuario.Permisos)
                    {
                        if (permisosUsuario.Nombre == perfilRemovido.Nombre)
                        {
                            this.usuario.Permisos.Remove(permisosUsuario);
                        }
                    }
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

        private void BtnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
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
                    }
                }
                this.usuario.Permisos.Add(permisoAgregado);
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

        private void BtnRemoverPermiso_Click(object sender, EventArgs e)
        {
            try
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
                    }
                }
                foreach (var permisosUsuario in usuario.Permisos)
                {
                    if (permisosUsuario.Nombre == permisoRemovido.Nombre)
                    {
                        this.usuario.Permisos.Remove(permisosUsuario);
                    }
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

        private void ChcCambiarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Habilitado Cambio de Contraseña
                if (ChcCambiarContraseña.Checked == true)
                {
                    TxtRepetirContraseña.Enabled = true;
                    TxtContraseña.Enabled = true;
                }
                else
                {
                    TxtRepetirContraseña.Enabled = false;
                    TxtContraseña.Enabled = false;
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
            BtnBuscarUsuario.Text = BtnBuscarUsuario.Text.Traducir();
            BtnModificarEmpleado.Text = BtnModificarEmpleado.Text.Traducir();
            BtnRemoverPerfil.Text = BtnRemoverPerfil.Text.Traducir();
            BtnRemoverPermiso.Text = BtnRemoverPermiso.Text.Traducir();
            ChcCambiarContraseña.Text = ChcCambiarContraseña.Text.Traducir();
            RdbSi.Text = RdbSi.Text.Traducir();
            RdbNo.Text = RdbNo.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
        }
    }
}
