using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
using System.IO;
namespace StarStand
{
    public partial class USvenda : UserControl
    {
        StarDBContainer bd;
        const string NAOSELECT = "Não selecionado";
        public USvenda()
        {
            InitializeComponent();
        }
        private void ButtonVender_Click(object sender, EventArgs e)
        {
            GerirVendas frm = new GerirVendas();
            frm.ShowDialog();
            lerdadosHistVenda();
        }
        private void BtnDeleteVendas_Click(object sender, EventArgs e)
        {
            Venda venda = listBoxHistVenda.list.SelectedItem as Venda;
            bd.VendaSet.Remove(venda);
            bd.SaveChanges();
            lerdadosHistVenda();
        }
        public void lerdadosHistVenda()
        {
            bd = new StarDBContainer();
            listBoxHistVenda.list.DataSource = bd.VendaSet.ToList();
        }

        private void ListBoxHistVenda_ChangeSeletedIndex(object sender, EventArgs e)
        {
            if(listBoxHistVenda.list.SelectedIndex != -1)
            {
                Venda venda = listBoxHistVenda.list.SelectedItem as Venda;
                labelMostraMarca.Text = venda.CarroVenda.Marca;
                labelMostrarModelo.Text = venda.CarroVenda.Modelo;
                labelMostraMatricula.Text = venda.CarroVenda.Matricula;
                labelMostrarCombustivel.Text = venda.CarroVenda.Combustivel;
                labelMostrarValor.Text = venda.Valor.ToString();
                labelMostrarData.Text = venda.Data.ToString();
                labelMostrarEstado.Text = venda.Estado;
                labelMostrarlUtilizador.Text = venda.Utilizadores.Nome;
                
            }
            else
            {
                labelMostraMarca.Text = NAOSELECT;
                labelMostrarModelo.Text = NAOSELECT;
                labelMostraMatricula.Text = NAOSELECT;
                labelMostrarCombustivel.Text = NAOSELECT;
                labelMostrarValor.Text = NAOSELECT;
                labelMostrarData.Text = NAOSELECT;
                labelMostrarEstado.Text = NAOSELECT;
                labelMostrarlUtilizador.Text = NAOSELECT;
            }
        }

        private void BtnFaturar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fatura", "Faturação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Venda venda = listBoxHistVenda.list.SelectedItem as Venda;
                string textoFatura;
                textoFatura = "<img src='" + pictureBoxCarro.ImageLocation + "'><h3>StarStand</h3>";
                textoFatura += "<hr>";
                textoFatura += "<span>" + venda.Utilizadores.Nome + "</span><br>";
                textoFatura += "<span>" + venda.Utilizadores.NIF + "</span><br>";
                textoFatura += "<span>" + venda.Utilizadores.Morada + "</span><br>";
                textoFatura += "<hr>";
                textoFatura += "<h2>Dados do Carro</h2>";
                textoFatura += "<span><b>Marca:</b>" + venda.CarroVenda.Marca + "</span><br>";
                textoFatura += "<span><b>Modelo:</b>" + venda.CarroVenda.Modelo + "</span><br>";
                textoFatura += "<span><b>Matricula:</b>" + venda.CarroVenda.Matricula + "</span><br>";
                textoFatura += "<span><b>Combustivel:</b>" + venda.CarroVenda.Combustivel + "</span><br>";
                textoFatura += "<span><b>Extra:</b>" + venda.CarroVenda.Extras + "</span><br>";
                textoFatura += "<hr>";
                textoFatura += "<h2>Dados da Compra</h2>";
                textoFatura += "<span>Efetuada a:" + venda.Data + "</span><br>";
                textoFatura += "<span>Valor final :" + venda.Valor + " €</span><br>";
                IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
                Renderer.RenderHtmlAsPdf(textoFatura).SaveAs(Directory.GetCurrentDirectory() + "\\FaturaVenda\\" + venda.IdVenda+ "_" + venda.Utilizadores.Nome+".pdf");

            }
        }
    }
}
