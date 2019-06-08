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
        const string MARCA = "Marca";
        const string MODELO = "Modelo";
        const string MATRICULA = "Matricula";
        const string VALOR = "Valor";

        bool togMoveForm;
        int MvalX;
        int MvalY;

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
            if(listboxClientes.list.SelectedIndex!=-1)
            {
                if (comboboxCombustivel.Text.Equals("Combustível"))
                {
                    MessageBox.Show("Comustível: Selecione um tipo de combustível!");
                    return;
                }
                if (comboBoxEstado.Text.Equals("Estado"))
                {
                    MessageBox.Show("Estado: Selecione um tipo de estado!");
                    return;
                }
                Utilizadores user = listboxClientes.list.SelectedItem as Utilizadores;

                Venda venda = new Venda();
                venda.Data = DateTime.Now;
                venda.Estado = comboBoxEstado.Text;
                try
                {
                    venda.Valor = decimal.Parse(textboxValor.Text.Replace(".", ","));
                }
                catch(FormatException)
                {
                    MessageBox.Show("So pode inserir numeros e '.' ou ','");
                    textboxValor.Text = "";

                    setplaceholder(textboxValor, VALOR);
                    return;
                }
                venda.UtilizadoresIdUtilizador = user.IdUtilizador;
                CarroVenda carro = new CarroVenda();
                carro.Marca = textBoxMarca.Text.Trim();
                carro.Modelo = TextBoxModelo.Text.Trim();
                carro.Matricula = TextboxMatricula.Text.Trim();
                carro.Combustivel = comboboxCombustivel.Text;
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
        private void TextBoxMarca_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textBoxMarca, MARCA);
        }
        private void TextBoxMarca_Leave(object sender, EventArgs e)
        {
            setplaceholder(textBoxMarca, MARCA);
        }

        private void TextBoxModelo_Enter(object sender, EventArgs e)
        {
            removeplaceholder(TextBoxModelo, MODELO);
        }
        private void TextBoxModelo_Leave(object sender, EventArgs e)
        {
            setplaceholder(TextBoxModelo, MODELO);
        }

        private void TextboxMatricula_Enter(object sender, EventArgs e)
        {
            removeplaceholder(TextboxMatricula, MATRICULA);
        }
        private void TextboxMatricula_Leave(object sender, EventArgs e)
        {
            setplaceholder(TextboxMatricula, MATRICULA);
        }

        private void TextBoxExtras_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textBoxExtras, EXTRA);
        }
        private void TextBoxExtras_Leave(object sender, EventArgs e)
        {
            setplaceholder(textBoxExtras, EXTRA);
        }

        private void TextboxValor_Enter(object sender, EventArgs e)
        {
            removeplaceholder(textboxValor, VALOR);
        }
        private void TextboxValor_Leave(object sender, EventArgs e)
        {
            setplaceholder(textboxValor, VALOR);
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
