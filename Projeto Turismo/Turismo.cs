using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Turismo
{
    public partial class Frm_tur : Form
    {
        decimal Foz = 1420, Bonito = 1670, Rio = 1245, Fer = 1691; // Valores so de ida 
        decimal Fv = 2520, Bv = 2525, Rv = 1500, Fev = 2876; // Valores ida e volta
        decimal Vegas = 2650, Dubai = 5311, Grecia = 6621, Veneza = 4450; // Valores so de ida
        decimal Vegv = 4985, Dv = 7539, Grv = 10344, Venev = 8982; // Valores ida e volta

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // encerra a apresentação
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pass1 = numericUpDown1.Value;
            pass2 = numericUpDown2.Value;

            Frm_finalizar finalizar = new Frm_finalizar();// instanciando objeto para chamar a tela  Frm_finalizar
            Hide();// oculta o formulario
            finalizar.Btn_valor1.Text = Lbl_v1.Text;
            finalizar.Btn_valor2.Text = Lbl_v2.Text;
            finalizar.Txt_destino.Text = Cb_destino.Text;
            finalizar.Txt_quant1.Text = pass1.ToString();
            finalizar.Txt_quant2.Text = pass2.ToString(); 

            finalizar.Show(); // mostra o formulario
        }

        decimal pass1, pass2; // Variavel pra guardar a quantidade de pessoas das passagens nos numerics

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {                      

            if (Cb_destino.Text == "Foz do Iguaçu _ Parana")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Fv * pass2).ToString("c2"); // Multiplicando o valor das passagens conforme a quantidade do numeric
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Gol");
                }
            }
            else if (Cb_destino.Text == "Bonito_MS")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Bv * pass2).ToString("c2");  
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Latam");
                }

            }
            else if (Cb_destino.Text == "Rio de janeiro")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Rv * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Azul");
                }
            }
            else if (Cb_destino.Text == "Fernando de Noronha")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Fev * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Latam");
                }
            }
            else if (Cb_destino.Text == "Las Vegas")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Vegv * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Delta Air Lines");
                }
            }
            else if (Cb_destino.Text == "Dubai")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Dv * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea United Air Lines");
                }
            }
            else if (Cb_destino.Text == "Grecia")
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Grv * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Copa Air Lines");
                }

            }
            else
            {
                pass2 = numericUpDown2.Value;
                Lbl_v2.Text = (Venev * pass2).ToString("c2");
                if (numericUpDown2.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea American Air Lines");
                }
            }

        }

        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            //pass2 = numericUpDown2.Value;
            //Lbl_v2.Text = (Foz * pass1).ToString("c2");
            if (Chk2.Checked == true)
            {
                Lbl_v2.Visible = true;
                numericUpDown2.Value = 0;
                
            }
            else
            {
                Lbl_v2.Visible = false;
                numericUpDown2.Value = 0;
                if (listBox1.Text == "") // se o list box estiver cheio ele é  limpo com clear
                {
                    listBox1.Items.Clear();

                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (Cb_destino.Text == "Foz do Iguaçu _ Parana")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Foz * pass1).ToString("c2");

            if (numericUpDown1.Value == 0)
            {
               listBox1.Items.Remove("Linha aérea Gol");
            }
            else
                {

                }
            }
            else if (Cb_destino.Text == "Bonito_MS")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Bonito * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Latam");

                }

            }
            else if (Cb_destino.Text == "Rio de janeiro")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Rio * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Azul");

                }
            }
            else if (Cb_destino.Text == "Fernando de Noronha")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Fer * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Latam");

                }
            }
            else if (Cb_destino.Text == "Las Vegas")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Vegas * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Delta Air Lines");

                }
            }
            else if (Cb_destino.Text == "Dubai")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Dubai * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea United Air Lines");

                }
            }
            else if (Cb_destino.Text == "Grecia")
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Grecia * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea Copa Air Lines");

                }

            }
            else
            {
                pass1 = numericUpDown1.Value;
                Lbl_v1.Text = (Veneza * pass1).ToString("c2");
                if (numericUpDown1.Value == 0)
                {
                    listBox1.Items.Remove("Linha aérea American Air Lines");

                }
            }
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void Chk1_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk1.Checked==true)
            {
                Lbl_v1.Visible = true;
                numericUpDown1.Value = 0;
                
            }
            else
            {
                Lbl_v1.Visible = false;
                numericUpDown1.Value = 0;
                if(listBox1.Text=="")  
                {
                    listBox1.Items.Clear();   //se o list box estiver cheio ele é  limpo com clear

                }
            }
        }

       


        public Frm_tur()
        {
            InitializeComponent();
        }

        private void Frm_tur_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_destino.Text == "Foz do Iguaçu _ Parana")
            {
                pic_nacionais.Image = Properties.Resources.fozz;
                listBox1.Items.Add("Linha aérea Gol");
                
            }
            else if (Cb_destino.Text == "Bonito_MS")
            {
                pic_nacionais.Image = Properties.Resources.Bonito;
                listBox1.Items.Add("Linha aérea Latam");
            }
            else if (Cb_destino.Text == "Rio de janeiro")
            {
                pic_nacionais.Image = Properties.Resources.Rio;
                listBox1.Items.Add("Linha aérea Azul");
            }
            else  if (Cb_destino.Text == "Fernando de Noronha")
            {
                pic_nacionais.Image = Properties.Resources.FE;
                listBox1.Items.Add("Linha aérea Latam");
            }
            else if(Cb_destino.Text == "Las Vegas")
            {
                pic_inter.Image = Properties.Resources.Vegas;
                listBox1.Items.Add("Linha aérea Delta Air Lines");
            }
            else if(Cb_destino.Text == "Dubai")
            {
                pic_inter.Image = Properties.Resources.Dubai;
                listBox1.Items.Add("Linha aérea United Air Lines");
            }
            else if(Cb_destino.Text == "Grecia")
            {
                pic_inter.Image = Properties.Resources.Santorini_Grecia;
                listBox1.Items.Add("Linha aérea Copa Air Lines");
            }
            else
            {
                pic_inter.Image = Properties.Resources.Veneza_Italia;
                listBox1.Items.Add("Linha aérea American Air Lines");
            }
        }
    }
}
