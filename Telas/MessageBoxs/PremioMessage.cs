using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_frutas.MessageBoxs
{
    public partial class PremioMessage : Form
    {
        public PremioMessage(double premio)
        {
            InitializeComponent();

            lblPremio.Text = premio.ToString("f2");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
