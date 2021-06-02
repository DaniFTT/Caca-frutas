using Caça_frutas.Models;
using Caça_frutas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_frutas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            this.Visible = false;
            tela.ShowDialog();
            this.Visible = true;
        }
    }
}
