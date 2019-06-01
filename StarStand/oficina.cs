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
        StarDBContainer bd;
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
                DialogResult dialog = MessageBox.Show("Tem a certeza que quere eliminar", "Comfimação", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                   Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
                   bd.Entry(user).State = EntityState.Deleted;
                   bd.SaveChanges();
                   lerdadosclientes();
                    
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }
        private void ListBoxClientes_ChangeSeletedIndex(object sender, EventArgs e)
        {
            Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
            lerdadosCarros(user);
        }

        //Carros
        private void BtnAddCarros_Click(object sender, EventArgs e)
        {
            Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
            int selectedIndex = listBoxClientes.list.SelectedIndex;
            GerirCarros frm = new GerirCarros(user.IdUtilizador,null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdadosclientes();
                listBoxClientes.list.SelectedIndex = selectedIndex;
                user = listBoxClientes.list.SelectedItem as Utilizadores;
                lerdadosCarros(user);
            }
            
        }
        private void BtnEditCarro_Click(object sender, EventArgs e)
        {
            if(listBoxCarros.list.SelectedIndex!=-1)
            {
                Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
                CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
                int selectedIndex = listBoxClientes.list.SelectedIndex;
                GerirCarros frm = new GerirCarros(user.IdUtilizador, carro);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lerdadosclientes();
                    listBoxClientes.list.SelectedIndex = selectedIndex;
                    user = listBoxClientes.list.SelectedItem as Utilizadores;
                    lerdadosCarros(user);
                }
            }
        }
        private void BtnDeleteCarros_Click(object sender, EventArgs e)
        {
            if (listBoxCarros.list.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Tem a certeza que quere eliminar", "Comfimação", MessageBoxButtons.YesNo);
                if(dialog==DialogResult.Yes)
                {
                    CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
                    //bd.Entry(carro).State = EntityState.Deleted;

                    CarroOficina carro_apagar = (CarroOficina)bd.CarrosSet.Find(carro.IdCarro);
                    bd.CarrosSet.Remove(carro_apagar);

                    bd.SaveChanges();
                    lerdadosclientes();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }
        //Serviços
        private void ButtonGerirSeviços_Click(object sender, EventArgs e)
        {
            GerirServicos frm = new GerirServicos();
            frm.ShowDialog();
        }
        //Funçôes
        public void lerdadosclientes()
        {
            bd = new StarDBContainer();
            listBoxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }
        public void lerdadosCarros(Utilizadores user)
        {
            bd = new StarDBContainer();
            listBoxCarros.list.DataSource = user.CarroOficina.ToList();   
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
