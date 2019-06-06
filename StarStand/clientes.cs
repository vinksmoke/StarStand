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
    public partial class clientes : UserControl
    {
        StarDBContainer bd;
        public clientes()
        {
            InitializeComponent();
        }

        private void btnAddClientes_Click(object sender, EventArgs e)
        {
            acessGerirClientes();
        }
        private void btnEditClientes_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgv_selectedRow();
            Utilizadores user = (Utilizadores)selectedRow.DataBoundItem;
            acessGerirClientes(user);
        }
        private void btnRemoveClientes_Click(object sender, EventArgs e)
        {
            int index = dgv_Clientes.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgv_Clientes.Rows[index];
            Utilizadores user = (Utilizadores)selectedRow.DataBoundItem;
            bd.Entry(user).State = EntityState.Deleted;
            bd.SaveChanges();
            lerdados();
        }
        private void Dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal totalOficina=0;
            DataGridViewRow selectedRow = dgv_selectedRow();
            Utilizadores user = (Utilizadores)selectedRow.DataBoundItem;
            //carroOficina
            labelValorNCarros.Text = user.CarroOficina.Count.ToString();
            foreach(CarroOficina carro in user.CarroOficina)
            {
                foreach(Servicos servico in carro.Servicos)
                {
                    totalOficina+=servico.Parcela.Sum(v => v.Valor);
                }
            }
            labelValorTotalGOficina.Text = totalOficina.ToString() + " €";

            labelValorCarrosComprados.Text = user.Venda.Count.ToString();
            labelTotalGastoVenda.Text = user.Venda.Sum(v => v.Valor).ToString();
            labelValorCarrosAlugados.Text = user.Aluguer.Count.ToString();
            labelTotalGastoAluguer.Text = user.Aluguer.Sum(v => v.Valor).ToString();
        }

        //Funções
        public void acessGerirClientes(Utilizadores user)
        {
            GerirClientes frm = new GerirClientes(user);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdados();
            }
        }
        public void acessGerirClientes()
        {
            GerirClientes frm = new GerirClientes(null);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdados();
            }
        }
        public void lerdados()
        {
            bd = new StarDBContainer();
           (from Utilizadores in bd.UtilizadoresSet select Utilizadores).Load();
            utilizadoresBindingSource.DataSource = bd.UtilizadoresSet.Local.ToBindingList();
        }

        public DataGridViewRow dgv_selectedRow()
        {
            int index = dgv_Clientes.CurrentCell.RowIndex;
            return dgv_Clientes.Rows[index];
        }

     
    }
}
