using Caça_frutas.MessageBoxs;
using Caça_frutas.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_frutas.Utilities
{
    public class GameMetodos
    {
        private int counter;
        private bool repetiu;
        private int y;
        SoundPlayer sound;

        /// <summary>
        /// Realiza a animação da roleta, baseado em qual posição foi randonizada para cada reel
        /// e ao finalizar a animação descobre se venceu ou não
        /// </summary>
        /// <param name="pbLeft">Reel da esquerda</param>
        /// <param name="pbCenter">Reel do centro</param>
        /// <param name="pbRight">Reel da Direita</param>
        /// <param name="valorApostado">Valor apostado pelo jogador</param>
        /// <returns></returns>
        public async Task LigaCacaNiquel(Control pbLeft, Control pbCenter, Control pbRight, double valorApostado)
        {           
            counter = 0;
            repetiu = false;

            SomDoCacaNiquel(true);

            GlobalVariables.JogadorAtual.PagaAposta(valorApostado);

            Random rng = new Random();
            int positionLeft = rng.Next(1, 11);
            int positionCenter = rng.Next(1, 11);
            int positionRight = rng.Next(1, 11);

            double locationLeftY = (positionLeft * 190) + (positionLeft * 2);
            double locationCenterY = (positionCenter * 190) + (positionCenter * 2);
            double locationRightY = (positionRight * 190) + (positionRight * 2);


            do
            {
                if (counter == 0)
                    Roleta(pbLeft, locationLeftY);
                else if (counter == 1)
                    Roleta(pbCenter, locationCenterY);
                else if(counter == 2)
                    Roleta(pbRight, locationRightY);
                else if(counter == 3)
                {
                    counter = 0;
                    SomDoCacaNiquel(false);
                    VerificaPremio(positionLeft, positionCenter, positionRight, valorApostado);
                    break;
                }

                await TaskDelay();

            } while (true);

        }

        async Task TaskDelay()
        {
            await Task.Delay(30);
        }

        /// <summary>
        /// Metodo chamado pelo LigaCacaNiquel para realizar o movimento das pictureBox, 
        /// realizando a animação da mesma
        /// </summary>
        /// <param name="picturebox">piturebox atual que será movimentada</param>
        /// <param name="location">localização calculada, onde a picturebox deverá parar</param>
        private void Roleta(Control picturebox, double location)
        {

            if (picturebox.Location.Y < -48 && repetiu == false)
            {
                y = picturebox.Location.Y + 48;
                picturebox.Location = new Point(0, y);               
            }
            else if (repetiu == false)
            {
                picturebox.Location = new Point(0, -1920);
                repetiu = true;
            }
            else if(repetiu == true)
            {
                if (picturebox.Location.Y < (-location))
                {
                    y = picturebox.Location.Y + 48;
                    picturebox.Location = new Point(0, y);
                }
                else
                {
                    repetiu = false;
                    counter++;
                    return;
                }
            }

        }

        /// <summary>
        /// Metodo responsável por, após o fim da roletagem, verificar baseado nas posições sorteadas
        /// se o ousuário ganhou algum premio ou não
        /// </summary>
        /// <param name="positionLeft">posição sorteada para a primeira reel</param>
        /// <param name="positionCenter">posição sorteada para a segunda reel</param>
        /// <param name="positionRight">sorteada para a terceira reel</param>
        /// <param name="valorApostado">valor apostado pelo usuário</param>
        private void VerificaPremio(int positionLeft, int positionCenter, int positionRight, double valorApostado)
        {
            double premio = 0;
            bool ganhou = false;
            int[] macas = new int[] { 2, 3, 5, 7, 9, 10 };
            int[] bananas = new int[] { 1, 4, 8 };
            int laranja = 6;

            //Baseado na imagem da reel, consigo saber onde estão localizadas as frutas,
            //e então as distribui em vetores, então dependendo de qual posição for sorteada
            //para cada reel, conseguirei saber qual fruta foi selecionada

            if (macas.Contains(positionLeft) && macas.Contains(positionCenter) && macas.Contains(positionRight))
            {
                premio = valorApostado;
                GlobalVariables.JogadorAtual.Premia(premio);
                ganhou = true;
            }
            else if (bananas.Contains(positionLeft) && bananas.Contains(positionCenter) && bananas.Contains(positionRight))
            {
                premio = (valorApostado) * 3;
                GlobalVariables.JogadorAtual.Premia(premio);
                ganhou = true;
            }
            else if (laranja == positionLeft && laranja == positionCenter && laranja == positionRight)
            {
                premio = (valorApostado) * 5;
                GlobalVariables.JogadorAtual.Premia(premio);
                ganhou = true;
            }


            // Ao final verifica se ganhou algum premio, se sim, ira disparar o forms de vitoria
            // com a musica correspondente. Se nãoapenas disparará a musica de derrota
            if (ganhou == true)
            {
                MessageVitoria(premio);
            }
            else
            {
                SomDaDerrota();
            }

            JsonFileHandler.SalvarLista(GlobalVariables.FilePath, GlobalVariables.ListaDeUsuarios, true);
        }


        /// <summary>
        /// Dispara o form personalizado de vitória junto coma musica de vitoria
        /// </summary>
        /// <param name="premio">premio ganho pelo usuário</param>
        private void MessageVitoria(double premio)
        {
            PremioMessage venceu = new PremioMessage(premio);
            SomDaVitoria();
            venceu.ShowDialog();
        }

        /// <summary>
        /// Inicializa a variavel sound com a musica de vitoria e a toca
        /// </summary>
        public void SomDaVitoria()
        {
            sound = new SoundPlayer("sound-victory.wav");
            sound.Play();
        }

        /// <summary>
        /// Inicializa a variavel sound com a musica de derrota e a toca
        /// </summary>
        public void SomDaDerrota()
        {
            sound = new SoundPlayer("sound-failed.wav");
            sound.Play();
        }

        /// <summary>
        /// Liga ou desliga o som do caça niquel roletando
        /// </summary>
        /// <param name="liga"></param>
        public void SomDoCacaNiquel(bool liga)
        {
            if (liga == true)
            {
                sound = new SoundPlayer("efeito-caca-niquel.wav");
                sound.Play();
            }
            else
            {
                sound.Stop();
            }

        }
    }
}
