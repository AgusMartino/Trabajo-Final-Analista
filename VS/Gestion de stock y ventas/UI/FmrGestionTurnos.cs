using BLL.Services;
using DOMAIN;
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
    public partial class FmrGestionTurnos : Form
    {
        public FmrGestionTurnos()
        {
            InitializeComponent();
        }

        private void BtnIniciarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtMontoInicial.Text == null)
                {
                    MessageBox.Show("Debe colocar un monto inicial".Traducir());
                }
                else
                {
                    //Iniciando Turnno
                    Turno turno = new Turno();
                    turno.Caja_inicial = decimal.Parse(TxtMontoInicial.Text);
                    turno.Fecha_de_inicio = DateTime.Now;
                    turno.Fecha_de_cierre = null;
                    TurnoService.Current.insert(turno);
                    TurnoService.Current.GetTurno((DateTime)turno.Fecha_de_inicio);
                    TxtMontoInicial.Text = "";
                    MessageBox.Show("Turno iniciado con exito".Traducir());
                    CkbTurno.Checked = true;
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

        private void FmrGestionTurnos_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("150", helpProvider1, this);
            TraducirForm();
            try
            {
                //validando si hay un turno abierto
                if (TurnoIniciadoCache.IdTurno != null)
                {
                    TxtMontoInicial.Text = Convert.ToString(TurnoIniciadoCache.Caja_inicial);
                    CkbTurno.Checked = true;
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

        private void BtnCerrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (TurnoIniciadoCache.IdTurno != null)
                {
                    //cerrando Turno 
                    Turno turno = new Turno();
                    turno.IdTurno = (int)TurnoIniciadoCache.IdTurno;
                    turno.Caja_inicial = (decimal)TurnoIniciadoCache.Caja_inicial;
                    turno.Fecha_de_inicio = TurnoIniciadoCache.Fecha_de_inicio;
                    turno.Fecha_de_cierre = DateTime.Now;
                    TurnoService.Current.update(turno);
                    TurnoIniciadoCache.IdTurno = null;
                    TurnoIniciadoCache.Caja_inicial = null;
                    TurnoIniciadoCache.Fecha_de_inicio = null;
                    TurnoIniciadoCache.Fecha_de_cierre = null;
                    TxtMontoInicial.Text = "";
                    MessageBox.Show("Turno Cerrado con exito".Traducir());
                    CkbTurno.Checked = false;
                }
                else
                {
                    MessageBox.Show("No hay ningun turno Iniciado".Traducir());
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
            BtnCerrarTurno.Text = BtnCerrarTurno.Text.Traducir();
            BtnIniciarTurno.Text = BtnIniciarTurno.Text.Traducir();
            CkbTurno.Text = CkbTurno.Text.Traducir();
        }
    }
}
