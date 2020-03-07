using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;


namespace Simulador_de_Seguros
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            buttonBarretos.Visible = true;
            buttonFranca.Visible = true;
            groupBox4.Visible = true;
            buttonPetropolis.Visible = false;
            buttonTresRios.Visible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RJ_CheckedChanged(object sender, EventArgs e)
        {
            buttonPetropolis.Visible = true;
            buttonTresRios.Visible = true;
            groupBox4.Visible = true;
            buttonBarretos.Visible = false;
            buttonFranca.Visible = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            telefone.Text = "";
            email.Text = "";
            valorImovel.Text = "";
            logradouro.Text = "";
            numeroCasa.Text = "";
            textBox1.Text = "";

            SP.Checked = false;
            RJ.Checked = false;
            buttonPetropolis.Checked = false;
            buttonBarretos.Checked = false;
            buttonFranca.Checked = false;
            buttonTresRios.Checked = false;

            radioButtonSimAlarme.Checked = false;
            radioButtonNaoAlarme.Checked = false;

            checkBoxRoubo.Checked = false;
            checkBoxDesastre.Checked = false;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja fechar o programa?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRoubo.Checked == true)
            {
                radioButtonSimAlarme.Visible = true;
                radioButtonNaoAlarme.Visible = true;
                textBox1.Visible = true;
                label9.Visible = true;
                groupBox2.Visible = true;

            }
            else
            {
                radioButtonSimAlarme.Visible = false;
                radioButtonNaoAlarme.Visible = false;
                textBox1.Visible = false;
                label9.Visible = false;
                groupBox2.Visible = false;
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {   
            


        }


        private void button2_Click(object sender, EventArgs e) //calcular
        {
            if (nome.Text == "" || telefone.MaskCompleted == false || valorImovel.Text == "" || logradouro.Text == "" || numero.Text == "" || email.Text == null || isEmail == false ||
                 buttonBarretos.Checked == false && buttonFranca.Checked == false && buttonTresRios.Checked == false && buttonPetropolis.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Favor preencher todos os campos corretamente!");
            }
            else
            {
                double im = double.Parse(valorImovel.Text);
                double VM, VF;
                VM = im / 12;

                if (buttonPetropolis.Checked == true)
                {
                    VM = (VM * 0.51) / 100;
                }
                else if (buttonFranca.Checked == true)
                {
                    VM = (VM * 0.46) / 100;
                }
                else if (buttonTresRios.Checked == true)
                {
                    VM = (VM * 0.58) / 100;
                }
                else if (buttonBarretos.Checked == true)
                {
                    VM = (VM * 0.52) / 100;
                }

                if (checkBoxRoubo.Checked == true)
                {
                    double textBoxValorBens = double.Parse(textBox1.Text);
                    if (radioButtonSimAlarme.Checked == true)
                    {

                        VM += textBoxValorBens / 100;
                    }
                    else if (radioButtonNaoAlarme.Checked == true)
                    {
                        VM += (textBoxValorBens * 2) / 100;
                    }
                }

                if (checkBoxDesastre.Checked == true)
                {
                    VM += (VM * 5) / 100;
                }
                VF = VM * 10;
                System.Windows.Forms.MessageBox.Show(string.Format("Valor Mensal: {0} \n Valor Franquia: {1}", VM.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")), VF.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))));
            }

        }

        private void logradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
        bool isEmail;
        private void Email_TextChanged(object sender, EventArgs e)
        {
            string emailVerif = email.Text;
            isEmail = Regex.IsMatch(emailVerif, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == true)
            {
                wrongEmail.Visible = false;
                rightEmail.Visible = true;
            }
            else
            {
                rightEmail.Visible = false;
                wrongEmail.Visible = true;
            }
        }

        private void Nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ValorImovel_TextChanged(object sender, EventArgs e)
        {




        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void valorImovel_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {



        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
