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

namespace UI
{
    public partial class FmrCrearPerfil : Form
    {
        Perfil perfil = new Perfil();
        List<Perfil> perfils = new List<Perfil>();
        List<Permiso> permisos = new List<Permiso>();
        public FmrCrearPerfil()
        {
            InitializeComponent();
        }

        private void BtnCrearPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (perfil.Cantidad_de_permisos == 0)
                {
                    MessageBox.Show("Debe Seleccionar un Perfil o un Permiso".Traducir());
                }
                else
                {
                    //Creando Perfil
                    Perfil perfilinsert = new Perfil();
                    perfilinsert.Nombre = TxtNombre.Text;
                    foreach (var item in perfil.ListadoPermisos)
                    {
                        perfilinsert.Add(item);
                    }
                    PerfilService.Current.insert(perfilinsert);
                    LtbPerfiles.Items.Clear();
                    LtbPerfilesAgregados.Items.Clear();
                    LtbPermisos.Items.Clear();
                    LtbPermisosAgregados.Items.Clear();
                    TxtNombre.Text = "";
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
                    MessageBox.Show("Perfil Creado".Traducir());
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

        private void FmrCrearPerfil_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("120", helpProvider1, this);
            TraducirForm();
            try
            {
                //Obteniendo listado de Permisos y Pefiles
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

        private void BtnAgregarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                //Ingresando Perfil en nuevo Perfil
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
                //Removiendo Perfil de Perfil nuevo
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
                    this.perfil.Remove(perfilRemovido);
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
                //Agregado Permiso a nuevo Perfil
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
                //Removiendo Permiso de Nuevo Perfil
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
                this.perfil.Remove(permisoRemovido);
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
            BtnCrearPerfil.Text = BtnCrearPerfil.Text.Traducir();
            BtnRemoverPerfil.Text = BtnRemoverPerfil.Text.Traducir();
            BtnRemoverPermiso.Text = BtnRemoverPermiso.Text.Traducir();
        }
    }
}
