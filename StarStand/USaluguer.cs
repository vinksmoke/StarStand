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

        StarDBContainer bd;
        public USaluguer()
        {
            InitializeComponent();
        }

        public void lerdadosclientes()
        {
            bd = new StarDBContainer();
            listboxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }

        private void btnAddCarros_Click(object sender, EventArgs e)
        {
            GerirAlugados aluguerfrm = new GerirAlugados();

            if (aluguerfrm.ShowDialog() == DialogResult.OK)
            {
                lerdados();
            }
        }

        public void lerdados()
        {
            bd = new StarDBContainer();

            listboxCarros.list.DataSource = bd.CarrosSet.OfType<CarroAluguer>().ToList();
        }

        public void lerdadosClientes()
        {
            bd = new StarDBContainer();

            listboxClientes.list.DataSource = bd.UtilizadoresSet.ToList();
        }

        private void listboxCarros_ChangeSeletedIndex(object sender, EventArgs e)
        {
            if(listboxCarros.list.SelectedIndex != -1)
            {
                CarroAluguer aluguer = listboxCarros.list.SelectedItem as CarroAluguer;
                labelMostraMarca.Text = aluguer.Marca;
                labelMostraEstado.Text = aluguer.Estado;
                labelMostraKms.Text = "0";
                labelMostraValor.Text = aluguer.ValorBase + " €";
                panelright.Visible = true;
                lerdadosClientes();
            }
            else
            {
                labelMostraMarca.Text = NOSELECT;
                labelMostraEstado.Text = NOSELECT;
                labelMostraKms.Text = NOSELECT;
                labelMostraValor.Text = NOSELECT;
                panelright.Visible = false;
                listboxClientes.list.SelectedIndex = -1;
            }
        }
    }
}