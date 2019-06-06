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
            GerirCarrosAlugados aluguerfrm = new GerirCarrosAlugados();

            if (aluguerfrm.ShowDialog() == DialogResult.OK)
            {
                lerdadosCarro();
            }
        }

     
        private void listboxCarros_ChangeSeletedIndex(object sender, EventArgs e)
        {
            if(listboxCarros.list.SelectedIndex != -1)
            {
                CarroAluguer carroAluguer = listboxCarros.list.SelectedItem as CarroAluguer;
                labelMostraMarca.Text = carroAluguer.Marca;
                labelMostraEstado.Text = carroAluguer.Estado;
                labelMostraValor.Text = carroAluguer.ValorBase + " €";
                labelMostrarModelo.Text = carroAluguer.Modelo;
                labelMostrarMatricula.Text = carroAluguer.Matricula;

                panelright.Visible = true;
                lerdadosClientes();
                if(carroAluguer.Estado=="Alugado")
                {
                    int id = carroAluguer.Aluguer.OrderByDescending(a => a.IdAluguer).Select(a => a.IdAluguer).First();
                    Aluguer aluguer = bd.AluguerSet.Single(a => a.IdAluguer == id);
                    buttonAlugar.Text =ALUGADO;
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
                    if(carroAluguer.Estado=="Disponivel")
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
            else
            {
                labelMostraMarca.Text = NOSELECT;
                labelMostraEstado.Text = NOSELECT;
                labelMostraValor.Text = NOSELECT;
                panelright.Visible = false;
                listboxClientes.list.SelectedIndex = -1;
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

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = listboxCarros.list.SelectedItem as CarroAluguer;
            carroAluguer =(CarroAluguer)bd.CarrosSet.Single(id => id.IdCarro == carroAluguer.IdCarro);

            if (btnSwitch.Value==true)
            {
                carroAluguer.Estado = "Disponivel";
            }
            else
            {
                carroAluguer.Estado = "Indisponivel";
            }

            bd.Entry(carroAluguer).State = EntityState.Modified;
            bd.SaveChanges();
        }
    }
}