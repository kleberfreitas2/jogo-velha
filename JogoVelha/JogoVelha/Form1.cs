using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayer1.Enabled = true;
            lblPlayer2.Enabled = false;

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (lblPlayer1.Enabled == true)
                btn1.Text = "X";
            else
                btn1.Text = "O";

            btn1.Enabled = false;

            if (verificarjogada(1))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }

            lblPlayer1.Focus();
        }

        private bool verificarjogada(int casa)
        {
            bool retorno = false;

            if (verificahorizontal(casa))
                retorno = true;
            else if (verificaVertical(casa))
                retorno = true;
            else if (verificadiagonal(casa))
                retorno = true;

            return retorno;
        }

        private bool verificahorizontal(int casa)
        {
            bool retorno = false;
            int linha = 0;


            if (casa == 1 || casa == 2 || casa == 3)
                linha = 1;
            else if (casa == 4 || casa == 5 || casa == 6)
                linha = 2;
            else
                linha = 3;

            if (lblPlayer1.Enabled == true)
            {
                if (linha == 1 && btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                    retorno = true;
                if (linha == 2 && btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                    retorno = true;
                if (linha == 3 && btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                    retorno = true;

            }
            else
            {
                if (linha == 1 && btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
                    retorno = true;
                if (linha == 2 && btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
                    retorno = true;
                if (linha == 3 && btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
                    retorno = true;

            }


            return retorno;
        }

        private bool verificaVertical(int casa)
        {
            bool retorno = false;
            int coluna = 0;


            if (casa == 1 || casa == 4 || casa == 7)
                coluna = 1;
            else if (casa == 2 || casa == 5 || casa == 8)
                coluna = 2;
            else
                coluna = 3;

            if (lblPlayer1.Enabled == true)
            {
                if (coluna == 1 && btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                    retorno = true;
                if (coluna == 2 && btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                    retorno = true;
                if (coluna == 3 && btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                    retorno = true;

            }
            else
            {
                if (coluna == 1 && btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
                    retorno = true;
                if (coluna == 2 && btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
                    retorno = true;
                if (coluna == 3 && btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
                    retorno = true;

            }


            return retorno;
        }

        private bool verificadiagonal(int casa)
        {
            bool retorno = false;
            int diagonal = 0;

            //verifica se casa faz parte diagonal

            if (casa == 2 || casa == 4 || casa == 6 || casa == 8)
                return false;
            else
            {
                if (casa == 1 || casa == 5 || casa == 9)
                    diagonal = 1;
                else
                    diagonal = 2;

                if (lblPlayer1.Enabled == true)
                {
                    if (diagonal == 1 && btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
                        retorno = true;
                    if (diagonal == 2 && btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
                        retorno = true;


                }
                else
                {
                    if (diagonal == 1 && btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
                        retorno = true;
                    if (diagonal == 2 && btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
                        retorno = true;

                }

            }








            return retorno;
        }
        
        private void limparJogo()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            lblPlayer1.Enabled = true;
            lblPlayer2.Enabled = false;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn2.Text = "X";
            else
                btn2.Text = "O";

            btn2.Enabled = false;

            if (verificarjogada(2))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn3.Text = "X";
            else
                btn3.Text = "O";

            btn3.Enabled = false;

            if (verificarjogada(3))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn4.Text = "X";
            else
                btn4.Text = "O";

            btn4.Enabled = false;

            if (verificarjogada(4))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn5.Text = "X";
            else
                btn5.Text = "O";

            btn5.Enabled = false;

            if (verificarjogada(5))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn6.Text = "X";
            else
                btn6.Text = "O";

            btn6.Enabled = false;

            if (verificarjogada(6))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn7.Text = "X";
            else
                btn7.Text = "O";

            btn7.Enabled = false;

            if (verificarjogada(7))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn9.Text = "X";
            else
                btn9.Text = "O";

            btn9.Enabled = false;

            if (verificarjogada(9))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.Enabled == true)
                btn8.Text = "X";
            else
                btn8.Text = "O";

            btn8.Enabled = false;

            if (verificarjogada(8))
            {
                if (lblPlayer1.Enabled == true)
                    MessageBox.Show("Player 1 Venceu!");
                else
                    MessageBox.Show("Player 2 Venceu!");

                limparJogo();

            }
            else
            {
                if (lblPlayer1.Enabled == true)
                {
                    lblPlayer1.Enabled = false;
                    lblPlayer2.Enabled = true;
                }
                else
                {
                    lblPlayer1.Enabled = true;
                    lblPlayer2.Enabled = false;
                }

            }
            lblPlayer1.Focus();
        }
    }
}
