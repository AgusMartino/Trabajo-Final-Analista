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
    public partial class FmrModificarPerfil : Form, IPerfilSeleccionadoLisener
    {
        Perfil perfil = new Perfil();
        List<Perfil> perfils = new List<Perfil>();
        List<Permiso> permisos = new List<Permiso>();
        public FmrModificarPerfil()
        {
            InitializeComponent();
        }

        private void FmrModificarPerfil_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("480", helpProvider1, this);
            try
            {
                TraducirForm();
                //Listando Perfiles y Permisos
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

        private void BtnSeleccionarPerfil_Click(object sender, EventArgs e)
        {
            //Mostrando Listado de Perfiles
            FmrListarPerfil F = new FmrListarPerfil(this);
            F.Show();
        }

        public void PerfilSeleccionado(Perfil perfil)
        {
            //Obteniendo Perfil Seleccionado
            this.perfil = PerfilService.Current.GetOne((int)perfil.Id);
            TxtNombre.Text = perfil.Nombre;
            LtbPerfiles.Items.Clear();
            LtbPermisos.Items.Clear();
            perfils = (List<Perfil>)PerfilService.Current.GetAll();
            permisos = (List<Permiso>)PermisoService.Current.GetAll();
            foreach (var item in this.perfil.ListadoPermisos)
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
            foreach (var item in perfils)
            { 
                if(!LtbPerfilesAgregados.Items.Contains(item.Nombre))
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

        private void BtnAgregarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregando Perfil a listado de permisos del Perfil
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
                    this.perfil.Add(perfilagregado);
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
                //Removiendo Perfil de listado de Permisos del Perfil
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
                    foreach (var permisosUsuario in perfil.ListadoPermisos)
                    {
                        if (permisosUsuario.Nombre == perfilRemovido.Nombre)
                        {
                            this.perfil.ListadoPermisos.Remove(permisosUsuario);
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
                //Agregando Pemisos A listado de Permisos de Perfil
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
                this.perfil.Add(permisoAgregado);
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
                //Removiendo Permiso de Listado de permisos del Perfil
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
                foreach (var permisosUsuario in perfil.ListadoPermisos)
                {
                    if (permisosUsuario.Nombre == permisoRemovido.Nombre)
                    {
                        this.perfil.ListadoPermisos.Remove(permisosUsuario);
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

        private void BtnModificarPerfil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(perfil.Id == null)
                {
                    MessageBox.Show("Debe seleccionar un Perfil".Traducir());
                }
                perfil.Nombre = TxtNombre.Text;
                PerfilService.Current.update(perfil);
                LtbPerfiles.Items.Clear();
                LtbPerfilesAgregados.Items.Clear();
                LtbPermisos.Items.Clear();
                LtbPermisosAgregados.Items.Clear();
                TxtNombre.Text = "";
                this.perfil = new Perfil();
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
                MessageBox.Show("Perfil Modificado".Traducir());
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
            BtnAgregarPerfil.Text = BtnAgregarPerfil.Text.Traducir();
            BtnAgregarPermiso.Text = BtnAgregarPermiso.Text.Traducir();
            BtnModificarPerfil.Text = BtnModificarPerfil.Text.Traducir();
            BtnRemoverPerfil.Text = BtnRemoverPerfil.Text.Traducir();
            BtnSeleccionarPerfil.Text = BtnSeleccionarPerfil.Text.Traducir();
        }

    }
}
