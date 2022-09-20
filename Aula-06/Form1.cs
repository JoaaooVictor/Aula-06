using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Declarações objeto da classe candidato.
        string numero = "";
        Candidato alguem;
        Candidato[] lista = new Candidato[4];
        int branco = 0, nulo = 0;
        #endregion

        #region Informações dos candidatos
        private void InsereCandidato() 
        {
            alguem = new Candidato();
            alguem.Numero = 20;
            alguem.Nome = "Joana Lima";
            alguem.Turma = "1º ADS";
            alguem.Foto = "joana.jpg";
            lista[0] = alguem;

            alguem = new Candidato();
            alguem.Numero = 21;
            alguem.Nome = "João Lima";
            alguem.Turma = "1º ADS";
            alguem.Foto = "joao.jfif";
            lista[1] = alguem;

            alguem = new Candidato();
            alguem.Numero = 24;
            alguem.Nome = "Renan Lima";
            alguem.Turma = "1º ADS";
            alguem.Foto = "renan.jfif";
            lista[2] = alguem;

            alguem = new Candidato();
            alguem.Numero = 22;
            alguem.Nome = "Bolsonaro";
            alguem.Turma = "1º ADS";
            alguem.Foto = "bolsonaro.jfif";
            lista[3] = alguem;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false; // Desabilita o campo de texto
            txtNum2.Enabled = false; // Desabilita o campo de texto
            BtnConfirma.Enabled = false;
            lblMensagem.Visible = false; // Panel ocultada
            InsereCandidato();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Preenche("5");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Preenche("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Preenche("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Preenche("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Preenche("4");
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            Preenche("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Preenche("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Preenche("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Preenche("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Preenche("0");
        }

        private void Preenche(string n) 
        {  
            if(numero.Length == 0)
            {
                txtNum1.Text = n;
                numero += n;
            }
            else
            {
                txtNum2.Text = n;
                numero += n;

                for(int i = 0; i < 4; i++)
                {
                    if(int.Parse(numero) == lista[i].Numero)
                    {
                        lblCandidato.Text = lista[i].Nome;
                        lblTurma.Text = lista[i].Turma;
                        pxFoto.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Imagens Candidatos\" + lista[i].Foto);
                        i = 3;
                    }
                    else
                    {
                        lblCandidato.Text = "VOTO NULO";
                    }
                    lblMensagem.Visible = true;
                    BtnConfirma.Enabled = true;
                }
            }
        }


    }
    
}
