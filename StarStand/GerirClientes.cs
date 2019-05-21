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
        starBDContainer bd = new starBDContainer();
        int idUser;
        public GerirClientes(Utilizadores user)
        {
            InitializeComponent();
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

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
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
            
            bd.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
