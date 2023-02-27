using BLL.Services;
using DOMAIN;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FmrGestionCaja : Form
    {
        public FmrGestionCaja()
        {
            InitializeComponent();
        }

        private void FmrGestionCaja_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("130", helpProvider1, this);
            TraducirForm();
            try
            {
                //Obteniendo Tipo de pago
                List<Tipo_de_pago> tipo_De_Pagos = new List<Tipo_de_pago>();
                tipo_De_Pagos = (List<Tipo_de_pago>)Tipo_de_pagoService.Current.GetAll();
                CmbTipodeMoneda.DataSource = tipo_De_Pagos;
                CmbTipodeMoneda.DisplayMember = "nombre";
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

        private void BtnIngresarDinero_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtMonto.Text == null)
                {
                    MessageBox.Show("Debe colocar un Monto".Traducir());
                }
                else
                {
                    if (CmbTipodeMoneda.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un tipo de moneda".Traducir());
                    }
                    else
                    {
                        if (TurnoIniciadoCache.Caja_inicial == 0)
                        {
                            MessageBox.Show("Debe Iniciar un Turno".Traducir());
                        }
                        else
                        {
                            //Ingresando Dinrero
                            Movimiento_Caja movimiento_Caja = new Movimiento_Caja();
                            movimiento_Caja.cantidad = decimal.Parse(TxtMonto.Text);
                            movimiento_Caja.Fecha_de_movimiento = DateTime.Now;
                            movimiento_Caja.tipo_De_Pago = (Tipo_de_pago)CmbTipodeMoneda.SelectedItem;
                            movimiento_Caja.tipo_De_Movimiento = Tipo_de_movimientoService.Current.GetOne(int.Parse(ConfigurationManager.AppSettings["Ingreso_Caja"]));
                            Movimiento_cajaService.Current.insert(movimiento_Caja);
                            TxtMonto.Text = "";
                            CmbTipodeMoneda.SelectedIndex = 0;
                            MessageBox.Show("Ingreso de dinero realizado".Traducir());
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

        private void BtnEgresarDinero_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtMonto.Text == null)
                {
                    MessageBox.Show("Debe colocar un Monto".Traducir());
                }
                else
                {
                    if (CmbTipodeMoneda.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un tipo de moneda".Traducir());
                    }
                    else
                    {
                        if (TurnoIniciadoCache.Caja_inicial == 0)
                        {
                            MessageBox.Show("Debe Iniciar un Turno".Traducir());
                        }
                        else
                        {
                            //Egresando Dinero
                            Movimiento_Caja movimiento_Caja = new Movimiento_Caja();
                            movimiento_Caja.cantidad = decimal.Parse(TxtMonto.Text);
                            movimiento_Caja.Fecha_de_movimiento = DateTime.Now;
                            movimiento_Caja.tipo_De_Pago = (Tipo_de_pago)CmbTipodeMoneda.SelectedItem;
                            movimiento_Caja.tipo_De_Movimiento = Tipo_de_movimientoService.Current.GetOne(int.Parse(ConfigurationManager.AppSettings["Egreso_Caja"]));
                            Movimiento_cajaService.Current.insert(movimiento_Caja);
                            TxtMonto.Text = "";
                            CmbTipodeMoneda.SelectedIndex = 0;
                            MessageBox.Show("Egreso de dinero realizado".Traducir());
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
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            BtnEgresarDinero.Text = BtnEgresarDinero.Text.Traducir();
            BtnIngresarDinero.Text = BtnIngresarDinero.Text.Traducir();
        }
    }
}
