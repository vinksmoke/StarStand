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
        const string SERVICOSAIDA = "Dar Saida";
        const string NOMESERVICO = "Nome do Serviço";
        const string ValorParcela = "Valor";

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
        private void TextboxFiltrarClientes_OnTextChange(object sender, EventArgs e)
        {
            /*Utilizadores user = new Utilizadores();
            bd.UtilizadoresSet.Where(nif => nif.NIF ==int.Parse("%" + textboxFiltrarClientes.text + "%"));*/

        }
        private void ListBoxClientes_ChangeSeletedIndex(object sender, EventArgs e)
        {
            Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
            lerdadosCarros(user);
            listBoxCarros.list.SelectedIndex = -1;
            listBoxServicos.list.DataSource = null;
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
        private void ListBoxCarros_ChangeSeletedIndex(object sender, EventArgs e)
        {
            CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
            if(listBoxCarros.list.SelectedIndex!=-1)
                lerdadosServicos(carro);

            listBoxServicos.list.SelectedIndex = -1;
        }

        //Serviços
        private void ButtonGerirSeviços_Click(object sender, EventArgs e)
        {
            GerirServicos frm = new GerirServicos();
            frm.ShowDialog();
        }

        private void BtnEditarServico_Click(object sender, EventArgs e)
        {
            Servicos servicos = listBoxServicos.list.SelectedItem as Servicos;
            btnServico.ButtonText = SERVICOSAIDA;
            btnServico.IdleFillColor = Color.DarkOrange;
            btnServico.IdleLineColor = Color.Orange;
            textBoxNomeServico.Enabled = false;
            textBoxNomeServico.Text = servicos.Nome;
            btnCancelar.Visible = true;
            labelData.Text = "Data de Saida";
            panelParcela.Visible = true;
            lerdadosParcela(servicos);
        }
        private void BtnEliminarServicos_Click(object sender, EventArgs e)
        {
            CarroOficina carro;
            int selectedIndexCarro = listBoxCarros.list.SelectedIndex;
            int selectedIndexCliente = listBoxClientes.list.SelectedIndex;
            Utilizadores user;

            Servicos servico = listBoxServicos.list.SelectedItem as Servicos;
            Servicos servico_apgar = (Servicos)bd.ServicosSet.Find(servico.IdServicos);
            bd.ServicosSet.Remove(servico_apgar);
            bd.SaveChanges();

            lerdadosclientes();
            listBoxClientes.list.SelectedIndex = selectedIndexCliente;
            user = listBoxClientes.list.SelectedItem as Utilizadores;
            lerdadosCarros(user);
            listBoxCarros.list.SelectedIndex = selectedIndexCarro;
            carro = listBoxCarros.list.SelectedItem as CarroOficina;
            lerdadosServicos(carro);
        }
        private void BtnServico_Click(object sender, EventArgs e)
        {
            if (listBoxCarros.list.SelectedIndex != -1)
            {
                CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
                int selectedIndexCarro = listBoxCarros.list.SelectedIndex;
                int selectedIndexCliente = listBoxClientes.list.SelectedIndex;
                Utilizadores user;
                Servicos servico = new Servicos();
                if (btnServico.ButtonText != SERVICOSAIDA)
                {
                    if (textBoxNomeServico.Text == NOMESERVICO || textBoxNomeServico.Text == "")
                    {
                        return;
                    }
                    servico.Nome = textBoxNomeServico.Text.Trim();
                    servico.DataEntrada = Datapicker.Value;
                    servico.DataSaida = null;
                    servico.CarroIdCarro = carro.IdCarro;
                    bd.ServicosSet.Add(servico);

                }
                else
                {
                    servico = listBoxServicos.list.SelectedItem as Servicos;
                    servico = bd.ServicosSet.Single(id => id.IdServicos == servico.IdServicos);
                    if (servico != null)
                    {
                        servico.DataSaida = Datapicker.Value;
                    }
                    else
                    {
                        return;
                    }

                }
                bd.SaveChanges();
                lerdadosclientes();
                listBoxClientes.list.SelectedIndex = selectedIndexCliente;
                user = listBoxClientes.list.SelectedItem as Utilizadores;
                lerdadosCarros(user);
                listBoxCarros.list.SelectedIndex = selectedIndexCarro;
                carro = listBoxCarros.list.SelectedItem as CarroOficina;
                lerdadosServicos(carro);
            }


        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            listBoxServicos.list.SelectedIndex = -1;
            btnServico.ButtonText = "Criar serviço";
            btnServico.IdleFillColor = Color.DarkCyan;
            btnServico.IdleLineColor = Color.FromArgb(128, 255, 255);
            textBoxNomeServico.Enabled = false;
            textBoxNomeServico.Text = NOMESERVICO; 
            btnCancelar.Visible = false;
            labelData.Text = "Data de Entrada";
            panelParcela.Visible = false;
        }
        private void ListBoxServicos_ChangeSeletedIndex(object sender, EventArgs e)
        {
            if(listBoxServicos.list.SelectedIndex!=-1)
            {
                Servicos servico = listBoxServicos.list.SelectedItem as Servicos;
                if (servico.DataSaida != null)
                {
                    btnFaturar.Enabled = true;
                }
                else
                {
                    btnFaturar.Enabled = false;
                }
            }
           
        }


        //Parcelas
        private void BtnAdicionarParcela_Click(object sender, EventArgs e)
        {
            
            Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
            CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
            Servicos servico = listBoxServicos.list.SelectedItem as Servicos;
            Parcela parcela = new Parcela();
           
            parcela.Descrição = textBoxDescricao.Text;
            parcela.Valor =decimal.Parse(textBoxValorParcela.Text.Replace(".",","));
            parcela.ServicoIdServicos = servico.IdServicos;
            bd.ParcelaSet.Add(parcela);
            bd.SaveChanges();

            
            lerdadosclientes();
            lerdadosCarros(user);
            lerdadosServicos(carro);
            lerdadosParcela(servico);
        }
        private void BtnEliminarParcela_Click(object sender, EventArgs e)
        {
            Utilizadores user = listBoxClientes.list.SelectedItem as Utilizadores;
            CarroOficina carro = listBoxCarros.list.SelectedItem as CarroOficina;
            Servicos servico = listBoxServicos.list.SelectedItem as Servicos;

            Parcela parcela = listBoxParcela.list.SelectedItem as Parcela;
            Parcela parcela_apagar = (Parcela)bd.ParcelaSet.Find(parcela.IdParcela);
            bd.ParcelaSet.Remove(parcela_apagar);
            bd.SaveChanges();

         
            lerdadosclientes();
            lerdadosCarros(user);
            lerdadosServicos(carro);
            lerdadosParcela(servico);
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
        public void lerdadosServicos(CarroOficina carro)
        {
           
            
            bd = new StarDBContainer();
            //listBoxServicos.list.DataSource = null;
            listBoxServicos.list.DataSource = carro.Servicos.ToList();
        }
        public void lerdadosParcela(Servicos servico)
        {
            bd.Dispose();
            bd = new StarDBContainer();
            try
            {
                textBoxTotalParcela.Text = bd.ParcelaSet.Where(id => id.ServicoIdServicos == servico.IdServicos).Sum(tb => tb.Valor).ToString();
            }
            catch(Exception ex)
            {
                textBoxTotalParcela.Text = "0€";
            }
            listBoxParcela.list.DataSource = null;
            listBoxParcela.list.DataSource = servico.Parcela.ToList();
        }


        private void TextBoxNomeServico_Enter(object sender, EventArgs e)
        {
            if(textBoxNomeServico.Text==NOMESERVICO)
            {
                textBoxNomeServico.Text = "";
            }
        }

        private void TextBoxNomeServico_Leave(object sender, EventArgs e)
        {
            if (textBoxNomeServico.Text == "")
            {
                textBoxNomeServico.Text = NOMESERVICO;
            }
        }
        private void TextBoxValorParcela_Enter(object sender, EventArgs e)
        {
            if(textBoxValorParcela.Text==ValorParcela)
            {
                textBoxValorParcela.Text = "";
            }
        }
        private void TextBoxValorParcela_Leave(object sender, EventArgs e)
        {
            if (textBoxValorParcela.Text == "")
            {
                textBoxValorParcela.Text = ValorParcela;
            }
        }
        private void BunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFaturar_Click(object sender, EventArgs e)
        {
            if(listBoxServicos.list.SelectedIndex!=-1)
            {
                //uardar no ficeiro texto 
            }
            else
            {
                MessageBox.Show("Tem de selecionar o serviço que quere faturar");
            }
        }
    }
}
