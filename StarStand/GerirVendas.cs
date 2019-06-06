using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
namespace StarStand
{
    public partial class GerirVendas : Form
    {
        const string EXTRA = "Extra";

        StarDBContainer bd;
        public GerirVendas()
        {
            InitializeComponent();
            lerdadosclientes();
        }

        private void BtnAddClientes_Click(object sender, EventArgs e)
        {
            GerirClientes frm = new GerirClientes(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lerdadosclientes();
            }
        }
        private void BtnEditClientes_Click(object sender, EventArgs e)
        {
            if (listboxClientes.list.SelectedIndex != -1)
            {
                Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;
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
            if (listboxClientes.list.SelectedIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("Tem a certeza que quere eliminar", "Comfimação", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;
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


        private void BtnSubmeter_Click(object sender, EventArgs e)
        {
            bd = new StarDBContainer();

            Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;

            Venda venda = new Venda();
            venda.Data = DateTime.Now;
            venda.Estado = comboBoxEstado.SelectedText;
            venda.Valor = decimal.Parse(textboxValor.Text.Replace(".", ","));
            venda.UtilizadoresIdUtilizador = user.IdUtilizador;
            CarroVenda carro = new CarroVenda(); 
            carro.Marca= textBoxMarca.Text.Trim(); 
            carro.Modelo= TextBoxModelo.Text.Trim(); 
            carro.Matricula= TextboxMatricula.Text.Trim();
            carro.Combustivel = comboboxCombustivel.SelectedText.Trim();
            if (textBoxExtras.Text == EXTRA || textBoxExtras.Text == "")
                carro.Extras = null;

            else
                carro.Extras = textBoxExtras.Text;
            venda.CarroVenda = carro;
            bd.CarrosSet.Add(carro);
            bd.VendaSet.Add(venda);
            bd.SaveChanges();

            CarroOficina carroOficina = new CarroOficina();
            carroOficina.Marca = venda.CarroVenda.Marca;
            carroOficina.Modelo = venda.CarroVenda.Modelo;
            carroOficina.Matricula = venda.CarroVenda.Matricula;
            carroOficina.Combustivel = venda.CarroVenda.Combustivel;
            carroOficina.Kms = 0;
            carroOficina.UtilizadoresIdUtilizador = venda.UtilizadoresIdUtilizador;
            bd.CarrosSet.Add(carroOficina);
            bd.SaveChanges();
            this.Close();
                
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funçoes
        public void lerdadosclientes()
        {
            bd = new StarDBContainer();
            listboxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }

       
    }
}
