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
using UI.Lisener;

namespace UI
{
    public partial class FmrListarTurnos : Form
    {
        private ITurnoSeleccionadoLisenner turnoSeleccionadoLisenner;
        public FmrListarTurnos(ITurnoSeleccionadoLisenner turnoSeleccionadoLisenner)
        {
            InitializeComponent();
            this.turnoSeleccionadoLisenner = turnoSeleccionadoLisenner;
        }

        private void FmrListarTurnos_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("270", helpProvider1, this);
            try
            {
                BtnSeleccionarTurno.Text = BtnSeleccionarTurno.Text.Traducir();
                //Listando Turnos existentes
                List<Turno> turnos = new List<Turno>();
                turnos = (List<Turno>)TurnoService.Current.GetAll();
                foreach (var item in turnos)
                {
                    DtgTurno.Rows.Add(item.IdTurno, item.Caja_inicial, item.Fecha_de_inicio, item.Fecha_de_cierre);
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

        private void BtnSeleccionarTurno_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            int i = DtgTurno.CurrentRow.Index;
            turno.IdTurno = int.Parse(DtgTurno[0, i].Value.ToString());
            turno.Caja_inicial = decimal.Parse(DtgTurno[1, i].Value.ToString());
            turno.Fecha_de_inicio = DateTime.Parse(DtgTurno[2, i].Value.ToString());
            turno.Fecha_de_cierre = DateTime.Parse(DtgTurno[3, i].Value.ToString());
            turnoSeleccionadoLisenner.TurnoSeleccionado(turno);
            this.Hide();
        }
    }
}
