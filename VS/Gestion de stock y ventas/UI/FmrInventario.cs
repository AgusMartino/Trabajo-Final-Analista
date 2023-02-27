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
    public partial class FmrInventario : Form
    {
        public FmrInventario()
        {
            InitializeComponent();
        }

        private void FmrInventario_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("160", helpProvider1, this);
        }
    }
}
