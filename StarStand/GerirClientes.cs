using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StarStand
{

    public partial class GerirClientes : Form
    {
        const string NOME = "Nome";
        const string NIF = "NIF";
        const string TELEMOVEL = "Telemovel";
        const string MORADA = "Morada";
        const string EMAIL = "Email";

        bool togMoveForm;
        int MvalX;
        int MvalY;

        starBDContainer bd = new starBDContainer();
        int idUser;

        public virtual int MaxLength { get; set; }


        public GerirClientes(Utilizadores user)
        {
            InitializeComponent();
            
            //Editar dados dos clientes
            if (user  !=  null)
            {              
                btnSubmeter.Text = "Editar";
                btnSubmeter.Normalcolor = Color.Yellow;
                textboxNome.Text =user.Nome.ToString();
                textboxNIF.Text = user.NIF.ToString();
                textboxTelemovel.Text = user.Telemovel.ToString();
                textboxMorada.Text = user.Morada.ToString();
                textboxEmail.Text = user.Email.ToString();
                idUser = user.IdUtilizador;
            }
        }

        //Adicionar clientes
        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            

            if (textboxNIF.Text.Length < 9)
            {
                MessageBox.Show("Introduza 9 digitos no campo do NIF!");
                return;
            }
            if (textboxNIF.Text.Length > 9)
            {
                MessageBox.Show("Introduziu mais que 9 digitos!");
                return;
            }

            int convnif = int.Parse(textboxNIF.Text);
            Utilizadores nif = bd.UtilizadoresSet.FirstOrDefault(x => x.NIF == convnif);

            if (nif != null)
            {
                MessageBox.Show("O NIF introduzido já existe!");
            }

            if (textboxNome.Text.Count(c=>!char.IsLetter(c) && !char.IsWhiteSpace(c))>0)
            {
                MessageBox.Show("Nome: Este campo só pode conter letras!");
                return;
            }
             

            //Campos para preencher obrigatóriamente!
            if (textboxTelemovel.Text.Count(c=>char.IsDigit(c))==0)
            {
                MessageBox.Show("Telemóvel: Obrigatório digitos");
                return;
            }

            if (textboxNome.Text.Equals(""))
            {
                MessageBox.Show("Nome: Campo Obrigatório!");
                return;
            }

            if (textboxNIF.Text.Equals(""))
            {
                MessageBox.Show("NIF: Campo Obrigatório!");
                return;
            }

            if (textboxTelemovel.Text.Equals(""))
            {
                MessageBox.Show("Telemóvel: Campo Obritório!");
                return;
            }
            
            if (textboxMorada.Text.Equals(""))
            {
                MessageBox.Show("Morada: Campo Obrigatório!");
                return;
            }

            if (btnSubmeter.Text == "Inserir")
            {
                Utilizadores user = new Utilizadores();
                user.Nome = textboxNome.Text.Trim();
                user.NIF = int.Parse(textboxNIF.Text.Trim());
                user.Morada = textboxMorada.Text.Trim();
                user.Telemovel = textboxTelemovel.Text.Trim();
                user.Email = textboxEmail.Text.Trim();
                bd.UtilizadoresSet.Add(user);
            }
            else
            {
                Utilizadores user = bd.UtilizadoresSet.Single(Utilizadores => Utilizadores.IdUtilizador == idUser);
                user.Nome = textboxNome.Text.Trim();
                user.NIF = int.Parse(textboxNIF.Text.Trim());
                user.Morada = textboxMorada.Text.Trim();
                user.Telemovel = textboxTelemovel.Text.Trim();
                user.Email = textboxEmail.Text.Trim();
                bd.Entry(user).State = EntityState.Modified;
            }

            //Verificações ao tentar submeter
            //Restrições
            
            
                bd.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funções
        //Remover e Adicionar Placeholders
        private void setplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == "")
            {
                texbox.Text = texto;
                texbox.TextAlign = HorizontalAlignment.Center;

            }
        }
        private void removeplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == texto)
            {
                texbox.Text = "";
                texbox.TextAlign = HorizontalAlignment.Left;

            }
        }

        //Layout
        //Textbox "Nome"
        private void TexBoxNome_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxNome, NOME);
        }

        private void TextBoxNome_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxNome, NOME);
        }

        //Textbox "NIF"
        private void TextBoxNIF_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxNIF, NIF);
        }

        private void TextBoxNIF_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxNIF, NIF);
        }

        //Textbox "Telemovel"
        private void TextBoxTelemovel_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxTelemovel, TELEMOVEL);
        }

        private void TextBoxTelemovel_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxTelemovel, TELEMOVEL);
        }

        //Textbox "Morada"
        private void TextBoxMorada_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxMorada, MORADA);
        }

        private void TextBoxMorada_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxMorada, MORADA);
        }

        //Textbox "Email"
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxEmail, EMAIL);
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxEmail, EMAIL);
        }

        //Arrastar Form
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            togMoveForm = true;
            MvalX = e.X;
            MvalY = e.Y;
        }
        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            togMoveForm = false;
        }
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMoveForm == true)
            {
                SetDesktopLocation(MousePosition.X - MvalX, MousePosition.Y - MvalY);
            }
        }

        //Verificações
        //NIF
        private void textboxNIF_OnValueChanged(object sender, EventArgs e)
        {
            const int maxlen = 9;

            string tString = textboxNIF.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Só é permitido números neste campo!");
                    textboxNIF.Text = "";
                    return;
                }
            }
            
        }
      
    }
}
