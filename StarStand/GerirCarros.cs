using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStand
{
    public partial class GerirCarros : Form
    {
        const string MARCA = "Marca";
        const string MODELO = "Modelo";
        const string MATRICULA = "Matricula";
        const string COMBUSTIVEL = "Combustivel";
        bool togMoveForm;
        int MvalX;
        int MvalY;
        public GerirCarros()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //Funções
        private void setplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox,string texto)
        {
            if(texbox.Text=="")
            {
                texbox.Text = texto;
                texbox.TextAlign =HorizontalAlignment.Center;
 
            }
        }
        private void removePlaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == texto)
            {
                texbox.Text = "";
                texbox.TextAlign = HorizontalAlignment.Left;

            }
        }
        //Layout
        private void TextBoxMarca_Enter(object sender, EventArgs e)
        {
            removePlaceholder(textBoxMarca, MARCA);
        }
        private void TextBoxMarca_Leave(object sender, EventArgs e)
        {
            setplaceholder(textBoxMarca, MARCA);
        }
        private void TextBoxModelo_Enter(object sender, EventArgs e)
        {
            removePlaceholder(TextBoxModelo, MODELO);
        }
        private void TextBoxModelo_Leave(object sender, EventArgs e)
        {
            setplaceholder(TextBoxModelo, MODELO);
        }
        private void TextboxMatricula_Enter(object sender, EventArgs e)
        {
            removePlaceholder(TextboxMatricula, MATRICULA);
        }
        private void TextboxMatricula_Leave(object sender, EventArgs e)
        {
            setplaceholder(TextboxMatricula, MATRICULA);
        }
        private void TextboxCombustivel_Enter(object sender, EventArgs e)
        {
            removePlaceholder(textboxCombustivel, COMBUSTIVEL);
        }
        private void TextboxCombustivel_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxCombustivel, COMBUSTIVEL);
        }

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
    }
}
