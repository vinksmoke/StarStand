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
    public partial class GerirAluguer : Form
    {
        const string KMS = "KMS";

        bool togMoveForm;
        int MvalX;
        int MvalY;

        StarDBContainer bd;
        Utilizadores globalUser;
        CarroAluguer globalCarro;

        public GerirAluguer(Utilizadores user, CarroAluguer carro)
        {
            InitializeComponent();
            globalUser = user;
            globalCarro = carro;
            if(user==null)
            {
                bd = new StarDBContainer();
                int id = globalCarro.Aluguer.OrderByDescending(a => a.IdAluguer).Select(a => a.IdAluguer).First();
                Aluguer aluguer = bd.AluguerSet.Single(a => a.IdAluguer == id);
                DatepickerEntrada.Enabled = false;
                textboxKms.Enabled = true;
                DatepickerEntrada.Value = aluguer.DataInicio;
                DatepickerSaida.Value =(DateTime)aluguer.DataFim;
            }
            else
            {
                DatepickerEntrada.Enabled = true;
                textboxKms.Enabled = false;
            }

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            bd = new StarDBContainer();

            if (textboxKms.Text.Equals("") || textboxKms.Text.Equals("KMS") && textboxKms.Enabled==true)
            {
                MessageBox.Show("KMS: Campo Obrigatório!");
                return;
            }
     

            if (globalUser!=null)
            {
                Aluguer aluguer = new Aluguer();
                aluguer.DataInicio = DatepickerEntrada.Value;
                aluguer.DataFim = DatepickerSaida.Value;
                aluguer.UtilizadoresIdUtilizador = globalUser.IdUtilizador;
                aluguer.CarroAluguerId = globalCarro.IdCarro;
                bd.AluguerSet.Add(aluguer);
                bd.SaveChanges();
                CarroAluguer carroAluguer = bd.CarrosSet.OfType<CarroAluguer>().Single(a=>a.IdCarro==globalCarro.IdCarro);
                carroAluguer.Estado = "Alugado";
                bd.Entry(carroAluguer).State = EntityState.Modified;
                bd.SaveChanges();
            }
            else
            {
                int id =globalCarro.Aluguer.OrderByDescending(a => a.IdAluguer).Select(a => a.IdAluguer).First();
                Aluguer aluguer = bd.AluguerSet.Single(a => a.IdAluguer == id);
                aluguer.DataFim = DatepickerSaida.Value;
                aluguer.Kms = int.Parse(textboxKms.Text);
                aluguer.Valor = decimal.Parse(textboxTotal.Text.Replace("€",""));
                bd.Entry(aluguer).State = EntityState.Modified;
                bd.SaveChanges();

                CarroAluguer carroAluguer = bd.CarrosSet.OfType<CarroAluguer>().Single(a => a.IdCarro == globalCarro.IdCarro);
                carroAluguer.Estado = "Disponível";
                bd.Entry(carroAluguer).State = EntityState.Modified;
                bd.SaveChanges();
                DialogResult result=MessageBox.Show("Deseja fatura?", "Faturação", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    faturacao(aluguer);
                }
            }
            this.Close();   
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatepickerSaida_onValueChanged(object sender, EventArgs e)
        {
            verificarDatas();
        }
        private void DatepickerEntrada_onValueChanged(object sender, EventArgs e)
        {
            verificarDatas();
        }

        private void TextboxKms_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxKms.Text.Count(c => !char.IsDigit(c)) > 0)
            {
                MessageBox.Show("O kms so pode conter numeros");
                textboxKms.Text = textboxKms.Text.Substring(0, textboxKms.Text.Length - 1);
            }
        }

       
        //Funçoes
        private void verificarDatas()
        {
            if (DatepickerEntrada.Value > DatepickerSaida.Value)
            {
                MessageBox.Show("A data de entrada não pode ser maior que a data de saida");
                DatepickerSaida.Value = DatepickerEntrada.Value;
                return;
            }
            else
            {
                int dias = (DatepickerSaida.Value - DatepickerEntrada.Value).Days + 1;
                textboxTotal.Text = (globalCarro.ValorBase * dias) + " €";
            }
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
            textoFatura += "<span>Iniciada :  "+  aluguer.DataInicio.ToLongDateString() + "</span><br>";
            DateTime dataFim =(DateTime)aluguer.DataFim;
            textoFatura += "<span>Finalizada :  " + dataFim.ToLongDateString()  + " </span><br>";
            textoFatura += "<span>Valor base :  " + aluguer.CarroAluguer.ValorBase  + " €</span><br>";
            textoFatura += "<hr>";
            textoFatura += "<span>Total:" + aluguer.Valor  + " €</span><br>";
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.RenderHtmlAsPdf(textoFatura).SaveAs(Directory.GetCurrentDirectory() + "\\FaturaAluguer\\" + aluguer.IdAluguer + "_" + aluguer.Utilizadores.Nome + ".pdf");

        }
        private void setplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == "")
            {
                texbox.Text = texto;
                texbox.TextAlign = HorizontalAlignment.Center;

            }
        }
        private void removeplaceholder(Bunifu.Framework.UI.BunifuMaterialTextbox texbox, string texto)
        {
            if (texbox.Text == texto)
            {
                texbox.Text = "";
                texbox.TextAlign = HorizontalAlignment.Left;

            }
        }
        
        //Placeholder
        private void TextboxKms_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxKms, KMS);
        }
        private void TextboxKms_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxKms, KMS);
        }

        //Mover form
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
