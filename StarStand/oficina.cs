using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StarStand
{
    public partial class oficina : UserControl
    {
        StarDBContainer1 bd;
        public oficina()
        {
            InitializeComponent();
           
            
        }


        //Clientes
        private void BtnAddClientes_Click(object sender, EventArgs e)
        {
            GerirClientes frm = new GerirClientes(null);
            if(frm.ShowDialog()==DialogResult.OK);
            {
                lerdadosclientes();
            }
        }
        private void BtnEditClientes_Click(object sender, EventArgs e)
        {
            if(listBoxClientes.list.SelectedIndex != -1)
            {
                Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
                GerirClientes frm = new GerirClientes(user);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lerdadosclientes();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }
        private void BtnRemoveClientes_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.list.SelectedIndex != -1)
            {
                Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
                bd.Entry(user).State = EntityState.Deleted;
                bd.SaveChanges();
                lerdadosclientes();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }

        //Carros
        private void BtnAddCarros_Click(object sender, EventArgs e)
        {
            GerirCarros frm = new GerirCarros();
            frm.ShowDialog();
        }


        //Funçôes
        public void lerdadosclientes()
        {
            bd = new StarDBContainer1();
            listBoxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }
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
