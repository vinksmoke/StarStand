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
    public partial class USaluguer : UserControl
    {

        const string NOSELECT = "Nada Selecionado";
        const string ALUGADO = "Finalizar";
        const string Disponivel = "Alugar";


        StarDBContainer bd;
        public USaluguer()
        {
            InitializeComponent();
        }

        private void btnAddCarros_Click(object sender, EventArgs e)
        {
            GerirCarrosAlugados aluguerfrm = new GerirCarrosAlugados(null);

            if (aluguerfrm.ShowDialog() == DialogResult.OK)
            {
                lerdadosCarro();
            }
        }
        private void BtnEditCarros_Click(object sender, EventArgs e)
        {
            if(listboxCarros.list.SelectedIndex!=-1)
            {
                GerirCarrosAlugados aluguerfrm = new GerirCarrosAlugados(listboxCarros.list.SelectedItem as CarroAluguer);

                if (aluguerfrm.ShowDialog() == DialogResult.OK)
                {
                    lerdadosCarro();
                }
            }
        }
        private void BtnRemoveCarros_Click(object sender, EventArgs e)
        {
            if(listboxCarros.list.SelectedIndex!=-1)
            {
                DialogResult result = MessageBox.Show("Tem a certeza que quere eliminar", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CarroAluguer carro = listboxCarros.list.SelectedItem as CarroAluguer;
                    carro=(CarroAluguer)bd.CarrosSet.Single(o => o.IdCarro == carro.IdCarro);

                    bd.CarrosSet.Remove(carro);
                    bd.SaveChanges();
                    lerdadosCarro();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um carro");
            }
        }
        private void listboxCarros_ChangeSeletedIndex(object sender, EventArgs e)
        {
            if (listboxCarros.list.SelectedIndex != -1)
            {
                mostrarDado();
            }
        }

        private void ButtonAlugar_Click(object sender, EventArgs e)
        {
            if (buttonAlugar.Text == Disponivel) 
            {
                GerirAluguer frm = new GerirAluguer(listboxClientes.list.SelectedItem as Utilizadores, listboxCarros.list.SelectedItem as CarroAluguer);
                frm.ShowDialog();
            }
            else
            {
                GerirAluguer frm = new GerirAluguer(null, listboxCarros.list.SelectedItem as CarroAluguer);
                frm.ShowDialog();
            }
            lerdadosCarro();
           
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = listboxCarros.list.SelectedItem as CarroAluguer;
            carroAluguer = (CarroAluguer)bd.CarrosSet.Single(id => id.IdCarro == carroAluguer.IdCarro);

            if (btnSwitch.Value == true)
            {
                carroAluguer.Estado = "Disponível";
            }
            else
            {
                carroAluguer.Estado = "Indisponivel";
            }

            bd.Entry(carroAluguer).State = EntityState.Modified;
            bd.SaveChanges();
            lerdadosClientes();
            lerdadosCarro();
            mostrarDado();
        }
        //Clientes
        private void btnAddClientes_Click(object sender, EventArgs e)
        {
            GerirClientes frm = new GerirClientes(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdadosClientes();
            }
        }
        private void btnEditClientes_Click(object sender, EventArgs e)
        {
            if (listboxClientes.list.SelectedIndex != -1)
            {
                Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;
                GerirClientes frm = new GerirClientes(user);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lerdadosClientes();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }
        private void btnRemoveClientes_Click(object sender, EventArgs e)
        {
            if (listboxClientes.list.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Tem a certeza que quere eliminar", "Comfimação", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;
                    Utilizadores user_apagar = (Utilizadores)bd.UtilizadoresSet.Find(user.IdUtilizador);
                    bd.UtilizadoresSet.Remove(user_apagar);
                    bd.SaveChanges();
                    lerdadosClientes();
                }
            }
            else
            {
                MessageBox.Show("Tem de selecionar um cliente");
            }
        }

        private void BtnVerHistorico_Click(object sender, EventArgs e)
        {
            HistoricoAluguer frm = new HistoricoAluguer();
            frm.ShowDialog();
        }

        //Funçoes
        public void lerdadosCarro()
        {
            bd = new StarDBContainer();
            listboxCarros.list.DataSource = bd.CarrosSet.OfType<CarroAluguer>().ToList();
        }
        public void lerdadosClientes()
        {
            bd = new StarDBContainer();

            listboxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }
        public void mostrarDado()
        {
            CarroAluguer carroAluguer = listboxCarros.list.SelectedItem as CarroAluguer;
            labelMostraMarca.Text = carroAluguer.Marca;
            labelMostraEstado.Text = carroAluguer.Estado;
            labelMostraValor.Text = carroAluguer.ValorBase + " €";
            labelMostrarModelo.Text = carroAluguer.Modelo;
            labelMostrarMatricula.Text = carroAluguer.Matricula;

            panelright.Visible = true;
            lerdadosClientes();
            if (carroAluguer.Estado == "Alugado")
            {
                int id = carroAluguer.Aluguer.OrderByDescending(a => a.IdAluguer).Select(a => a.IdAluguer).First();
                Aluguer aluguer = bd.AluguerSet.Single(a => a.IdAluguer == id);
                buttonAlugar.Text = ALUGADO;
                buttonAlugar.Enabled = true;
                labelMostrarUser.Text = aluguer.Utilizadores.Nome;
                labelUser.Visible = true;
                labelMostrarUser.Visible = true;
                btnSwitch.Enabled = false;
                btnSwitch.Value = true;

            }
            else
            {
                buttonAlugar.Text = Disponivel;
                labelUser.Visible = false;
                labelMostrarUser.Visible = false;
                btnSwitch.Enabled = true;
                if (carroAluguer.Estado == "Disponível")
                {
                    btnSwitch.Value = true;
                    buttonAlugar.Enabled = true;
                }
                else
                {
                    btnSwitch.Value = false;
                    buttonAlugar.Enabled = false;
                }
            }
        }

       
    }
}