using Caça_frutas.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_frutas.UserControls
{
    public partial class EsperancaUC : UserControl
    {
        public EsperancaUC()
        {
            InitializeComponent();
        }

        private void btTelaDiagrama_Click(object sender, EventArgs e)
        {
            TelaDiagrama telaDiagrama = new TelaDiagrama();
            telaDiagrama.Show();
        }

        private void btnAumentaBet_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(lblValorEsperanca.Text);
            valor += 1.00;
            lblValorEsperanca.Text = valor.ToString("f2");
            AtualizaTabela();
        }

        private void btnDiminuiBet_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(lblValorEsperanca.Text);
            if ((valor - 1.00) <= 0)
            {
                MessageBox.Show("A aposta não pode ser menor ou igual a zero");
                return;
            }
            valor -= 1.00;
            lblValorEsperanca.Text = valor.ToString("f2");
            AtualizaTabela();
        }


        /// <summary>
        /// Realiza os calculos de Esperança(Lucro) do jogador baseado no valor de sua aposta e os atualiza
        //  na tabela
        /// </summary>
        private void AtualizaTabela()
        {
            double aposta = Convert.ToDouble(lblValorEsperanca.Text);
            double[] ganhosPossiveis = new double[] {(aposta * 1) , (aposta * 3), (aposta * 5), (aposta * 0)};
            double[] LucrosPossiveis = new double[] {(ganhosPossiveis[0] - aposta), (ganhosPossiveis[1] - aposta), (ganhosPossiveis[2] - aposta), (ganhosPossiveis[3] - aposta) };
            double[] P = new double[] {0.216, 0.027, 0.001, 0.756};
            double[] LucroVezesP = new double[] { (P[0] * LucrosPossiveis[0]), (P[1] * LucrosPossiveis[1]), (P[2] * LucrosPossiveis[2]), (P[3] * LucrosPossiveis[3])};

            string[] firstRow = new string[] {aposta.ToString(), ganhosPossiveis[0].ToString(), LucrosPossiveis[0].ToString(), LucroVezesP[0].ToString(), P[0].ToString()};
            string[] secondRow = new string[] {aposta.ToString(), ganhosPossiveis[1].ToString(), LucrosPossiveis[1].ToString(), LucroVezesP[1].ToString(), P[1].ToString()};
            string[] thirdRow = new string[] {aposta.ToString(), ganhosPossiveis[2].ToString(), LucrosPossiveis[2].ToString(), LucroVezesP[2].ToString(), P[2].ToString()};
            string[] fourthRow = new string[] {aposta.ToString(), ganhosPossiveis[3].ToString(), LucrosPossiveis[3].ToString(), LucroVezesP[3].ToString(), P[3].ToString()};

            lvEsperanca.Items.Clear();

            var lvFirstItem = new ListViewItem(firstRow)
            {
                Tag = firstRow
            };

            var lvSecondItem = new ListViewItem(secondRow)
            {
                Tag = secondRow
            };
            var lvThirdItem = new ListViewItem(thirdRow)
            {
                Tag = thirdRow
            };
            var lvFourthItem = new ListViewItem(fourthRow)
            {
                Tag = fourthRow
            };

            lvEsperanca.Items.Add(lvFirstItem);
            lvEsperanca.Items.Add(lvSecondItem);
            lvEsperanca.Items.Add(lvThirdItem);
            lvEsperanca.Items.Add(lvFourthItem);

            lvTotal.Items.Clear();
            double somaLucrosVezesP = (LucroVezesP[0] + LucroVezesP[1] + LucroVezesP[2] + LucroVezesP[3]);
            string[] total = new string[] {"TOTAL:", "1", somaLucrosVezesP.ToString()};
            var itemTotal = new ListViewItem(total)
            {
                Tag = total
            };
            lvTotal.Items.Add(itemTotal);
        }

        private void EsperancaUC_Load(object sender, EventArgs e)
        {
            AtualizaTabela();
        }
    }
}
