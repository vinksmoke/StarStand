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
    public partial class HistoricoAluguer : Form
    {
        bool togMoveForm;
        int MvalX;
        int MvalY;

        StarDBContainer bd;
        public HistoricoAluguer()
        {
            InitializeComponent();
            lerdadosAluguer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnRemoveCarros_Click(object sender, EventArgs e)
        {
            if(listBoxHist.list.SelectedIndex!=-1)
            {
                Aluguer aluguer = listBoxHist.list.SelectedItem as Aluguer;
                bd.AluguerSet.Remove(aluguer);
                bd.SaveChanges();
                CarroAluguer carro = (CarroAluguer)bd.CarrosSet.Where(id => id.IdCarro == aluguer.CarroAluguerId).First();
                carro.Estado = "Disponível";
                bd.Entry(carro).State = EntityState.Modified;
                bd.SaveChanges();
                lerdadosAluguer();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um aluguer");
            }
           
        }
        private void BtnFaturar_Click(object sender, EventArgs e)
        {
            if (listBoxHist.list.SelectedIndex != -1)
            {
                faturacao(listBoxHist.list.SelectedItem as Aluguer);
            }
        }

        //Funções
        public void lerdadosAluguer()
        {
            bd = new StarDBContainer();
            listBoxHist.list.DataSource = bd.AluguerSet.ToList();
        }
        private void faturacao(Aluguer aluguer)
        {
            string textoFatura;
            textoFatura = "<h1>StarStand</h1>";
            textoFatura += "<hr>";
            textoFatura += "<<h2>Dados do Cliente</h2>";
            textoFatura += "<span>" + aluguer.Utilizadores.Nome + "</span><br>";
            textoFatura += "<span>" + aluguer.Utilizadores.NIF + "</span><br>";
            textoFatura += "<span>" + aluguer.Utilizadores.Morada + "</span><br>";
            textoFatura += "<hr>";
            textoFatura += "<h2>Dados do Carro</h2>";
            textoFatura += "<span><b>Marca :  </b>" + aluguer.CarroAluguer.Marca + "</span><br>";
            textoFatura += "<span><b>Modelo :  </b>" + aluguer.CarroAluguer.Modelo + "</span><br>";
            textoFatura += "<span><b>Matricula :  </b>" + aluguer.CarroAluguer.Matricula + "</span><br>";
            textoFatura += "<span><b>Combustivel :  </b>" + aluguer.CarroAluguer.Combustivel + "</span><br>";
            textoFatura += "<hr>";
            textoFatura += "<h2>Dados do Aluguer</h2>";
            textoFatura += "<span>Iniciada :  " + aluguer.DataInicio.ToLongDateString() + "</span><br>";
            DateTime dataFim = (DateTime)aluguer.DataFim;
            textoFatura += "<span>Finalizada :  " + dataFim.ToLongDateString() + " </span><br>";
            textoFatura += "<span>Valor base :  " + aluguer.CarroAluguer.ValorBase + " €</span><br>";
            textoFatura += "<hr>";
            textoFatura += "<span>Total:" + aluguer.Valor + " €</span><br>";
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.RenderHtmlAsPdf(textoFatura).SaveAs(Directory.GetCurrentDirectory() + "\\FaturaAluguer\\" + aluguer.IdAluguer + "_" + aluguer.Utilizadores.Nome + ".pdf");

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
