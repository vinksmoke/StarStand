using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StarStand
{
    public partial class GerirAlugados : Form
    {
        StarDBContainer bd = new StarDBContainer();

        bool togMoveForm;
        int MvalX;
        int MvalY;

        public GerirAlugados()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(btnInserir.Text == "Inserir")
            {
                CarroAluguer aluguer = new CarroAluguer();
                aluguer.Marca = textboxMarca.Text.Trim();
                aluguer.Modelo = textboxModelo.Text.Trim();
                aluguer.ValorBase = decimal.Parse(textboxValorBase.Text.Trim());
                aluguer.Matricula = "StarStand";
                aluguer.Combustivel = comboboxCombustivel.SelectedText;
                aluguer.Estado = "Disponível";
                bd.CarrosSet.Add(aluguer);
            }
            else
            {
               CarroAluguer aluguer = (CarroAluguer)bd.CarrosSet.OfType<CarroAluguer>();
                aluguer.Marca = textboxMarca.Text.Trim();
                aluguer.Modelo = textboxModelo.Text.Trim();
                aluguer.ValorBase = decimal.Parse(textboxValorBase.Text.Trim());
                bd.Entry(aluguer).State = EntityState.Modified;
            }

            bd.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
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
