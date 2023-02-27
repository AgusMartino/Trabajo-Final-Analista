using BLL.Services;
using DOMAIN;
using SL.Services;
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
    public partial class FmrAltaProveedor : Form
    {
        Proveedor proveedor;
        DataSet dts;
        public FmrAltaProveedor()
        {
            InitializeComponent();
        }

        private void BtnCrearProveedor_Click(object sender, EventArgs e)
        {
            bool validador = default;
            try
            {
                if (TxtCuit.Text == null)
                {
                    MessageBox.Show("Debe Poner el Cuit del Proveedor".Traducir());
                }
                else
                {
                    //Creando Proveedor
                    proveedor = new Proveedor();
                    proveedor.Nombre = TxtNombre.Text;
                    proveedor.Cuit = Int64.Parse(TxtCuit.Text);
                    validador = ProveedorService.Current.ValidacionInt((int)proveedor.Cuit);
                    if (validador == true)
                    {
                        MessageBox.Show("El cuit ya existe".Traducir());
                    }
                    else
                    {
                        ProveedorService.Current.insert(proveedor);
                        TxtCuit.Text = "";
                        TxtNombre.Text = "";
                        MessageBox.Show("Proveedor dado de alta".Traducir());
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

        private void FmrAltaProveedor_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("460", helpProvider1, this);
            TraducirForm();
        }

        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnCrearProveedor.Text.Traducir();
        }

        private void btnExportarArchivo_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("Cuit");
            lista.Add("Nombre");
            ExcelService.Current.ExportExcel(lista);
        }

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            dts = new DataSet();
            dts = ExcelService.Current.ImportExcel(DtgImport, TxtPathArchivo);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            DtgImport.DataSource =dts.Tables[0];
        }
    }
}
