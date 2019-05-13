using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStand
{
    public partial class oficina : UserControl
    {
        public oficina()
        {
            InitializeComponent();
        }


        //Clientes
        private void BtnAddClientes_Click(object sender, EventArgs e)
        {
            GerirClientes frm = new GerirClientes();
            frm.ShowDialog();
        }

        //Carros
        private void BtnAddCarros_Click(object sender, EventArgs e)
        {
            GerirCarros frm = new GerirCarros();
            frm.ShowDialog();
        }

        //Funçôes
        public void placeholder(TextBox textbox, string textToPlaceHolder)
        {
            if (textbox.Text == "")
            {
                textbox.Text = textToPlaceHolder;
            }
            if (textbox.Text == textToPlaceHolder)
            {
                textbox.Text = "";
            }
        }

      
    }
}
